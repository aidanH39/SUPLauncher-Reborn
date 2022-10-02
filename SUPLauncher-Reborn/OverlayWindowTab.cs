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
    public partial class OverlayWindowTab : UserControl
    {

        public Form form;

        public OverlayWindowTab()
        {
            this.form = form;
            InitializeComponent();

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            form.Close();
            Program.overlay.Controls.Remove(this);
            this.Dispose();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            this.form.Visible = true;
            this.form.WindowState = FormWindowState.Normal;
            this.Visible = false;
        }

        private void OverlayWindowTab_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void OverlayWindowTab_Load(object sender, EventArgs e)
        {
            label1.Text = form.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = form.Text;
        }
    }
}
