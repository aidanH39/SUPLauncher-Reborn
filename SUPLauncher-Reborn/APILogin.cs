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
    public partial class APILogin : Form
    {

        /// <summary>
        /// Takes you to the steam login page, that then logins you into MY API. For some details on what is stored about you look on the github page.
        /// Its only really the steamid, and the login is used to verify you.
        /// </summary>
        public APILogin()
        {
            InitializeComponent();
            chromiumWebBrowser1.Load("http://bestofall.ml:2095/api/getProfileKey.php"); // Load API login page. (Gets redirected to steam)
        }

        #region Window Drag

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
        #endregion
        // Close button
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Verify person is not logged in when the loading state changes.
        private async void chromiumWebBrowser1_LoadingStateChanged(object sender, CefSharp.LoadingStateChangedEventArgs e)
        {
            if (e.Browser.MainFrame.IsMain)
            {
                var result = await e.Browser.MainFrame.EvaluateScriptAsync("document.getElementsByTagName('body')[0].innerHTML");
                string body = ((dynamic)result.Result);
                
                if (body.StartsWith("{")) {
                    var json = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(body);
                    if (Program.steamid.ToString() == json.id.ToString())
                    {
                        // User has logged in. And steamid is valid. Now save the API secret to application settings.
                        Properties.Settings.Default.apiSecret = json.key;
                        Properties.Settings.Default.Save();
                        this.BeginInvoke((MethodInvoker)delegate () { this.Close(); });
                    } else
                    {
                        MessageBox.Show("Login to steam with your current steam account you are on. This is to verify your steamid while on the dupe market");
                        chromiumWebBrowser1.Load("http://bestofall.ml:2095/api/getProfileKey.php");
                    }
                    
                }
            }
        }
    }
}
