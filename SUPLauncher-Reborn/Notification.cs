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
    public partial class Notification : Form
    {
        private string head = "";
        private string info = "";
        /// <summary>
        /// Shows a notfication over GMOD, or any window open at the time.
        /// </summary>
        public Notification(string header, string info)
        {
            this.head = header;
            this.info = info;
            InitializeComponent();
        }

        private void Notification_Load(object sender, EventArgs e)
        {
            Form form = this;
            Rectangle bounds = Screen.FromHandle(Steam.getGMOD()).Bounds;
            this.Left = bounds.Width - this.Width;
            this.Top = bounds.Height;
            lbl_header.Text = this.head;
            lbl_info.Text = info;
            int startingTop = this.Top;
            Timer timer = new Timer();
            timer.Enabled = true;
            timer.Tick += delegate
            {
                form.Top -= 2;
                
                if (form.Top <= bounds.Height - form.Height - 50)
                {
                    
                    timer.Stop();
                    timer.Dispose();
                    Timer closeAfter = new Timer();
                    closeAfter.Enabled = true;
                    closeAfter.Tick += delegate
                    {
                        closeAfter.Stop();
                        form.Close();
                    };
                    closeAfter.Interval = 4000;
                    closeAfter.Start();
                }
            };
            timer.Interval = 1;
            timer.Start();
        }
    }
}

