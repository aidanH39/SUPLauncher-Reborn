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
        public OverlayProfile()
        {
            InitializeComponent();
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
            if (this.Width < 1129)
            {
                this.Size = new Size(1130, this.Height);
            }
            else
            {
                this.Size = new Size(256, this.Height);
            }
            WindowHelper.SetForegroundWindow(Steam.getGMOD());
        }

        public void loadProfile(Profile profile)
        {
            Logger.Log(LogType.INFO, "Loadig overlay profile of " + profile.Badmin.Name + " (" + profile.SteamID32 + ")");
            int playtime = Int32.Parse(profile.Badmin.PlayTime);
            lbl_name.Text = profile.Badmin.Name;
            
            
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
            Properties.Settings.Default.overlayProfilePos = this.Location;
            Properties.Settings.Default.Save();
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
    }
}
