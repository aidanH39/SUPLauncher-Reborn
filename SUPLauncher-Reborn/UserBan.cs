using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SUPLauncher_Reborn.SuperiorServers;

namespace SUPLauncher_Reborn
{
    public partial class UserBan : UserControl
    {
        public UserBan()
        {
            InitializeComponent();
        }

        public void loadBan(Ban ban)
        {

            if (ban.BanID == null)
            {
                this.BackColor = Color.FromArgb(82, 34, 0);
            }

            lbl_admin.Text = ban.AdminName;
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(Double.Parse(ban.Time)).ToLocalTime();
            lbl_date.Text = dateTime.ToString("MM/dd/yyyy h:mm tt");
            lbl_length.Text = SuperiorServers.LengthFormat(ban.Length);
            lbl_reason.Text = ban.Reason;
            lbl_server.Text = ban.Server;
            lbl_unbanReason.Text = ban.UnbanReason;
            frm_main.loadImage(img_admin ,"https://superiorservers.co/api/avatar/" + ban.AdminSteamID64);
        }

    }
}
