

using Ionic.Zip;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUPLauncher_Updater
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
            
        }

        public void update(string version)
        {
            using (var client = new WebClient())
            {
                client.DownloadProgressChanged += (s, e) =>
                {
                    lbl_updating.Text = "Downloading update...";
                    cProgressBar1.Value = e.ProgressPercentage;
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
                    Process.Start("SUPLauncher-Reborn.exe");
                    this.Close();
                };
                client.DownloadFileAsync(new Uri("http://bestofall.ml:2095/api/launcher/" + version), "update-v" + version + ".zip");



            }
        }

        private void zip_done(object sender)
        {

        }

        private void zip_ExtractProgress(object sender, ExtractProgressEventArgs e)
        {
            if (e.TotalBytesToTransfer > 0)
            {
                cProgressBar1.Value = Convert.ToInt32(100 * e.BytesTransferred / e.TotalBytesToTransfer);
                lbl_updating.Text = "Installing update...";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Task taskA = Task.Run(() =>
            {

               update("2.5.1");
                    
                    

            });
            
        }
    }
}
