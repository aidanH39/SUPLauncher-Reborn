using CefSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUPLauncher_Reborn
{
    public partial class ProfileForm : Form
    {
        string steamid;
        public ProfileForm(string steamid, bool topMost=false)
        {
            this.steamid = steamid;
            InitializeComponent();
            this.cProgressBar1.Value = 25;
            chromiumWebBrowser1.Load("https://superiorservers.co/profile/" + steamid);
            this.Text = steamid + " Lookup";
            chromiumWebBrowser1.LoadingStateChanged += loadChange;
            this.cProgressBar1.Value = 50;
            if (topMost)
            {
                TopMost = true;
                ShowInTaskbar = false;
            }
        }
        
        private void loadChange(object sender, LoadingStateChangedEventArgs args)
        {
            if (!args.IsLoading)
            {
                args.Browser.ExecuteScriptAsync("document.querySelector('nav').remove();");
                this.cProgressBar1.BeginInvoke((MethodInvoker)delegate () { this.cProgressBar1.Value = 100; });
                Timer t = new Timer();
                t.Enabled = true;
                t.Interval = 1000;
                t.Tick += delegate
                {
                    this.pnl_loading.BeginInvoke((MethodInvoker)delegate () { this.pnl_loading.Visible = false; });
                    t.Enabled = false;
                    t.Stop();
                    t.Dispose();
                };
                
            }
        }

        private void Profile_Load(object sender, EventArgs e)
        {

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

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
