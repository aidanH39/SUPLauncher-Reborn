using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUPLauncher_Reborn
{
    class Interaction
    {
        public static string InputBox(string question, string title)
        {
            
            inputbox form = new inputbox(title, question);
            form.Text = title;
            form.ShowDialog();
            return form.text;
        }

        public static void MessageBox(string message, string title = null)
        {
            msgBox form = new msgBox(message, title);
            form.ShowDialog();
        }
    }
}
