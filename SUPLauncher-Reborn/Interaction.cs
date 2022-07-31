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
            
            inputbox form = new inputbox();
            form.Text = title;
            form.ShowDialog();
            return form.text;
        }
    }
}
