using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SUPLauncher
{
    /// <summary>
    /// Interaction logic for InputBox.xaml
    /// </summary>
    public partial class InputBox : Window
    {

        private bool okay = false;
        /// <summary>
        /// Used to display messages, or receive input from the user.
        /// </summary>
        /// <param name="message">Message to display</param>
        /// <param name="type">The type of message/input</param>
        /// <param name="title">Title of the window</param>
        public InputBox(string message, BoxType type = BoxType.INPUT_BOX, string title = "Message")
        {
            InitializeComponent();
            this.Title = title;


            if (type == BoxType.INPUT_BOX)
            {
                box_input.Visibility = Visibility.Visible;
                this._lbl.Content = message;
            }
            else if (type == BoxType.MESSAGE_BOX)
            {
                box_message.Visibility = Visibility.Visible;
                _message.Text = message;
            }
            else if (type == BoxType.ACCEPT_CANCEL)
            {
                box_accept.Visibility = Visibility.Visible;
                _message2.Text = message;
            }

        }

        public string getText()
        {
            if (!okay) { return ""; }
            return txt_text.Text;
        }

        public bool getConfirm()
        {
            return this.okay;
        }

        public void btn_confirm_Click(object sender, RoutedEventArgs e)
        {
            this.okay = true;
            this.Close();
        }

        public void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

    public enum BoxType
    {
        INPUT_BOX,
        MESSAGE_BOX,
        ACCEPT_CANCEL
    }

}
