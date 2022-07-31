using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


    class WindowHelper
    {
        [DllImport("user32.dll")]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uflags);

        const UInt32 SWP_NOSIZE = 0x0001;
        const UInt32 SWP_NOMOVE = 0x0002;
        const UInt32 SWP_SHOWWINDOW = 0x0040;
        /// <summary>
        /// Gives focus to a window. By PID.
        /// </summary>
        /// <param name="PID"></param>
        public static void focus(int PID)
        {
            Process proc = Process.GetProcessById(PID);
            IntPtr mainWindow = proc.MainWindowHandle;
            IntPtr newPos = new IntPtr(0); 
            SetWindowPos(mainWindow, newPos, 0, 0, 0, 0, SWP_NOSIZE | SWP_NOMOVE | SWP_SHOWWINDOW);
        }

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string ipClassName, string ipWindowName);

        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
}
