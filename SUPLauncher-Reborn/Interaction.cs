using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUPLauncher_Reborn
{
    class Interaction
    {
        public static string InputBox(string question, string title, bool topMost = false)
        {
            // Allows user to input text, and then return the string back in this method.
            inputbox form = new inputbox(title, question);
            form.Text = title;
            form.TopMost = topMost;
            form.ShowDialog();
            return form.text;
        }

        public static void MessageBox(string message, string title = null, bool topMost = false)
        {
            // Shows a message box that can be closed.
            msgBox form = new msgBox(message, title);
            form.TopMost = topMost;
            form.ShowDialog();
        }
    }
}
