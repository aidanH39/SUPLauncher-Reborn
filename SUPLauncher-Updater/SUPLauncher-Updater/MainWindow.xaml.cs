using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Ionic.Zip;
using System.Threading.Tasks;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Diagnostics;

namespace SUPLauncher_Updater
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Gets the latest release on github, and returns the version.
        public static Version getLatestVersion()
        {
            try
            {
                string[] webData;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; // Secure security protocol for querying the github API
                HttpWebRequest request = WebRequest.CreateHttp("http://api.github.com/repos/BestOfAllCoding/SUPLauncher-Reborn/releases/latest");
                request.UserAgent = "SUPLauncher";
                WebResponse response = null;
                response = request.GetResponse();
                StreamReader sr = new StreamReader(response.GetResponseStream());
                dynamic json = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(sr.ReadToEnd());
                return new Version(json.tag_name.ToString());
            }
            catch (Exception e)
            {
                return new Version("0.0.0");
            }
        }

        public void update(string version)
        {
            using (var client = new WebClient())
            {
                client.DownloadProgressChanged += (s, e) =>
                {
                    lbl_progress.Content = "Downloading update...";
                };

                client.DownloadFileCompleted += delegate
                {
                    using (ZipFile zip = ZipFile.Read("update-v" + version + ".zip"))
                    {
                        zip.ExtractProgress +=
                           new EventHandler<ExtractProgressEventArgs>(zip_ExtractProgress);

                        zip.ExtractAll(".", ExtractExistingFileAction.OverwriteSilently);
                    }
                    File.Delete("update-v" + version + ".zip");

                    this.Close();
                };
                try
                {
                    client.DownloadFileAsync(new Uri("http://35.224.124.248/api/launcher/" + version), "update-v" + version + ".zip");
                }catch(Exception e)
                {
                    MessageBox.Show("Failed to download update! Visit https://github.com/aidanH39/SUPLauncher-Reborn/ to update instead.");
                }



            }
        }




        private void zip_ExtractProgress(object sender, ExtractProgressEventArgs e)
        {
            if (e.TotalBytesToTransfer > 0)
            {
                lbl_progress.Content = "Installing update...";
                if (e.BytesTransferred >= e.TotalBytesToTransfer)
                {
                    Process.Start("SUPLauncher.exe");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Task taskA = Task.Run(() =>
            {
                update(getLatestVersion().ToString());
            });
        }

    }
}
