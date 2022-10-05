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
    public partial class SplashScreen : Form
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

        public SplashScreen()
        {
            InitializeComponent();
            Timer t = new Timer();
            t.Tick += delegate
            {
                this.Close();
            };
            t.Interval = 3000;
            t.Enabled = true;
            t.Start();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            lbl_version.Text = "V" + Application.ProductVersion;
        }
    }
}
