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
using Windows.Management.Deployment;
using System.IO.Packaging;
using Windows.Foundation;
using Windows.Networking.BackgroundTransfer;

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
            lbl_progress.Content = "0%";
            Task taskA = Task.Run(() =>
            {
                update(getLatestVersion().ToString());
            });
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

        

        PackageManager pgManager = new PackageManager();
        public void update(string version)
        {
            using (var client = new WebClient())
            {
                client.DownloadProgressChanged += (s, e) =>
                {
                    lbl_progress.Dispatcher.Invoke(() => lbl_progress.Content = "Downloading (" + e.ProgressPercentage + "%)");
                };

                client.DownloadFileCompleted += delegate
                {
                    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> deploymentOperation = pgManager.AddPackageAsync(new Uri(Directory.GetCurrentDirectory() + "\\update-v" + version + ".appxbundle"), null, DeploymentOptions.ForceTargetApplicationShutdown);
                    deploymentOperation.Progress = (op, progress) =>
                    {
                        lbl_progress.Dispatcher.Invoke(() => lbl_progress.Content = "Installing (" + progress.percentage + "%)");
                    };

                    deploymentOperation.Completed = (dep, status) =>
                    {
                        this.Dispatcher.Invoke(() => {
                            // Cleanup
                            File.Delete(Directory.GetCurrentDirectory() + "\\update-v" + version + ".appxbundle");

                            Process.Start("../SUPLauncher/SUPLauncher.exe");
                            Application.Current.Shutdown();
                        });
                    };

                    while (true) { }; // Dont stop this thread

                };
                try
                {
                    client.DownloadFileAsync(new Uri("http://35.224.124.248/api/launcher/" + version), "update-v" + version + ".appxbundle");
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

        }

    }
}
