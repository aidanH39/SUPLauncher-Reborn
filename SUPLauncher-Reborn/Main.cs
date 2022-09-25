using CefSharp;
using CefSharp.WinForms;
using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SUPLauncher_Reborn.FileDownloader;
using static SUPLauncher_Reborn.Logger;
using static SUPLauncher_Reborn.SuperiorServers;

namespace SUPLauncher_Reborn
{
    public partial class frm_main : Form
    {

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        // Main form window
        public frm_main()
        {
            
            // Init browser shit.
            Logger.Log(LogType.INFO, "Starting main form...");

            

            var settings = new CefSettings();
            settings.CachePath = Application.StartupPath + "\\cookies";
            settings.PersistSessionCookies = true;

            Logger.Log(LogType.INFO, "Init browser settings...");
            // Init browser settings.
            Cef.Initialize(settings);
            instance = this;
            InitializeComponent();

            // Fade the form in.
            Opacity = 0;     
            t1.Interval = 10;  
            t1.Tick += delegate
            {
                fadeIn(this);
            }; 
            t1.Start();
            
            toolTip1.SetToolTip(btn_lookup, "Click to show profile of inputed steamid");
            lbl_version.Text = "V" + Updater.getCurrentVersion().ToString();

            // Check latest version
            Logger.Log(LogType.INFO, "Checking program version.");
            var result = Updater.getCurrentVersion().CompareTo(Updater.getLatestVersion());
            if (result > 0)
            {
                Logger.Log(LogType.INFO, "Currently on a BETA version.");
                toolTip1.SetToolTip(lbl_version, "You are currently on a beta version!");
                toolTip1.SetToolTip(img_warning, "You are currently on a beta version!");
                img_warning.Visible = true;
            } else if (result < 0)
            {
                Logger.Log(LogType.WARN, "Program version is behind. Keep up to date!");
                toolTip1.SetToolTip(lbl_version, "A update is available! Click to update.");
                toolTip1.SetToolTip(img_warning, "A update is available! Click to update.");
                img_warning.Visible = true;
            } else
            {
                toolTip1.SetToolTip(lbl_version, "You are currently on the latest version!");
                toolTip1.SetToolTip(img_warning, "You are currently on the latest version!");
            }

            Program.serverChanged += delegate
            {
                
                string name = SuperiorServers.IpToName(Program.lastIp);
                if (name != null)
                {
                    lbl_server.Text = "Currently playing " + name;
                } else
                {
                    lbl_server.Text = "Currently not playing SUP";
                }
            };
            
        }

        /// <summary>
        /// Loads a picture into a picture frame. Sends request with `user-agent` header.
        /// </summary>
        /// <param name="img"></param>
        /// <param name="url"></param>
        public static void loadImage(PictureBox img, String url)
        {
            var client = new WebClient();
            client.Headers.Add("user-agent", "SUP Launcher: v" + Application.ProductVersion); // Set a header for the SUP Avatar API web request so it doesn't get blocked :)
            byte[] avatardata = client.DownloadData(new Uri(url));
            using (var ms = new MemoryStream(avatardata))
            {
                img.Image = Image.FromStream(ms);
                client.Dispose();
                ms.Close();
            }
        }
        public static Dictionary<String, Server> serversList = new Dictionary<string, Server>();

        private void frm_main_Load(object sender, EventArgs e)
        {
            new FormResize(this, pnl_topBar);
            Profile profile = SuperiorServers.getProfile(Program.steamid.ToString());
            lbl_playerName.Text = profile.Badmin.Name;
            Logger.Log(LogType.INFO, "Getting infomation on SUP servers...");
            List<Server> servers = SuperiorServers.GetServers(); // Get infomation on servers
            Logger.Log(LogType.INFO, "Got infomation of SUP servers!");
            foreach (Server server in servers)
            {
                serversList.Add(server.Name, server);
                ServerPanel serverP = new ServerPanel();
                serverP.updateServer(server);
                pnl_servers.Controls.Add(serverP);
            }
            loadImage(img_avatar, "https://superiorservers.co/api/avatar/" + Program.steam.GetSteamId()); // Load player's avatar.
            chk_afkMode.Checked = Properties.Settings.Default.afkModeEnabeld;

            Logger.Log(LogType.INFO, "Main form has fully loaded!");
        }

        public static frm_main instance;
        /// <summary>
        /// Connet to a server. First it checks for any files that needs to be downloaded.
        /// </summary>
        public void connect(Server server)
        {
            // First validate all files.
            if (server.Connect.StartsWith("steam"))
            {
                validateCheck(server, 1);
            } else
            {
                Process.Start(server.Connect);
            }
        }

        #region Fade
        System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();


        void fadeIn(dynamic obj)
        {
            if (Opacity >= 1)
            {
                t1.Stop();   //this stops the timer if the form is completely displayed
            }
            else
            {
                obj.Opacity += 0.05;
            }
        }

        void fadeOut(dynamic obj)
        {
            if (Opacity <= 0)     //check if opacity is 0
            {
                t1.Stop();    //if it is, we stop the timer
                Close();   //and we try to close the form
            }
            else
                obj.Opacity -= 0.05;
        }
        #endregion

        /// <summary>
        /// Checks through GMOD content. First checks to see if GMOD is installed, then checks if CSS textures are installed.
        /// </summary>
        /// <param name="server"></param>
        /// <param name="check"></param>
        private void validateCheck(Server server, int check)
        {
            lbl_progress.Visible = true;
            cProgressBar1.Visible = true;
            if (check == 1)
            {
                // Check if GMOD is actually installed.
                lbl_progress.Text = "Checking for Garry's Mod files...";
                string gmodPath = Steam.getGarrysModPath();
                if (gmodPath == null) {
                    lbl_progress.Text = "Garry's Mod is not installed! Please install garry's mod.";  
                    return;
                } 
            } else if (check == 2) {
                // Check if counter strike source content is installed.
                lbl_progress.Text = "Checking for CSS (Counter Strike Source) content...";
                string gmodPath = Steam.getGarrysModPath();
                bool cssInstalled = false;
                foreach (string folder in Directory.GetDirectories(gmodPath + "\\garrysmod\\addons"))
                {
                    if (Directory.Exists(folder + "\\materials"))
                    {
                        if (Directory.Exists(folder + "\\materials\\brick") && Directory.Exists(folder + "\\materials\\buildings") && Directory.Exists(folder + "\\materials\\glass") && Directory.Exists(folder + "\\materials\\carpet") && Directory.Exists(folder + "\\materials\\metal") && Directory.Exists(folder + "\\materials\\detail"))
                        {
                            cssInstalled = true;
                        }
                    }
                }

                if (!cssInstalled)
                {
                    cssInstalled = Steam.isCSSinstalled();
                }

                if (!cssInstalled)
                {
                    // Download and install CSS textures.
                    lbl_progress.Text = "Downloading CSS content...";
                    FileDownloader fileDownloader = new FileDownloader();
                    fileDownloader.DownloadProgressChanged += downloadProgressChange;
                    fileDownloader.DownloadFileCompleted += delegate
                    {
                        lbl_progress.Text = "Installed CSS content!";
                        lbl_progress.Text = "Extracintg CSS content...";
                        Task taskA = Task.Run(() =>
                        {
                            using (ZipFile zip = ZipFile.Read(Application.StartupPath + "\\downloads\\CSS-Content.zip"))
                            {
                                zip.ExtractProgress +=
                                   new EventHandler<ExtractProgressEventArgs>(zip_ExtractProgress);
                                zip.ExtractAll(Steam.getGarrysModPath() + "\\garrysmod\\addons\\", ExtractExistingFileAction.InvokeExtractProgressEvent);
                            }
                            this.Invoke(new Action(() => validateCheck(server, check + 1)));
                            File.Delete(Application.StartupPath + "\\downloads\\CSS-Content.zip");
                        });
                    };
                    Directory.CreateDirectory(Application.StartupPath + "\\downloads");
                    fileDownloader.DownloadFileAsync(Program.CSSlink,Application.StartupPath + "\\downloads\\CSS-Content.zip");
                    return;
                } else
                {
                    lbl_progress.Text = "CSS Content is installed!";
                }
            }
            if (check < 3)
            {
                validateCheck(server, check + 1);
            } else
            {
                // Everything is installed proceed with launch.
                lbl_progress.Text = "Launching '" + server.Name + "'...";
                // Check if garry's mod is in AFK mode first. If it is, close it and then proceed with launch.
                if (Steam.isGmodAFK())
                {
                    Process gmod = Steam.getGmodProcess();
                    Program.afkWaitForServer = server;
                    Process[] p = Process.GetProcessesByName("gmod");
                    foreach (Process pro in p)
                    {
                        try
                        {
                            pro.Kill();
                        } catch(Exception) { }
                    }
                }
                else
                {
                    Process.Start(server.Connect);
                }
                cProgressBar1.Value = 100;
            }
        }

        // Extracting progress when installing CSS content.
        void zip_ExtractProgress(object sender, ExtractProgressEventArgs e)
        {
            if (e.TotalBytesToTransfer > 0)
            {
                cProgressBar1.Value = Convert.ToInt32(100 * e.BytesTransferred / e.TotalBytesToTransfer);
                
                this.lbl_progress.BeginInvoke((MethodInvoker)delegate () { this.lbl_progress.Text = "Extracting '" + e.CurrentEntry.FileName + "'"; });
            } 
        }

        // progress when downloading CSS content.
        private void downloadProgressChange(object sender, DownloadProgress e)
        {
            cProgressBar1.Value = e.ProgressPercentage;
        }

        private void img_avatar_Click(object sender, EventArgs e)
        {
            ProfileForm form = new ProfileForm(Program.steamid.ToString());
            form.Show();
        }

        #region Form top button controls.
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            notifyIcon1.ShowBalloonTip(5);
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        // Lookup profile click event.
        private void btn_lookup_Click(object sender, EventArgs e)
        {
            ProfileForm form = new ProfileForm(txt_lookup.Text);
            form.Show();
        }

        private void lbl_version_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Application Version";
        }

        private void btn_lookup_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "PROFILE LOOKUP";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SUPLogin form = new SUPLogin();
            form.Show();
        }

        private void chk_afkMode_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.afkModeEnabeld = chk_afkMode.Checked;
            Properties.Settings.Default.Save();
        }

        private void lbl_version_Click(object sender, EventArgs e)
        {
            Updater.downloadLatestVersion();
        }

        private void img_warning_Click(object sender, EventArgs e)
        {
            Updater.downloadLatestVersion();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Visible = true;
            } else
            {
                this.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DupeManager form = new DupeManager();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DupeMarketPlace form = new DupeMarketPlace();
            form.Show();
        }
    }
}
