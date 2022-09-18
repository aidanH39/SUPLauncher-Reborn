using CefSharp;
using CefSharp.WinForms;
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
    public partial class LoginForm : Form
    {

        ChromiumWebBrowser browser;

        public LoginForm()
        {
            


            browser = new ChromiumWebBrowser();
            InitializeComponent();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            browser.Dock = DockStyle.Fill;

            browser.LoadingStateChanged += chromiumWebBrowser1_LoadingStateChanged;
            this.pnl_browser.Controls.Add(browser);
            browser.Load("https://superiorservers.co/api/auth/login/?return=https%3A%2F%2Fsuperiorservers.co%2F");
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

        private async Task getCookies()
        {
            var cookieManager = Cef.GetGlobalCookieManager();
            var visitor = new CookieCollector();
            cookieManager.VisitUrlCookies(browser.Address, true, visitor);

            var cookies = await visitor.Task; // AWAIT !!!!!!!!!
            var cookieHeader = CookieCollector.GetCookieHeader(cookies);
            MessageBox.Show(cookieHeader);
            if (cookieHeader != null)
            {
                string[] st = cookieHeader.Split('=');
            }
            
        }

        private void chromiumWebBrowser1_LoadingStateChanged(object sender, CefSharp.LoadingStateChangedEventArgs e)
        {
            CookieVisitor visitor = new CookieVisitor();
            visitor.SendCookie += visitor_SendCookie;
            ICookieManager cookieManager = browser.GetCookieManager();
            cookieManager.VisitAllCookies(visitor);
        }


        bool forumKeyDone = false;
        bool deviceKeyDone = false;
        bool useridDone = false;
        bool closing = false;
        private void visitor_SendCookie(CefSharp.Cookie obj)
        {
            
            if (obj.Name == "forum_login_key")
            {
                Properties.Settings.Default.supLogin = obj.Value;


                forumKeyDone = true;
            } else if (obj.Name == "forum_member_id") {
                Properties.Settings.Default.supuserId = obj.Value;
                useridDone = true;
            } else if (obj.Name == "forum_device_key")
            {
                Properties.Settings.Default.deviceKey = obj.Value;
                deviceKeyDone = true;
            }

            if (forumKeyDone && deviceKeyDone && useridDone && !closing)
            {
                closing = true;
                Properties.Settings.Default.Save();
                MessageBox.Show("You have logged in. Enjoy your sit count!");
                this.BeginInvoke((MethodInvoker)delegate () { this.Close(); });
            }



        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {

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
