using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.IO;
using System.Web;

namespace SUPLauncher
{
    /// <summary>
    /// Interaction logic for ShareDialog.xaml
    /// </summary>
    public partial class ShareDialog : Window
    {
        String path;

        /// <summary>
        /// Creates a quick link to a dupe file
        /// </summary>
        /// <param name="path">Path to dupe</param>
        public ShareDialog(string path)
        {
            this.path = path;
            InitializeComponent();
            txt_.Visibility = Visibility.Hidden;
            lbl_.Content = "Getting your share link...";
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                FileStream fileStream = File.OpenRead(path);
                HttpContent fileStreamContent = new StreamContent(fileStream);
                HttpContent bytesContent = new ByteArrayContent(File.ReadAllBytes(path));
                using (var client = new HttpClient())
                using (var formData = new MultipartFormDataContent())
                {
                    formData.Add(new StringContent(App.profile.Badmin.Name), "author");
                    formData.Add(new StringContent(App.profile.SteamID32), "steamid");
                    formData.Add(fileStreamContent, "file", Path.GetFileNameWithoutExtension(path));
                    var response = await client.PostAsync("http://35.224.124.248/api/ShareDupe.php", formData);
                    if (response.IsSuccessStatusCode)
                    {
                        lbl_.Content = "Share link for dupe '" + Path.GetFileNameWithoutExtension(path) + "'!";
                        txt_.Visibility = Visibility.Visible;
                        string result = await response.Content.ReadAsStringAsync();
                        txt_.Text = result;

                    }
                    else
                    {
                        Interaction.MsgBox("ERROR: " + response.StatusCode);
                    }
                }
            } catch (Exception ex)
            {
                Logger.Log(Logger.LogType.ERROR, "Error occured while creating a dupe share link: " + ex.Message + "\nStack trace: " + ex.StackTrace);
                lbl_.Content = "Failed to get share link! Try again.";
            }

        }
    }
}
