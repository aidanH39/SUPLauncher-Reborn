using Hardcodet.Wpf.TaskbarNotification;
using Ionic.Zip;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using static SUPLauncher.FileDownloader;
using static SUPLauncher.Logger;
using static SUPLauncher.SuperiorServers;
using Path = System.IO.Path;

namespace SUPLauncher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern bool ShowWindow(IntPtr hwnd, int nCmdShow);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool SetForegroundWindow(IntPtr hwnd);

        public NamedPipe<string> namedPipeString;

        public MainWindow()
        {
            InitializeComponent();

            lbl_version.Content = "V" + App.version.Major + "." + App.version.Minor + "." + App.version.Build;
            this.GotFocus += onFocus;
            scroll_servers.GotFocus += onFocus;

            var scareThemOff = new List<string> { "Hacking into SUP Wallet, taking all GBUX...", "Stealing all dupes...", "Adding user to bot net...", "Grabbing ip and adding to database...", "Downloading hacks for sup to get you banned..." };
            Random random = new Random();

            lbl_loadingMsg.Content = scareThemOff[random.Next(scareThemOff.Count)];

            this.grid_loading.Visibility = Visibility.Visible;

            // start listening for named pipe connections
            namedPipeString = new NamedPipe<string>(NamedPipe<string>.NameTypes.ProtocolHandler);
            namedPipeString.OnRequest += new NamedPipe<string>.Request(protocolHandler_message);
            namedPipeString.window = this;
            namedPipeString.Start();

            lbl_profile.Content = SUPLauncher.App.profile.Badmin.Name.ToUpper();

            reloadServers();

            foreach (Achievement a in App.profile.DarkRP.Achievements)
            {
                WrapPanel panel = new WrapPanel();
                Image image = new Image();
                panel.HorizontalAlignment = HorizontalAlignment.Center;
                image.Source = new BitmapImage(new Uri("https://superiorservers.co/static/images/darkrp/achievements/" + a.UID + ".png"));
                image.Height = 25;
                image.Width = 25;
                panel.Children.Add(image);
                Label label = new Label();
                label.Content = a.Name.ToUpper();
                label.ToolTip = a.Description;
                panel.Children.Add(label);

                profile_achievements.Children.Add(panel);
            }


            // Profile content

            darkrp_rank.Content = App.profile.Badmin.Ranks.DarkRP.ToUpper();
            cwrp_rank.Content = App.profile.Badmin.Ranks.CWRP.ToUpper();
            milrp_rank.Content = App.profile.Badmin.Ranks.MilRP.ToUpper();

            var timeSpent = TimeSpan.FromSeconds(Double.Parse(App.profile.Badmin.PlayTime));

            lbl_playtime.Content = "Time Played: " + Math.Floor(timeSpent.TotalHours) + ":" + timeSpent.Minutes + ":" + timeSpent.Seconds;
            lbl_lastSeen.Content = "Active " + (SuperiorServers.LengthFormat(((int)App.profile.Badmin.LastSeen)) + "AGO").ToUpper();

            lbl_karma.Content = App.profile.DarkRP.Karma;
            if (App.profile.DarkRP.OrgID != null) lbl_org.Content = App.profile.DarkRP.OrgName;

            img_profile.ImageSource = avatar;

            Task.Delay(5000).ContinueWith(delegate
            {
                this.grid_loading.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(() => { this.grid_loading.Visibility = Visibility.Hidden; }));

                if (App.startupArgs.Length > 0)
                {
                    string[] args = App.startupArgs[0].Remove(0, 6).Split("/");
                    if (args[0] == "dupe")
                    {
                        if (args.Length > 1)
                        {
                            NamedPipe<string>.Send(NamedPipe<string>.NameTypes.ProtocolHandler, "downloadDupe:" + args[1]);
                        }
                    }
                }
            });


            if (App.getLatestVersion() > App.version)
            {
                MenuItem item = new MenuItem()
                {
                    Padding = new Thickness(4, 4, 4, 4),
                    Header = "⚠️ Update Available",
                    Margin = new Thickness(20,0,0,0)
                };

                item.Click += delegate
                {
                    Process myProcess = new Process();
                    myProcess.StartInfo.UseShellExecute = true;
                    myProcess.StartInfo.FileName = "ms-appinstaller:?source=https://suplauncher.aidanhud.com/api/launcher/latest.appinstaller";
                    myProcess.Start();
                };
                  
                toolbar._menu.Items.Add(item);
            } else if (App.version > App.getLatestVersion())
            {
                MenuItem item = new MenuItem()
                {
                    Padding = new Thickness(4, 4, 4, 4), 
                    Header = "⚠️ Beta version",
                    Margin = new Thickness(20, 0, 0, 0),
                    Background = (Brush) new BrushConverter().ConvertFrom("#ff8800")
                };
                toolbar._menu.Items.Add(item);
            }

        }


        long lastReload = 0;

        void onFocus(object sender, RoutedEventArgs e)
        {
            if (DateTimeOffset.UtcNow.ToUnixTimeSeconds() >= lastReload + 10)
            {
                reloadServers();
                lastReload = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            }
        }

        public void reloadServers()
        {
            
            Logger.Log(LogType.INFO, "Getting infomation on SUP servers...");
            List<Server> servers = SuperiorServers.GetServers(); // Get infomation on servers
            Logger.Log(LogType.INFO, "Got infomation of SUP servers!");
            tab_servers.Children.Clear();
            foreach (Server server in servers)
            {
                ServerBox serverP = new ServerBox();
                serverP.updateServer(server);
                serverP.MouseDown += delegate
                {
                    connect(server);
                };
                tab_servers.Children.Add(serverP);
            }

            if (Steam.isGmodAFK())
            {
                button_afk.Content = "Exit AFK mode";
            } else
            {
                button_afk.Content = "Start AFK mode";
            }
        }

        void onAFKMode(object sender, RoutedEventArgs e)
        {
            if (Steam.getGmodProcess() != null && !Steam.isGmodAFK())
            {
                Steam.getGmodProcess().Kill();
                Process.Start(Steam.getSteamPath() + "\\steam.exe", "-applaunch 4000 " + AppSettings.Default.afk_arguments);
            } else if (Steam.isGmodAFK())
            {
                Steam.getGmodProcess().Kill();
            } else
            {
                Process.Start(Steam.getSteamPath() + "\\steam.exe", "-applaunch 4000 " + AppSettings.Default.afk_arguments);
            }
            
        }


        void protocolHandler_message(string t)
        {
            Logger.Log(LogType.INFO, "Handling message from pipe server...");
            if (t == "focus")
            {
                namedPipeString.window.Dispatcher.Invoke(() =>
                {
                    namedPipeString.window.Show();
                    namedPipeString.window.WindowState = WindowState.Normal;
                    namedPipeString.window.Activate();
                    namedPipeString.window.BringIntoView();
                });

            }
            else if (t.StartsWith("downloadDupe:"))
            {
                string[] args = t.Split(':');
                namedPipeString.window.Dispatcher.Invoke(() =>
                {
                    ((MainWindow)namedPipeString.window).onDupeClick(null, new RoutedEventArgs());
                    ((MainWindow)namedPipeString.window).tab_dupes.downloadDupe("http://35.224.124.248/api/GetSharedDupe.php?download&key=" + args[1], Steam.getGarrysModPath() + "/garrysmod/data/advdupe2/Downloads");
                });
            }
        }

        

        private void resetSelected()
        {
            // Servers
            lbl_servers.Foreground = (Brush)new BrushConverter().ConvertFrom("White");
            border_servers.BorderThickness = new Thickness(0, 0, 0, 0);
            tab_servers.Visibility = Visibility.Hidden;
            scroll_servers.Visibility = Visibility.Hidden;

            // Dupes
            lbl_dupes.Foreground = (Brush)new BrushConverter().ConvertFrom("White");
            border_dupes.BorderThickness = new Thickness(0, 0, 0, 0);
            tab_dupes.Visibility = Visibility.Hidden;

            // Settings
            lbl_settings.Foreground = (Brush)new BrushConverter().ConvertFrom("White");
            border_settings.BorderThickness = new Thickness(0, 0, 0, 0);
            tab_settings.Visibility = Visibility.Hidden;

            // Profile
            scroll_profile.Visibility = Visibility.Hidden;
            tab_profile.Visibility = Visibility.Hidden;
            lbl_profile.Foreground = (Brush)new BrushConverter().ConvertFrom("White");
            border_profile.BorderThickness = new Thickness(0, 0, 0, 0);


        }

        Duration animationDuration = new Duration(new TimeSpan(0, 0, 0, 0, 350));

        private void onServersClick(object sender, RoutedEventArgs e)
        {
            resetSelected();
            lbl_servers.Foreground = (Brush)new BrushConverter().ConvertFrom("#1A9CFA");
            
            tab_servers.Visibility = Visibility.Visible;
            scroll_servers.Visibility = Visibility.Visible;
            DoubleAnimation anim = new DoubleAnimation(0, animationDuration);
            select_bar.RenderTransform.BeginAnimation(TranslateTransform.XProperty, anim);
            toolbar._appName.Header = "SUPLauncher"; 
            Task.Delay(350).ContinueWith(delegate
            {
                border_servers.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(() => { border_servers.BorderThickness = new Thickness(0, 0, 0, 3); }));
            });
        }

        private void onContextMenu_Open_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Visible;
            this.Activate();
        }

        private void onContextMenu_Settings_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Visible;
            this.Activate();
            onSettingsClick(sender, e);
        }

        private void onContextMenu_Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void onProfileClick(object sender, RoutedEventArgs e)
        {
            resetSelected();
            lbl_profile.Foreground = (Brush)new BrushConverter().ConvertFrom("#1A9CFA");

            tab_profile.Visibility = Visibility.Visible;
            scroll_profile.Visibility = Visibility.Visible;
            DoubleAnimation anim = new DoubleAnimation(430, animationDuration);
            select_bar.RenderTransform.BeginAnimation(TranslateTransform.XProperty, anim);
            toolbar._appName.Header = "SUPLauncher";
            Task.Delay(350).ContinueWith(delegate
            {
                border_profile.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(() => { border_profile.BorderThickness = new Thickness(0, 0, 0, 3); }));
            });
        }

        private void onDupeClick(object sender, RoutedEventArgs e)
        {
            resetSelected();
            lbl_dupes.Foreground = (Brush)new BrushConverter().ConvertFrom("#1A9CFA");
            
            tab_dupes.Visibility = Visibility.Visible;
            
            DoubleAnimation anim = new DoubleAnimation(120, animationDuration);
            select_bar.RenderTransform.BeginAnimation(TranslateTransform.XProperty, anim);
            toolbar._appName.Header = "Dupe Manager";
            Task.Delay(350).ContinueWith(delegate
            {
                border_dupes.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(() => { border_dupes.BorderThickness = new Thickness(0, 0, 0, 3); }));
                //select_bar.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(() => { select_bar.Margin = new Thickness(170, 0, 0, 18); select_bar.RenderTransform = new TranslateTransform(); }));
            });
            
        }

        private void onSettingsClick(object sender, RoutedEventArgs e)
        {
            resetSelected();
            lbl_settings.Foreground = (Brush)new BrushConverter().ConvertFrom("#1A9CFA");

            tab_settings.Visibility = Visibility.Visible;

            DoubleAnimation anim = new DoubleAnimation(240, animationDuration);
            select_bar.RenderTransform.BeginAnimation(TranslateTransform.XProperty, anim);
            toolbar._appName.Header = "Settings";
            Task.Delay(350).ContinueWith(delegate
            {
                border_settings.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(() => { border_settings.BorderThickness = new Thickness(0, 0, 0, 3); }));
                //select_bar.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(() => { select_bar.Margin = new Thickness(170, 0, 0, 18); select_bar.RenderTransform = new TranslateTransform(); }));
            });
        }

        private void pnl_drag_event(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (e.ChangedButton == MouseButton.Left)
                {
                    this.DragMove();
                }
            } catch (Exception)
            {
                Logger.Log(LogType.WARN, "Drag event error, keeping silent.");
            }
        }


        // Methods

        /// <summary>
        /// Connet to a server. First it checks for any files that needs to be downloaded.
        /// </summary>
        public void connect(Server server)
        {
            // First validate all files.
            if (server.Connect.StartsWith("steam"))
            {
                validateCheck(server, 1);
            }
            else
            {
                Process myProcess = new Process();
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = server.Connect;
                myProcess.Start();
            }
        }

        public void css_downloadProgressChange(object sender, DownloadProgress e)
        {
            lbl_progressText.Content = "Downloading CSS content (" + e.ProgressPercentage + "%)";
        }
        public void tf2_downloadProgressChange(object sender, DownloadProgress e)
        {
            lbl_progressText.Content = "Downloading TF2 content (" + e.ProgressPercentage + "%)";
        }


        // IDEA: Allow people to play garrys mod while CSS installs then give them a notification when installed.


        /// <summary>
        /// Checks through GMOD content. First checks to see if GMOD is installed, then checks if CSS textures are installed.
        /// </summary>
        /// <param name="server"></param>
        /// <param name="check"></param>
        private void validateCheck(Server server, int check)
        {
            bool installingContent = false;
            grid_progress.Visibility = Visibility.Visible;
            if (check == 1)
            {
                // Check if GMOD is actually installed.
                lbl_progressText.Content = "Checking for Garry's Mod files...";
                string gmodPath = Steam.getGarrysModPath();
                if (gmodPath == null)
                {
                    lbl_progressText.Content = "Garry's Mod is not installed! Please install garry's mod.";
                    return;
                }
            }
            else if (check == 2)
            {
                // Check if counter strike source content is installed.
                lbl_progressText.Content = "Checking for CSS (Counter Strike Source) content...";
                string gmodPath = Steam.getGarrysModPath();
                bool cssInstalled = false;
                bool tf2Installed = false;
                foreach (string folder in Directory.GetDirectories(gmodPath + "\\garrysmod\\addons"))
                {
                    if (Directory.Exists(folder + "\\materials"))
                    {
                        if (Directory.Exists(folder + "\\materials\\brick") && Directory.Exists(folder + "\\materials\\buildings") && Directory.Exists(folder + "\\materials\\glass") && Directory.Exists(folder + "\\materials\\carpet") && Directory.Exists(folder + "\\materials\\de_dust") && Directory.Exists(folder + "\\materials\\detail"))
                        {
                            cssInstalled = true;
                        }

                        if (Directory.Exists(folder + "\\materials\\backpack") && Directory.Exists(folder + "\\materials\\ambulance") && Directory.Exists(folder + "\\materials\\cable") && Directory.Exists(folder + "\\materials\\vgui") && Directory.Exists(folder + "\\materials\\egypt") && Directory.Exists(folder + "\\materials\\effects"))
                        {
                            tf2Installed = true;
                        }

                    }
                }

                if (!cssInstalled) cssInstalled = Steam.isCSSinstalled();

                if (!tf2Installed) tf2Installed = Steam.isTF2installed();
               
                if (!cssInstalled || !tf2Installed)
                {
                    installingContent = true;
                    InputBox box = new InputBox("They is content needed for SUP to be installed, would you like to launch anyway, and download this content in the background? We will notify you when the content has been installed. A restart will be required after.", BoxType.ACCEPT_CANCEL, "Launch Anyway?");

                    box.ShowDialog();
                    if (box.getConfirm())
                    {
                        launchServer(server, false);
                    }
                }

                if (!cssInstalled)
                {
                    // Download and install CSS textures.
                    lbl_progressText.Content = "Downloading CSS content...";
                    FileDownloader fileDownloader = new FileDownloader();
                    fileDownloader.DownloadProgressChanged += css_downloadProgressChange;
                    fileDownloader.DownloadFileCompleted += delegate
                    {
                        lbl_progressText.Content = "Installed CSS content!";
                        lbl_progressText.Content = "Extracintg CSS content...";
                        Task taskA = Task.Run(() =>
                        {
                            using (ZipFile zip = ZipFile.Read(Path.GetTempPath() + "\\SUPLauncher\\downloads\\CSS-Content.zip"))
                            {
                                zip.ExtractProgress +=
                                   new EventHandler<ExtractProgressEventArgs>(css_zip_ExtractProgress);
                                zip.ExtractAll(Steam.getGarrysModPath() + "\\garrysmod\\addons\\", ExtractExistingFileAction.OverwriteSilently);
                            }
                            this.grid_progress.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(() => { validateCheck(server, check + 1); }));
                            File.Delete(Path.GetTempPath() + "\\SUPLauncher\\downloads\\CSS-Content.zip");
                            NotificationCentre.notify("CSS CONTENT", "Has been downloaded and installed!");
                        });
                    };
                    Directory.CreateDirectory(Path.GetTempPath() + "\\SUPLauncher\\downloads");
                    fileDownloader.DownloadFileAsync(App.CSSLink, Path.GetTempPath() + "\\SUPLauncher\\downloads\\CSS-Content.zip");
                    return;
                }
                else
                {
                    lbl_progressText.Content = "CSS Content is installed!";
                }

                if (!tf2Installed)
                {
                    NotificationCentre.notify("TF2 CONTENT", "Starting to download TF2 content...");
                    // Download and install TF2 textures.
                    lbl_progressText.Content = "Downloading TF2 content...";
                    FileDownloader fileDownloader = new FileDownloader();
                    fileDownloader.DownloadProgressChanged += tf2_downloadProgressChange;
                    fileDownloader.DownloadFileCompleted += delegate
                    {
                        lbl_progressText.Content = "Installed TF2 content!";
                        lbl_progressText.Content = "Extracintg TF2 content...";
                        Task taskA = Task.Run(() =>
                        {
                            using (ZipFile zip = ZipFile.Read(Path.GetTempPath() + "\\SUPLauncher\\downloads\\TF2-Content.zip"))
                            {
                                zip.ExtractProgress +=
                                   new EventHandler<ExtractProgressEventArgs>(tf2_zip_ExtractProgress);
                                zip.ExtractAll(Steam.getGarrysModPath() + "\\garrysmod\\addons\\TF2-Content", ExtractExistingFileAction.OverwriteSilently);
                            }
                            this.grid_progress.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(() => { validateCheck(server, check + 1); }));
                            File.Delete(Path.GetTempPath() + "\\SUPLauncher\\downloads\\TF2-Content.zip");
                            NotificationCentre.notify("TF2 CONTENT", "has been downloaded and installed!");
                        });
                    };
                    Directory.CreateDirectory(Path.GetTempPath() + "\\SUPLauncher");
                    fileDownloader.DownloadFileAsync(App.TF2Link, Path.GetTempPath + "\\SUPLauncher\\downloads\\TF2-Content.zip");
                    return;
                }
                else
                {
                    lbl_progressText.Content = "TF2 Content is installed!";
                }

            }
            if (check < 3)
            {
                validateCheck(server, check + 1);
            }
            else
            {
                if (Steam.getGmodProcess() != null)
                {

                    if (installingContent)
                    {

                        NotificationCentre.notify("CONTENT INSTALLED", "You can now restart your game when you like. Or click this notification to restart now!", () =>
                        {
                            Steam.getGmodProcess().Kill();
                            Task.Delay(2000).ContinueWith((e) =>
                            {
                                launchServer(server);
                            });
                        });
                    }
                    else
                    {
                        launchServer(server);
                    }
                    Task.Delay(2000).ContinueWith(delegate
                    {
                        this.grid_progress.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(() => { this.grid_progress.Visibility = Visibility.Hidden; }));
                    });
                } else
                {
                    launchServer(server);
                }
                
            }
        }

        private void launchServer(Server server, bool hideBar=true)
        {
            // Everything is installed proceed with launch.
            lbl_progressText.Content = "Launching '" + server.Name + "'...";
            // Check if garry's mod is in AFK mode first. If it is, close it and then proceed with launch.
            if (Steam.isGmodAFK())
            {
                Process gmod = Steam.getGmodProcess();
                App.joiningServer = true;
                gmod.Kill();
                Task.Delay(5000).ContinueWith(delegate
                {
                    Process myProcess = new Process();
                    myProcess.StartInfo.UseShellExecute = true;
                    myProcess.StartInfo.FileName = server.Connect;
                    myProcess.Start();
                });
            } else
            {
                Process myProcess = new Process();
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = server.Connect;
                myProcess.Start();
            }

                

            if (hideBar)
            {
                Task.Delay(2000).ContinueWith(delegate
                {
                    this.grid_progress.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(() => { this.grid_progress.Visibility = Visibility.Hidden; }));
                });
            }
        }

        private void css_zip_ExtractProgress(object? sender, ExtractProgressEventArgs e)
        {
            if (e.EntriesTotal > 0)
            {
                int percent = Convert.ToInt32(100 * e.EntriesExtracted / e.EntriesTotal);
                this.lbl_progressText.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(() => { lbl_progressText.Content = "Extracting CSS Content (" + percent + "%)"; }));
            } 
        }


        private void tf2_zip_ExtractProgress(object? sender, ExtractProgressEventArgs e)
        {
            if (e.EntriesTotal > 0)
            {
                int percent = Convert.ToInt32(100 * e.EntriesExtracted / e.EntriesTotal);
                this.lbl_progressText.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(() => { lbl_progressText.Content = "Extracting TF2 Content (" + percent + "%)"; }));
            }
        }


        // Keyboard hook

        // Registers a hot key with Windows.
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
        // Unregisters the hot key with Windows.
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        /// <summary>
        /// Represents the window that is used internally to get the messages.
        /// </summary>

        private const int HOTKEY_ID = 9000;

        /// <summary>
        /// Register hotkey
        /// </summary>
        /// <param name="e"></param>
        private IntPtr _windowHandle;
        private HwndSource _source;
        protected override void OnSourceInitialized(EventArgs e)
        {
            base.OnSourceInitialized(e);

            _windowHandle = new WindowInteropHelper(this).Handle;
            _source = HwndSource.FromHwnd(_windowHandle);
            _source.AddHook(HwndHook);
            try
            {
                RegisterHotKey(_windowHandle, HOTKEY_ID, (uint)AppSettings.Default.bind_overlay_modifier, (uint)AppSettings.Default.bind_overlay_key);
            } catch (Exception ex)
            {
                Logger.Log(LogType.ERROR, "Failed to set keybind \"Overlay (Show/Hide)\". " + ex.Message + "\nStack trace: " + ex.StackTrace);
            }
            try { 
                RegisterHotKey(_windowHandle, HOTKEY_ID + 1, (uint)AppSettings.Default.bind_staff_show_modifier, (uint)AppSettings.Default.bind_staff_show_key);
            }
            catch (Exception ex)
            {
                Logger.Log(LogType.ERROR, "Failed to set keybind \"Profile Overlay (Show/Hide)\". " + ex.Message + "\nStack trace: " + ex.StackTrace);
            }
            try { 
                RegisterHotKey(_windowHandle, HOTKEY_ID + 2, (uint)AppSettings.Default.bind_staff_po_modifier, (uint)AppSettings.Default.bind_staff_po_key);
            } catch (Exception ex)
            {
                Logger.Log(LogType.ERROR, "Failed to set keybind \"Profile Overlay PO's (Show/Hide)\". " + ex.Message + "\nStack trace: " + ex.StackTrace);
            }

            timer.Interval = TimeSpan.FromSeconds(5);
            timer.Tick += timer_tick;
            timer.Start();
        }

        void timer_tick(object sender, EventArgs e)
        {
            if (overlay != null && overlay.IsLoaded)
            {
                Process gmod = Steam.getGmodProcess();
                if ( gmod == null || gmod.HasExited || !AppSettings.Default.enable_overlay)
                {
                    overlay.Close();
                    overlay = null;
                }
            } else if (overlay == null && AppSettings.Default.enable_overlay)
            {
                if (Steam.getGmodProcess() != null && !Steam.isGmodAFK())
                {
                    overlay = new Overlay();
                    NotificationCentre.notify("OVERLAY ENABLED", "Press " + ((ModifierKeys)AppSettings.Default.bind_overlay_modifier).ToString() + " + " + (KeyInterop.KeyFromVirtualKey((int)AppSettings.Default.bind_overlay_key).ToString()) + " to open the overlay.");
                    
                }
            }
        }

        Overlay overlay = null;
        DispatcherTimer timer = new DispatcherTimer();

        private IntPtr HwndHook(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            const int WM_HOTKEY = 0x0312;

            // OVERLAY HANDLING
            if (!AppSettings.Default.enable_overlay)
            {
                return IntPtr.Zero;
            }
            switch (msg)
            {
                case WM_HOTKEY:
                    switch (wParam.ToInt32())
                    {
                        case HOTKEY_ID:
                            
                            int vkey = (((int)lParam >> 16) & 0xFFFF);
                            Process gmod = Steam.getGmodProcess();

                            if (gmod != null && !gmod.HasExited)
                            {
                                WindowHelper.focus(gmod.Id);
                                if (overlay == null || !overlay.IsLoaded)
                                {
                                    overlay = new Overlay();
                                    overlay.Show();
                                    overlay.Focus();
                                }
                                else
                                {
                                    if (overlay.Visibility == Visibility.Visible)
                                    {
                                        WindowHelper.focus(gmod.Id);
                                        overlay.Visibility = Visibility.Hidden;
                                    }
                                    else
                                    {
                                        overlay.Visibility = Visibility.Visible;
                                        overlay.Focus();
                                    }
                                }
                            }
                            break;
                        case HOTKEY_ID + 1:
                            if (overlay.profileOverlay != null && overlay.profileOverlay.IsLoaded)
                            {
                                overlay.profileOverlay.Visibility = overlay.profileOverlay.Visibility == Visibility.Visible ? Visibility.Hidden : Visibility.Visible;
                            }

                            handled = true;
                            break;
                        case HOTKEY_ID + 2:
                            if (overlay.profileOverlay != null && overlay.profileOverlay.IsLoaded)
                            {
                                overlay.profileOverlay.onViewPunishments(null, null);
                            }
                            break;
                    }
                    break;
            }
            return IntPtr.Zero;
        }

        protected override void OnClosed(EventArgs e)
        {
            _source.RemoveHook(HwndHook);
            UnregisterHotKey(_windowHandle, HOTKEY_ID);
            base.OnClosed(e);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Visibility = Visibility.Hidden;
        }
    }
}
