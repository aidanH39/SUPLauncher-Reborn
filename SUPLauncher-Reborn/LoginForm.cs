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
            //var cookieManager = Cef.GetGlobalCookieManager();
            //Cookie cookie = new Cookie();
            //cookie.
            //cookieManager.SetCookie("https://superiorservers.co", cookie);
            //


            browser.Dock = DockStyle.Fill;

            browser.LoadingStateChanged += chromiumWebBrowser1_LoadingStateChanged;
            this.pnl_browser.Controls.Add(browser);
            browser.Load("https://superiorservers.co");




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
    }
}
