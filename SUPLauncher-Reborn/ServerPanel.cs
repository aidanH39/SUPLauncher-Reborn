using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUPLauncher_Reborn
{
    public partial class ServerPanel : UserControl
    {
        public ServerPanel()
        {
            InitializeComponent();
        }

        public void updateServer(SuperiorServers.Server server)
        {
            lbl_serverName.Text = server.Name;
            lbl_playerCount.Text = server.Players + "/" + server.MaxPlayers;
            frm_main.loadImage(img, "https://superiorservers.co/static/images/servers/" + server.Image);
            img.Click += delegate
            {
                frm_main.instance.connect(server);
            };
        }

    }
}
