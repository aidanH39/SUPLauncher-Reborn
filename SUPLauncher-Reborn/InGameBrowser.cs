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
    public partial class InGameBrowser : Form
    {
        string steamid;
        public InGameBrowser(bool topMost=true)
        {
            InitializeComponent();
            new FormResize(this, pnl_topBar);
            this.cProgressBar1.Value = 25;
            chromiumWebBrowser1.Load("https://superiorservers.co/");
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
            if (chromiumWebBrowser1.CanGoBack)
            {
                this.btn_back.BeginInvoke((MethodInvoker)delegate () { this.btn_back.Enabled = true; });
            }
            else
            {
                this.btn_back.BeginInvoke((MethodInvoker)delegate () { this.btn_back.Enabled = false; });
            }
            if (chromiumWebBrowser1.CanGoForward)
            {
                this.btn_forward.BeginInvoke((MethodInvoker)delegate () { this.btn_forward.Enabled = true; });
            }
            else
            {
                this.btn_forward.BeginInvoke((MethodInvoker)delegate () { this.btn_forward.Enabled = false; });
            }
            if (args.IsLoading)
            {
                this.lbl_loading.BeginInvoke((MethodInvoker)delegate () { this.lbl_loading.Text = "Loading..."; });
                this.pnl_loading.BeginInvoke((MethodInvoker)delegate () { this.pnl_loading.Visible = true; });
                this.cProgressBar1.Value = 50;
            } else if (!args.IsLoading)
            {
                this.textBox1.BeginInvoke((MethodInvoker)delegate () { this.textBox1.Text = args.Browser.MainFrame.Url; });
                //args.Browser.ExecuteScriptAsync("document.querySelector('nav').remove();");
                this.cProgressBar1.BeginInvoke((MethodInvoker)delegate () { this.cProgressBar1.Value = 100; });
                Timer t = new Timer();
                t.Enabled = true;
                t.Interval = 1000;
                t.Tick += delegate
                {
                    
                    try // Incase form is closed
                    {
                        
                        this.pnl_loading.BeginInvoke((MethodInvoker)delegate () { this.pnl_loading.Visible = false; });
                        t.Enabled = false;
                        t.Stop();
                        t.Dispose();

                    } catch (Exception)
                    {
                        return; 
                    }
                };
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

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.cProgressBar1.Value = 25;
                chromiumWebBrowser1.Load(textBox1.Text);
            }
        }

        private void chromiumWebBrowser1_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {

        }

        private void chromiumWebBrowser1_LoadError(object sender, LoadErrorEventArgs e)
        {
            string errorText = "Failed to load website.<br><p style='color: rgb(100,100,100); font-size: 10px;'>" + e.ErrorText + "</p>";
            if (e.ErrorCode == CefErrorCode.NameNotResolved)
            {
                errorText = "<b>Can't reach this page.</b> " + e.FailedUrl + "'s server IP address could not be found.<br><a href='" + e.FailedUrl + "'><button>Refresh</button>";
            } else if (e.ErrorCode == CefErrorCode.SslProtocolError)
            {
                errorText = "<b>Can't reach this page.</b> Connection to " + e.FailedUrl + " is not secure!<br><a href='" + e.FailedUrl + "'><button>Refresh</button>";
            }

                e.Browser.MainFrame.LoadHtml(@"
            <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
            <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
            <link href=""https://fonts.googleapis.com/css2?family=Roboto&display=swap"" rel=""stylesheet"">
            <style>body {background: rgb(35,35,35); color: rgb(200,200,200); font-family: Roboto;} button { background: rgb(45,45,45); border: none; color: white; padding: 15px; margin: 7px; border-left: 2px solid rgb(47, 129, 255);}</style>
            <img src='https://forum.superiorservers.co/uploads/monthly_2021_07/header_logo.png.ae44b9c99471cf28b9cd36ac3d954966.png'> 
            <h1>Failed to load " + e.FailedUrl + @"</h1>
            
            <p>" + errorText + @"</p>
            "); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Reload();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Forward();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Back();
        }
    }
}
