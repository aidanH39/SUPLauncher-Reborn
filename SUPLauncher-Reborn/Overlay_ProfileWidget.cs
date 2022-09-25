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
using static SUPLauncher_Reborn.SuperiorServers;

namespace SUPLauncher_Reborn
{
    public partial class Overlay_ProfileWidget : UserControl
    {
        public Overlay_ProfileWidget()
        {
            InitializeComponent();
            new ControlResize(this, pnl_left);
        }

        public void loadProfile(Profile profile)
        {

            var client = new WebClient();
            client.Headers.Add("user-agent", "SUPLauncher");
            byte[] avatardata = client.DownloadData(new Uri("https://superiorservers.co/api/avatar/" + Program.steamid));
            using (var ms = new MemoryStream(avatardata))
            {
                Logger.Log(LogType.INFO, "Got avatar of '" + Program.steamid + "'");
                img_avatar.Image = Image.FromStream(ms);
                client.Dispose();
                ms.Close();
            }

            try
            {
                if (profile.Badmin.Name == "Unknown")
                {
                    MessageBox.Show("Invalid SteamID");
                    return;
                }
                lbl_player_name.Text = profile.Badmin.Name;
                lbl_steamid.Text = profile.SteamID32;
                decimal playtime = decimal.Parse(profile.Badmin.PlayTime);
                lbl_playtime.Text = Math.Floor(playtime / 60 / 60) + " hours total playtime";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Log(LogType.ERROR, "Overlay.cs | Failed to get player's profile. " + ex.Message + "\n" + ex.StackTrace);
            }
        }
    }
}
