using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SUPLauncher_Reborn.Logger;
using static SUPLauncher_Reborn.SuperiorServers;

namespace SUPLauncher_Reborn
{
    public partial class OverlayProfile : Form
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
        public OverlayProfile()
        {
            InitializeComponent();
            new FormResize(this, pnl_topBar);
            Opacity = 0;      //first the opacity is 0

            t1.Interval = 10;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start();
        }

        #region Fade
        System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();


        void fadeIn(object sender, EventArgs e)
        {
            try
            {
                if (Opacity >= 1)
                    t1.Stop();   //this stops the timer if the form is completely displayed
                else
                    Opacity += 0.05;
            } catch (Exception)
            {
                t1.Stop();
            }
        }

        void fadeOut(object sender, EventArgs e)
        {
            try
            {
                if (Opacity <= 0)     //check if opacity is 0
                {
                    t1.Stop();    //if it is, we stop the timer
                }
                else
                    Opacity -= 0.05;
            } catch (Exception)
            {
                t1.Stop();
            }
}
        #endregion

        private void btn_expand_Click(object sender, EventArgs e)
        {
            toggleExpand();
        }

        public void toggleExpand()
        {
            if (pnl_bans.Width < 850)
            {
                pnl_bans.Size = new Size(850, this.Height);
                this.Size = new Size(this.Width + 850, this.Height);
                this.MinimumSize = new Size(this.MinimumSize.Width + 850, this.MinimumSize.Height);
            }
            else
            {
                this.MinimumSize = new Size(265, this.MinimumSize.Height);
                pnl_bans.Size = new Size(0, this.Height);
                this.Size = new Size(this.Width - 850, this.Height);
            }
            WindowHelper.SetForegroundWindow(Steam.getGMOD());
        }

        public void loadProfile(Profile profile)
        {
            Logger.Log(LogType.INFO, "Loadig overlay profile of " + profile.Badmin.Name + " (" + profile.SteamID32 + ")");
            int playtime = Int32.Parse(profile.Badmin.PlayTime);
            lbl_name.Text = profile.Badmin.Name;

            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(Double.Parse(profile.Badmin.FirstJoin)).ToLocalTime();
            lbl_firstJoin.Text = dateTime.ToString("MM/dd/yyyy h:mm tt");
            txt_steamid.Text = profile.SteamID32;

            TimeSpan time = TimeSpan.FromSeconds(playtime);
            lbl_playTime.Text = SuperiorServers.PlaytimeFormat(playtime);
            profile.setAvatar(img_avatar);
            List<Ban> bans = SuperiorServers.GetBans(profile);

            foreach (Ban ban in bans)
            {
                UserBan banControl = new UserBan();
                pnl_bans.Controls.Add(banControl);
                banControl.loadBan(ban);
            }
            lbl_previousOffenses.Text = bans.Count + " Total PO(s)";

        }

        public void loadProfile(string id)
        {
            loadProfile(SuperiorServers.getProfile(id));
        }

        private void OverlayProfile_Load(object sender, EventArgs e)
        {
            
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            pnl_bans.AutoScroll = false;
            pnl_bans.HorizontalScroll.Enabled = false;
            pnl_bans.HorizontalScroll.Visible = false;
            pnl_bans.HorizontalScroll.Maximum = 0;
            pnl_bans.AutoScroll = true;
            this.Location = Properties.Settings.Default.overlayProfilePos;
            Logger.Log(LogType.INFO, "Overlay profile has loaded.");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            t1 = new Timer();
            t1.Interval = 10;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeOut);  //this calls the function that changes opacity 
            t1.Start();
        }

        private void OverlayProfile_LocationChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.overlayProfilePos = this.Location;
            Properties.Settings.Default.Save();
        }
    }
}
