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
    public partial class SitCount : UserControl
    {
        public SitCount(string label, string count)
        {
            InitializeComponent();
            lbl_sits_head.Text = label;
            lbl_sits.Text = count;
        }


        private void SitCount_Load(object sender, EventArgs e)
        {

        }
    }
}
