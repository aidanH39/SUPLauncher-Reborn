using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SUPLauncher_Reborn.SuperiorServers;

namespace SUPLauncher_Reborn
{
    public partial class Overlay : Form
    {
        public struct RECT
        {
            public int left, top, right, bottom;
        }

        RECT rect;
        public OverlayProfile overlayProfile;

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll")]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(IntPtr hwnd, out RECT ipRect);



        public Overlay()
        {
            InitializeComponent();
        }

        [DllImport("User32.dll")]
        protected static extern int SetClipboardViewer(int hWndNewViewer);

        private void Overlay_Load(object sender, EventArgs e)
        {
            SetClipboardViewer(this.Handle);

            IntPtr handle = Steam.getGMOD();

            GetWindowRect(handle, out rect);
            this.Size = new Size(rect.right - rect.left, rect.bottom - rect.top);
            this.Top = rect.top;
            this.Left = rect.right - this.Bounds.Width;
            this.Focus();

            var client = new WebClient();
            client.Headers.Add("user-agent", "SUPLauncher");
            byte[] avatardata = client.DownloadData(new Uri("https://superiorservers.co/api/avatar/" + Program.steamid));
            using (var ms = new MemoryStream(avatardata))
            {
                img_avatar.Image = Image.FromStream(ms);
                client.Dispose();
                ms.Close();
            }



            Profile profile = SuperiorServers.getProfile(Program.steamid.ToString());
            try
            {
                
                if (profile.Badmin.Name == "Unknown")
                {
                    MessageBox.Show("Invalid SteamID"); // Debug Messages. Remove before commiting
                    return;
                }

                lbl_player_name.Text = profile.Badmin.Name;
                lbl_steamid.Text = profile.SteamID32;
                decimal playtime = profile.Badmin.PlayTime;
                lbl_playtime.Text = Math.Floor(playtime / 60 / 60) + " hours total playtime";
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (Properties.Settings.Default.supLogin.Length > 0 && SuperiorServers.isStaff(profile))
            {

                try
                {
                    HttpWebRequest request = WebRequest.CreateHttp("https://superiorservers.co/api/profile/sits/" + Program.steamid);
                    request.UserAgent = "Browser";
                    request.CookieContainer = new CookieContainer();
                    request.CookieContainer.Add(new Cookie("forum_login_key", Properties.Settings.Default.supLogin) { Domain = "superiorservers.co" });
                    request.CookieContainer.Add(new Cookie("forum_device_key", Properties.Settings.Default.deviceKey) { Domain = "superiorservers.co" });
                    request.CookieContainer.Add(new Cookie("forum_member_id", Properties.Settings.Default.supuserId) { Domain = "superiorservers.co" });
                    WebResponse response = null;
                    response = request.GetResponse(); // Get Response from webrequest
                    StreamReader sr = new StreamReader(response.GetResponseStream()); // Create stream to access web data
                    panel7.Visible = true;
                    var result = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(sr.ReadToEnd());
                    JArray sitCounts = (JArray)result.response;
                    foreach (JObject count in sitCounts)
                    {
                        SitCount panel = new SitCount((string)count.GetValue("label"), (string)count.GetValue("count"));
                        flowLayoutPanel1.Controls.Add(panel);
                    }
                    //lbl_sits_total.Text = result.response;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            


            Notification n = new Notification("OVERLAY", "Overlay has been loaded (ALT + S)");
            n.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public class ClipboardChangedEventArgs : EventArgs
        {
            public readonly IDataObject DataObject;

            public ClipboardChangedEventArgs(IDataObject dataObject)
            {
                DataObject = dataObject;
            }
        }


        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);


        protected override void WndProc(ref Message m)
        {
            // Handle messages...
            base.WndProc(ref m);
            if (m.Msg == 0x308 || m.Msg == 0x031D)
            {
                bool steamid = false;
                long s = 0;

                string text = Clipboard.GetText(); // Get text from clipboard

                if (text.StartsWith("STEAM_") && text.Length > 17)
                {
                    steamid = true;
                }
                else if (long.TryParse(text, out s) && text.Length == 17)
                {
                    steamid = true;
                }

                if (steamid)
                {
                    if (overlayProfile == null || overlayProfile.IsDisposed)
                    {
                        overlayProfile = new OverlayProfile();
                        overlayProfile.loadProfile(SuperiorServers.getProfile(text));
                        overlayProfile.PointToScreen(new Point(0, 150));
                        overlayProfile.Show();
                    } else
                    {
                        overlayProfile.Close();
                        overlayProfile = new OverlayProfile();
                        overlayProfile.loadProfile(SuperiorServers.getProfile(text));
                        overlayProfile.Show();
                    }
                }
            }
        }


        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "STEAM_ID")
            {
                textBox1.Text = "";
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_dupeMang_Click(object sender, EventArgs e)
        {
            DupeManager form = new DupeManager();
            form.TopMost = true;
            form.Show(this);
        }

        private void pnl__Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                ProfileForm form = new ProfileForm(textBox1.Text, true);
                form.Show();   
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(frm_main.serversList["Danktown"].Connect);
        }

        private void btn_zombies_Click(object sender, EventArgs e)
        {
            Process.Start(frm_main.serversList["Zombies"].Connect);
        }

        private void btn_cwrp_Click(object sender, EventArgs e)
        {
            Process.Start(frm_main.serversList["CWRP"].Connect);
        }

        private void btn_cwrp2_Click(object sender, EventArgs e)
        {
            Process.Start(frm_main.serversList["Events"].Connect);
        }

        private void btn_milrp_Click(object sender, EventArgs e)
        {
            Process.Start(frm_main.serversList["MilRP"].Connect);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProfileForm form = new ProfileForm(Program.steamid.ToString(), true);
            form.TopMost = true;
            form.Show(this);
        }
    }
}
