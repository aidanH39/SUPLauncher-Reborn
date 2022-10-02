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
    public partial class NoteFile : UserControl
    {
        public string file;
        public NoteFile(string name)
        {
            InitializeComponent();
            this.file = name;
            lbl_eval.Text = name;
        }

        private void EvalFile_MouseEnter(object sender, EventArgs e)
        {
            pnl_left.BackColor = Color.FromArgb(47, 129, 255);
            panel8.BackColor = Color.FromArgb(45, 45, 45);
        }

        private void EvalFile_MouseLeave(object sender, EventArgs e)
        {
            pnl_left.BackColor = Color.FromArgb(55, 55, 55);
            panel8.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void lbl_eval_MouseClick(object sender, MouseEventArgs e)
        {
            this.OnMouseClick(e);
        }

        private void lbl_eval_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void lbl_eval_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }
    }
}
