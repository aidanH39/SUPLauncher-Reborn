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
using static SUPLauncher_Reborn.SuperiorServers;

namespace SUPLauncher_Reborn
{
    public partial class frm_main : Form
    {
        public frm_main()
        {


            var settings = new CefSettings();
            settings.CachePath = Application.StartupPath + "\\cookies";
            settings.PersistSessionCookies = true;

            Cef.Initialize(settings);

            instance = this;
            InitializeComponent();
            Opacity = 0;      //first the opacity is 0

            t1.Interval = 10;  //we'll increase the opacity every 10ms
            t1.Tick += delegate
            {
                fadeIn(this);
            };  //this calls the function that changes opacity 
            t1.Start();
            
            toolTip1.SetToolTip(btn_lookup, "Click to show profile of inputed steamid");
            lbl_version.Text = "V" + Application.ProductVersion.ToString();
            //var result = Updater.getCurrentVersion().CompareTo(Updater.getLatestVersion());
            var result = new Version("1.0.0.1").CompareTo(new Version("1.0.0.0"));
            if (result > 0)
            {
                toolTip1.SetToolTip(lbl_version, "You are currently on a beta version!");
                toolTip1.SetToolTip(img_warning, "You are currently on a beta version!");
            } else if (result < 0)
            {
                toolTip1.SetToolTip(lbl_version, "A update is available! Click to update.");
                toolTip1.SetToolTip(img_warning, "A update is available! Click to update.");
            } else
            {
                toolTip1.SetToolTip(lbl_version, "You are currently on the latest version!");
                toolTip1.SetToolTip(img_warning, "You are currently on the latest version!");
            }
        }

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
            
            List<Server> servers = SuperiorServers.getServers();
            foreach (Server server in servers)
            {
                serversList.Add(server.Name, server);
                ServerPanel serverP = new ServerPanel();
                serverP.updateServer(server);
                pnl_servers.Controls.Add(serverP);
            }
            loadImage(img_avatar, "https://superiorservers.co/api/avatar/" + Program.steam.GetSteamId());

            

        }

        // Window Drag

        bool isTopPanelDragged = false;
        Size _normalWindowSize;
        Point _normalWindowLocation = Point.Empty;
        Point offset;
        private void TopBar_MouseUp(object sender, MouseEventArgs e)
        {
            isTopPanelDragged = false;
            if (this.Location.Y <= 5)
            {
                _normalWindowSize = this.Size;
                _normalWindowLocation = this.Location;

                Rectangle rect = Screen.PrimaryScreen.WorkingArea;
                this.Location = new Point(0, 0);
                this.Size = new System.Drawing.Size(rect.Width, rect.Height);
            }
        }

        private void TopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isTopPanelDragged)
            {
                Point newPoint = pnl_topBar.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(offset);
                this.Location = newPoint;

                if (this.Location.X > 2 || this.Location.Y > 2)
                {
                    if (this.WindowState == FormWindowState.Maximized)
                    {
                        this.Location = _normalWindowLocation;
                        this.Size = _normalWindowSize;
                    }
                }
            }
        }

        private void TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isTopPanelDragged = true;
                Point pointStartPosition = this.PointToScreen(new Point(e.X, e.Y));
                offset = new Point
                {
                    X = this.Location.X - pointStartPosition.X,
                    Y = this.Location.Y - pointStartPosition.Y
                };
            }
            else
            {
                isTopPanelDragged = false;
            }
            if (e.Clicks == 2)
            {
                isTopPanelDragged = false;

            }
        }
        public static frm_main instance;
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
            if (check < 7)
            {
                validateCheck(server, check + 1);
            } else
            {
                // Everything is installed proceed with launch.
                lbl_progress.Text = "Launching '" + server.Name + "'...";
                Process.Start(server.Connect);
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


        // Form top button controls.
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


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
            LoginForm form = new LoginForm();
            form.Show();
        }
    }
}
