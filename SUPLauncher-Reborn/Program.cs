using DiscordRPC;
using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using static SUPLauncher_Reborn.SuperiorServers;

namespace SUPLauncher_Reborn
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static Steam steam;
        public static ulong steamid;
        public static string dupePath = Steam.getGarrysModPath() + "\\garrysmod\\data\\advdupe2";
        public static Overlay overlay;
        public static KeyboardHook overlayHotkeyHook;
        public static KeyboardHook profileOverlayHook;
        public static KeyboardHook profileKeyHook;
        public static Server afkWaitForServer;

        // Link to download CSS content.
        public static string CSSlink = "https://drive.google.com/file/d/1SPO4kx6e-ylkFrIG8R88Yg0ZS2G8WTRI/view?usp=sharing";

        public static EventHandler<Action> serverChanged;
        [STAThread]
        static void Main()
        {

            steam = new Steam();
            steamid = steam.GetSteamId();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            # region Keyboard hooks

            overlayHotkeyHook = new KeyboardHook();
            overlayHotkeyHook.KeyPressed +=
            new EventHandler<KeyPressedEventArgs>(OverlayKey);
            overlayHotkeyHook.RegisterKeybind(Properties.Settings.Default.overlayModiferKey,
                        Properties.Settings.Default.overlayKey);

            profileOverlayHook = new KeyboardHook();
            profileOverlayHook.KeyPressed +=
            new EventHandler<KeyPressedEventArgs>(ProfileOverlayExpand);
            profileOverlayHook.RegisterKeybind(Properties.Settings.Default.overlayModiferKey,
                        Properties.Settings.Default.profileOverlayExpandKey);

            profileKeyHook = new KeyboardHook();
            profileKeyHook.KeyPressed +=
            new EventHandler<KeyPressedEventArgs>(ProfileOverlay);
            profileKeyHook.RegisterKeybind(Properties.Settings.Default.overlayModiferKey,
                        Properties.Settings.Default.profileOverlayKey);

            #endregion

            #region Timers
            Timer timer = new Timer();
            timer.Enabled = true;
            timer.Interval = 5000;
            timer.Tick += delegate
            {
                StartOverlay();
            };
            StartOverlay();
            Timer serverUpdate = new Timer();
            serverUpdate.Enabled = true;
            serverUpdate.Interval = 10000;
            serverUpdate.Tick += delegate
            {
                checkServer();
            };
            #endregion

            rpcClient.Initialize();
            Application.Run(new frm_main());
            
        }
        public static DiscordRpcClient rpcClient = new DiscordRpcClient("1003419232769409084");
        public static string lastIp;
        private static long joinedSince = 0;

        private static void checkServer()
        {
            string ip = MyCustomSteamAPI.getPlayingServer(steamid.ToString());
            updateDiscord(ip);
            if (ip != lastIp)
            {
                lastIp = ip;
                joinedSince = DateTimeOffset.Now.ToUnixTimeSeconds();
                serverChanged.Invoke(null, null);
            }
            if (afkWaitForServer != null)
            {
                if (Steam.getGmodProcess() == null)
                {
                    Process.Start(afkWaitForServer.Connect);
                }
                else
                {
                    afkWaitForServer = null;
                }
            }
            if (Properties.Settings.Default.afkModeEnabeld && Steam.getGmodProcess() == null)
            {
                if (!Steam.isGmodAFK() && afkWaitForServer == null)
                {
                    // Find the steam file instead of using URL's. As this bypasses the anoying popup :)
                    Process.Start(Steam.getSteamPath() + "\\steam.exe", "-applaunch 4000 -64bit -textmode -single_core -nojoy -low -nosound -sw -noshader -nopix -novid -nopreload -nopreloadmodels -multirun +connect rp.superiorservers.co");
                }
            }
        }

        /// <summary>
        /// Update the discord RPC
        /// </summary>
        public static void updateDiscord(string ip=null)
        {
            if (Properties.Settings.Default.discordRPCEnabled)
            {
                if (ip == null) ip = MyCustomSteamAPI.getPlayingServer(steamid.ToString());
                long secondsJoined = DateTimeOffset.Now.ToUnixTimeSeconds() - joinedSince;
                string name = SuperiorServers.IpToName(ip);
                string playingon;
                if (name != null)
                {
                    playingon = "Playing on " + SuperiorServers.IpToName(ip);
                }
                else
                {
                    playingon = "Not currently playing SUP";

                }
                rpcClient.SetPresence(new RichPresence()
                {
                    Details = playingon,
                    State = "for " + SuperiorServers.LengthFormat(Int32.Parse(secondsJoined.ToString())),
                    Assets = new Assets()
                    {
                        SmallImageText = "SuperiorServers",
                        SmallImageKey = "sup_small"
                    }
                });
            }
            else
            {
                rpcClient.ClearPresence();
            }
            
        }

        public static bool overlayEnabled = true;
        private static bool overlayVisible = false;
        /// <summary>
        /// This opens the overlay, when gmod is present.
        /// </summary>
        public static void StartOverlay()
        {
            if (overlay == null || overlay.IsDisposed)
            {
                if (Steam.getGMOD() != IntPtr.Zero)
                {
                    overlay = new Overlay();
                    overlay.Show();
                    overlay.Visible = false;
                }
            }
        }

        /// <summary>
        /// This checks if auto startup is enabled. If it is, then it will add it to the windows startup folder, else it will delete it.
        /// </summary>
        public static void UpdateStartup()
        {
            if (Properties.Settings.Default.AutoStartup)
            {
                if (!System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\SUPLauncher.lnk"))
                {
                    IWshShortcut shortcut;
                    WshShell wshShell = new WshShell();
                    shortcut =
              (IWshRuntimeLibrary.IWshShortcut)wshShell.CreateShortcut(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\SUPLauncher.lnk");
                    shortcut.TargetPath = Application.ExecutablePath;
                    shortcut.WorkingDirectory = Application.StartupPath;
                    shortcut.Description = "Open SUPLauncher";
                    shortcut.Save();
                }
            } else
            {
                if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\SUPLauncher.lnk"))
                {
                    System.IO.File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\SUPLauncher.lnk");
                }

            }
        }

        /// <summary>
        /// The keyboard hook to expand the profile overlay.
        /// </summary>
        public static void ProfileOverlayExpand(object sender, KeyPressedEventArgs e)
        {
            if (overlayEnabled && overlay.overlayProfile != null && !overlay.overlayProfile.IsDisposed)
            {
                overlay.overlayProfile.toggleExpand();
            }
        }

        /// <summary>
        /// The keyboard hook to toggle visibility on the profile overlay.
        /// </summary>
        public static void ProfileOverlay(object sender, KeyPressedEventArgs e)
        {
            if (overlayEnabled && overlay.overlayProfile != null && !overlay.overlayProfile.IsDisposed)
            {
                if (overlay.overlayProfile.Visible)
                {
                    overlay.overlayProfile.Hide();
                } else
                {
                    overlay.overlayProfile.Show();
                }
                
            }
        }

        /// <summary>
        /// Keyboard hook for overlay.
        /// </summary>
        private static void OverlayKey(object sender, KeyPressedEventArgs e)
        {
            if (overlayEnabled)
            {
                try
                {
                    if (overlay.Visible)
                    {
                        overlay.Visible = false;
                        WindowHelper.SetForegroundWindow(Steam.getGMOD());
                    }
                    else
                    {
                        WindowHelper.SetForegroundWindow(Steam.getGMOD());
                        overlay.Visible = true;
                        WindowHelper.SetForegroundWindow(Process.GetCurrentProcess().Handle);
                    }
                }
                catch
                {
                    overlay.Visible = false;
                }
            }
        }
    }
}
