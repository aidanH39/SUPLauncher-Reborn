using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace SUPLauncher
{
    /// <summary>
    /// Interaction logic for server.xaml
    /// </summary>
    public partial class ServerBox : UserControl
    {
        public ServerBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// fetches infomation from the api, and updates the content.
        /// </summary>
        /// <param name="server"></param>
        public void updateServer(SuperiorServers.Server server)
        {
            if (server.Online)
            {
                lbl_serverName.Content = server.Name;
                lbl_playerCount.Content = server.Players + "/" + server.MaxPlayers;
                img_bg.Source = new BitmapImage(new Uri("https://superiorservers.co/static/images/servers/" + server.Image));
            } else
            {
                lbl_serverName.Content = server.Name;
                lbl_playerCount.Content = server.Players + "/" + server.MaxPlayers;
                img_bg.Source = new BitmapImage(new Uri("https://superiorservers.co/static/images/servers/" + server.Image));
                border.Background = (Brush) new BrushConverter().ConvertFrom("#ff8282");
            }
            
        }

    }
}
