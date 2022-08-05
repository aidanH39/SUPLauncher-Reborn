﻿using System;
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
    public partial class inputbox : Form
    {

        public string text;

        public inputbox(string title, string message)
        {
            InitializeComponent();
            label1.Text = message;
            label2.Text = title;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text = textBox1.Text;
            this.Close();
        }
    }
}
