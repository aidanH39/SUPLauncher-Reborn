using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SUPLauncher_Reborn.DupeMarket;

namespace SUPLauncher_Reborn
{
    public partial class DupeMarketPlace : Form
    {
        public DupeMarketPlace()
        {
            InitializeComponent();
            pnl_browsedupeList.AutoScroll = false;
            pnl_browsedupeList.HorizontalScroll.Enabled = false;
            pnl_browsedupeList.HorizontalScroll.Visible = false;
            pnl_browsedupeList.HorizontalScroll.Maximum = 0;
            pnl_browsedupeList.AutoScroll = true;

            pnl_ownedDupesList.AutoScroll = false;
            pnl_ownedDupesList.HorizontalScroll.Enabled = false;
            pnl_ownedDupesList.HorizontalScroll.Visible = false;
            pnl_ownedDupesList.HorizontalScroll.Maximum = 0;
            pnl_ownedDupesList.AutoScroll = true;

            pnl_publishedDupesList.AutoScroll = false;
            pnl_publishedDupesList.HorizontalScroll.Enabled = false;
            pnl_publishedDupesList.HorizontalScroll.Visible = false;
            pnl_publishedDupesList.HorizontalScroll.Maximum = 0;
            pnl_publishedDupesList.AutoScroll = true;


            if (Properties.Settings.Default.apiSecret.Length < 1)
            {
                APILogin form = new APILogin();
                form.TopMost = TopMost;
                form.Show();
            }
            navControls = new Panel[] { pnl_ownedDupesInd, pnl_publishedDupeInd, pnl_BrowseDupesInd };
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        bool isTopPanelDragged = false;
        bool isWindowMaximized = false;
        Point offset;
        Size _normalWindowSize;
        Point _normalWindowLocation = Point.Empty;
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

        private void TopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isTopPanelDragged)
            {
                Point newPoint = TopBar.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(offset);
                this.Location = newPoint;

                if (this.Location.X > 2 || this.Location.Y > 2)
                {
                    if (this.WindowState == FormWindowState.Maximized)
                    {
                        this.Location = _normalWindowLocation;
                        this.Size = _normalWindowSize;

                        isWindowMaximized = false;
                    }
                }
            }
        }

        private void TopBar_MouseUp(object sender, MouseEventArgs e)
        {
            isTopPanelDragged = false;
            if (this.Location.Y <= 5)
            {
                if (!isWindowMaximized)
                {
                    _normalWindowSize = this.Size;
                    _normalWindowLocation = this.Location;

                    Rectangle rect = Screen.PrimaryScreen.WorkingArea;
                    this.Location = new Point(0, 0);
                    this.Size = new System.Drawing.Size(rect.Width, rect.Height);

                    isWindowMaximized = true;
                }
            }
        }

        private void DupeMarketPlace_Load(object sender, EventArgs e)
        {
            List<Dupe> dupes = DupeMarket.GetDupes(10);
            
            foreach (Dupe dupe in dupes)
            {
                pnl_browsedupeList.Controls.Add(new DupeDisplay(dupe));
            }

            dupes = DupeMarket.GetDupesBy(Program.steamid.ToString());

            foreach (Dupe dupe in dupes)
            {
                pnl_publishedDupesList.Controls.Add(new DupeDisplay(dupe));
            }

            dupes = DupeMarket.GetOwnedDupes();

            foreach (Dupe dupe in dupes)
            {
                pnl_ownedDupesList.Controls.Add(new DupeDisplay(dupe));
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnl_publishedDupes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_lookup_Click(object sender, EventArgs e)
        {
            UploadDupe form = new UploadDupe();
            form.Show();
        }
        Panel[] navControls;
        private void pnl_ownedDupes_Click(object sender, EventArgs e)
        {
            foreach (Panel c in navControls)
            {
                c.BackColor = Color.FromArgb(65, 65, 65);
            }
            pnl_ownedDupesInd.BackColor = Color.FromArgb(47, 129, 255);
            customTabControl1.SelectTab(0);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            foreach (Panel c in navControls)
            {
                c.BackColor = Color.FromArgb(65, 65, 65);
            }
            pnl_BrowseDupesInd.BackColor = Color.FromArgb(47, 129, 255);
            customTabControl1.SelectTab(1);
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            foreach (Panel c in navControls)
            {
                c.BackColor = Color.FromArgb(65, 65, 65);
            }
            pnl_publishedDupeInd.BackColor = Color.FromArgb(47, 129, 255);
            customTabControl1.SelectTab(2);
        }
    }
}
