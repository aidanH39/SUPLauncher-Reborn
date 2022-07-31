using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUPLauncher_Reborn
{
    static class Program
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

        public static string CSSlink = "https://drive.google.com/file/d/1SPO4kx6e-ylkFrIG8R88Yg0ZS2G8WTRI/view?usp=sharing";


        [STAThread]
        static void Main()
        {

            steam = new Steam();
            steamid = steam.GetSteamId();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
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

            Timer timer = new Timer();
            timer.Enabled = true;
            timer.Interval = 5000;
            timer.Tick += delegate
            {
                startOverlay();
            };
            startOverlay();
            Application.Run(new frm_main());
            
        }

        
        public static bool overlayEnabled = true;
        private static bool overlayVisible = false;
        
        public static void startOverlay()
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

        public static void ProfileOverlayExpand(object sender, KeyPressedEventArgs e)
        {
            if (overlayEnabled && overlay.overlayProfile != null && !overlay.overlayProfile.IsDisposed)
            {
                overlay.overlayProfile.toggleExpand();
            }
        }

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
