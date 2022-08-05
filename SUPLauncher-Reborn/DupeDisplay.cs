using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SUPLauncher_Reborn.DupeMarket;

namespace SUPLauncher_Reborn
{
    public partial class DupeDisplay : UserControl
    {
        Dupe dupe;
        public DupeDisplay(Dupe dupe)
        {
            this.dupe = dupe;
            InitializeComponent();
            label1.Text = dupe.creator_name;
            label2.Text = dupe.title;
            if (dupe.img_url != null) pictureBox1.LoadAsync(dupe.img_url);
            frm_main.loadImage(ovalPictureBox1, "https://superiorservers.co/api/avatar/" + dupe.creator);
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            pnl_left.BackColor = Color.FromArgb(47, 129, 255);
        }

        private void pnl_left_MouseLeave(object sender, EventArgs e)
        {
            pnl_left.BackColor = Color.FromArgb(85, 85, 85);
            
        }

        private void DupeDisplay_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DupeDetails form = new DupeDetails(this.dupe);
                form.TopMost = this.FindForm().TopMost;
                form.Show();
            }
        }
    }
}
