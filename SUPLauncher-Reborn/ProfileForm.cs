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
            new FormResize(this, pnl_topBar);
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
    }
}
