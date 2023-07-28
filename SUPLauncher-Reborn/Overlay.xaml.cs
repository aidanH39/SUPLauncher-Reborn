using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using static SUPLauncher.Logger;
using static SUPLauncher.SuperiorServers;

namespace SUPLauncher
{
    /// <summary>
    /// Interaction logic for Overlay.xaml
    /// </summary>
    public partial class Overlay : Window
    {

        // Rectangle. Rectangle.
        public struct RECT
        {
            public int left, top, right, bottom;
        }

        RECT rect;
        public OverlayPicker picker = null;
        #region imports from user32.dll
        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll")]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(IntPtr hwnd, out RECT ipRect);
        [DllImport("User32.dll")]
        protected static extern int SetClipboardViewer(int hWndNewViewer);
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);
        #endregion

        int currentSession = 0;
        bool playingOnSUP = false;
        public Overlay()
        {
            this.IsVisibleChanged += onVisibilityChange;
            Logger.Log(LogType.INFO, "Starting overlay form.");
            InitializeComponent();
            // Set to size of garry's mod window.
            Logger.Log(LogType.INFO, "Resizing overlay to gmod window...");
            IntPtr handle = Steam.getGMOD();

            GetWindowRect(handle, out rect);

            this.Height = rect.bottom - rect.top;
            this.Width = rect.right - rect.left;
            this.Top = rect.top;
            this.Left = rect.right - this.Width;
            this.Focus();
            Profile profile = SuperiorServers.getProfile(App.profile.SteamID64); // Get SUP profile of current user.
            img_profile.ImageSource = profile.getAvatar();
            lbl_profileName.Content = profile.Badmin.Name;

            _ver.Content = "SUPLauncher v" + App.version.Major + "." + App.version.Minor + "." + App.version.Build;
            this.MouseDown += onOverlayClick;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(60);
            timer.Tick += delegate
            {
                string currentServer = Steam.getPlayingServer(App.profile.SteamID64);
                if (currentServer != null)
                {
                    lbl_currentServer.Content = "Currently playing on " + SuperiorServers.IpToName(currentServer);
                    playingOnSUP = true;
                } else
                {
                    playingOnSUP = false;
                    currentSession = 0;
                    lbl_currentServer.Content = "Not currently playing SUP";
                }
            };
            timer.Start();

            DispatcherTimer playtimeTimer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += delegate
            {
                if (playingOnSUP)
                {
                    currentSession++;
                    lbl_playtime.Content = "Playtime: " + SuperiorServers.PlaytimeFormat(int.Parse(App.profile.Badmin.PlayTime) + currentSession);
                    lbl_sessionTime.Content = "Current session: " + SuperiorServers.LengthFormat(currentSession);
                } else
                {
                    lbl_playtime.Content = "";
                    lbl_sessionTime.Content = "";
                }
            };
            timer.Start();

        }



        /// <summary>
        /// Get Window Messages
        /// </summary>
        /// <param name="e"></param>
        private IntPtr _windowHandle;
        private HwndSource _source;
        protected override void OnSourceInitialized(EventArgs e)
        {
            base.OnSourceInitialized(e);
            _windowHandle = new WindowInteropHelper(this).Handle;
            _ClipboardViewerNext = SetClipboardViewer(_windowHandle);
            
            _source = HwndSource.FromHwnd(_windowHandle);
            _source.AddHook(HwndHook);
        }

        public ProfileOverlay profileOverlay;

        private IntPtr HwndHook(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            // CLIPBOARD HANDLER
            // Check for steamid copies
            if (!AppSettings.Default.enable_profileOverlay) return IntPtr.Zero;
            if (msg == 0x308 || msg == 0x031D) // If message is WM_DRAWCLIPBOARD OR WM_CLIPBOARDUPDATE
            {
                // Make sure its a steamid.
                bool steamid = false;
                long s = 0;
                string text = Clipboard.GetText(); // Get text from clipboard
                // 32 bit stemaids
                if (text.StartsWith("STEAM_") && text.Length > 17)
                {
                    steamid = true;
                }
                else if (long.TryParse(text, out s) && text.Length == 17) // 64 bit ids
                {
                    steamid = true;
                }

                if (!steamid)
                {
                    handled = false;
                    return IntPtr.Zero;
                }
                if (profileOverlay == null || !profileOverlay.IsLoaded)
                {
                    profileOverlay = new ProfileOverlay(text);
                    profileOverlay.Owner = this;
                    profileOverlay.Tag = "pinned";
                    profileOverlay.Show();
                } else
                {
                    profileOverlay.updateProfile(text);
                    profileOverlay.Visibility = Visibility.Visible;
                }
                

                handled = true;
            }
            return IntPtr.Zero;
        }

        void onOverlayClick(object sender, MouseButtonEventArgs e)
        {
            if (picker != null)
            {
                mainGrid.Children.Remove(picker);
            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            mainGrid.Children.Add(new OverlayPicker(new MenuOption
            {
                title = "Exit SUPLauncher",
                image = new BitmapImage(new Uri("pack://application:,,,/textless_logo.png")),
                callback = delegate
                {
                    App.Current.Shutdown();
                }
            }, new MenuOption
            {
                title = "Exit Garry's Mod",
                image = new BitmapImage(new Uri("pack://application:,,,/GarrysMod.png")),
                callback = delegate
                {
                    Steam.getGmodProcess().Kill();
                    Close();
                }
            }));
        }

        private void settings_click(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();
            settings.Owner = this;
            settings.Show();
        }

        private void servers_click(object sender, RoutedEventArgs e)
        {

            List<MenuOption> options = new List<MenuOption>();


            foreach (Server server in SuperiorServers.GetServers())
            {
                if (server.Name.StartsWith("Discord"))
                {
                    continue;
                }
                Uri uri = null;

                if (server.Connect.StartsWith("steam://"))
                {
                    uri = new Uri("pack://application:,,,/textless_logo.png");
                } else if (server.Connect.StartsWith("ts"))
                {
                    uri = new Uri("https://upload.wikimedia.org/wikipedia/commons/e/ec/TeamSpeak_logo_renovado.png");
                } else
                {
                    uri = new Uri("pack://application:,,,/textless_logo.png");
                }

                options.Add(new MenuOption
                {
                    title = server.Name,
                    image = new BitmapImage(uri),
                    callback = delegate
                    {
                        Process myProcess = new Process();
                        myProcess.StartInfo.UseShellExecute = true;
                        myProcess.StartInfo.FileName = server.Connect;
                        myProcess.Start();
                    }
                });
            }

            mainGrid.Children.Add(new OverlayPicker(options.ToArray()));
        }

        private void browser_click(object sender, RoutedEventArgs e)
        {
            Browser browser = new Browser();
            browser.Owner = this;
            browser.Show();
        }

        private void dupe_click(object sender, RoutedEventArgs e)
        {
            Window window = new DupeManagerWindow();
            window.Owner = this;
            window.Show();
        }

        private void onVisibilityChange(object sender, DependencyPropertyChangedEventArgs e)
        {
            foreach (Window window in this.OwnedWindows)
            {
                if (window.Tag != "pinned")
                {
                    window.Visibility = (bool)e.NewValue ? Visibility.Visible : Visibility.Hidden;
                }
            }
        }

        /// <summary>
        /// Event when clipboard was changed.
        /// </summary>
        public class ClipboardChangedEventArgs : EventArgs
        {
            public readonly IDataObject DataObject;
            public ClipboardChangedEventArgs(IDataObject dataObject)
            {
                DataObject = dataObject;
            }
        }

        private IntPtr _ClipboardViewerNext;
    }
}
