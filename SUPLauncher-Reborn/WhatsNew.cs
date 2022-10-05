using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SUPLauncher_Reborn.SuperiorServers;
using HeyRed.MarkdownSharp;
using CefSharp;

namespace SUPLauncher_Reborn
{
    public partial class WhatsNew : Form
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

        public WhatsNew()
        {
            InitializeComponent();
            new FormResize(this, pnl_topBar);
        }

        private void WhatsNew_Load(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.github.com/repos/BestOfAllCoding/SUPLauncher-Reborn/releases");
            request.UserAgent = "SUPLauncher";
            request.AutomaticDecompression = DecompressionMethods.GZip;
            string json;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                json = reader.ReadToEnd();
            }
            JArray jsonP = JsonConvert.DeserializeObject<JArray>(json);
            Markdown md = new Markdown();



            string str = "";

            foreach (JObject obj in jsonP)
            {
                str += "<br><h1>V" + obj.GetValue("tag_name").ToString() + "</h1><br>";
                str += md.Transform(obj.GetValue("body").ToString());
            }

            webBrowser1.DocumentText = @"
            <link href='https://fonts.googleapis.com/css2?family=Mulish:wght@700&family=Roboto&display=swap' rel='stylesheet'>
            <style>
                body {
                    color: white;
                    background: rgb(25, 25, 25);
                    font-family: 'Roboto';
                    font-size: 14px
                    -webkit-highlight: none;
                    user-select: none;
                    -webkit-touch-callout: none;
                }
                .launcher {
                    font-family: 'Mulish';
                    font-size: 28px;
                    margin-top: -10px;
                }

                h1 {
                    font-style: underline;
                }
            </style>
            
            <img src='https://i.imgur.com/doWamuT.png'></img><br>
            <h4><b>Current Version:</b> V" + Application.ProductVersion + @"</h4>
            <br>
            " + str;
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
