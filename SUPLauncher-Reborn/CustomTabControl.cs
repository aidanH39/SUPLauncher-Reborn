﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUPLauncher_Reborn
{
    class CustomTabControl : TabControl
    {
        public CustomTabControl()
        {
            if (!this.DesignMode) this.Multiline = true;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x1328 && !this.DesignMode)
                m.Result = new IntPtr(1);
            else
                base.WndProc(ref m);
        }

    }
}