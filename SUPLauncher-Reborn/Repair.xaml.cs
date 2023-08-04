using Microsoft.Win32;
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
    /// Interaction logic for Repair.xaml
    /// </summary>
    public partial class Repair : Window
    {
        public Repair()
        {
            InitializeComponent();
            this.Loaded += delegate
            {
                try
                {
                    // Register custom protocol (sup://)
                    RegisterMyProtocol(System.Reflection.Assembly.GetExecutingAssembly().Location);
                }
                catch (Exception e)
                {
                    Logger.Log(Logger.LogType.ERROR, "Could not register protocol, sup:// will not work!");
                    Logger.Log(Logger.LogType.ERROR, "Could not register protocol. " + e.Message + "\nStack trace: \n" + e.StackTrace);
                }
            };
            Task.Delay(8000).ContinueWith((e) =>
            {
                this.Dispatcher.Invoke(() =>
                {
                    AppSettings.Default.firstTimeStartup = false;
                    AppSettings.Default.Save();
                    this.Close();
                });
            });
        }

        /// <summary>
        /// Registers the custom protocol
        /// </summary>
        /// <param name="myAppPath">Full path to program exe</param>
        public void RegisterMyProtocol(string myAppPath)
        {
            RegistryKey key = Registry.ClassesRoot.OpenSubKey("sup");
            if (key == null)  //if the protocol is not registered yet...we register it
            {
                key = Registry.ClassesRoot.CreateSubKey("sup");
                key.SetValue("", "URL: SUPLauncher");
                key.SetValue("URL Protocol", "");

                key = key.CreateSubKey(@"shell\open\command");
                key.SetValue("", myAppPath + " " + "%1"); // Set value to path + any arguments supplied via the protocol

            } else
            {
                key.SetValue("", "URL: SUPLauncher");
                key.SetValue("URL Protocol", "");

                key = key.OpenSubKey(@"shell\open\command");
                key.SetValue("", myAppPath + " " + "%1"); // Set value to path + any arguments supplied via the protocol
            }
            key.Close();
        }
    }
}
