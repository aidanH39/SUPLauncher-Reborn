using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SUPLauncher_Reborn.Logger;

namespace SUPLauncher_Reborn
{
    public partial class Overlay_sitWidget : UserControl
    {
        public Overlay_sitWidget()
        {
            InitializeComponent();
            new ControlResize(this, panel8);
        }

        public void loadSitCount(SuperiorServers.Profile profile)
        {
            // Show sit count if player is staff.
            if (Properties.Settings.Default.supLogin.Length > 0 && SuperiorServers.IsStaff(profile))
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
                    //this.Dispose();
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
                    Logger.Log(LogType.ERROR, "Overlay.cs | Failed to get player sit count. " + ex.Message + "\n" + ex.StackTrace);
                }
            }
        }
    }
}
