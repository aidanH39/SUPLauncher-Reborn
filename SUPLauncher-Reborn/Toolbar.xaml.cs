using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static SUPLauncher.Logger;

namespace SUPLauncher
{
    /// <summary>
    /// Interaction logic for Toolbar.xaml
    /// </summary>
    public partial class Toolbar : UserControl
    {

        // Vars
        Window parentWindow;
        bool isFullScreen = false;

        public Toolbar()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(Toolbar_Loaded);
        }

        void Toolbar_Loaded(object sender, RoutedEventArgs e)
        {
            // Disable code when in visual studio designer mode.
            if (!DesignerProperties.GetIsInDesignMode(this))
            {
                parentWindow = Window.GetWindow(this);
                main_grid.MouseDown += new MouseButtonEventHandler(draggable);
                _appName.Header = parentWindow.Title;
                if (parentWindow.Owner is Overlay)
                {
                    btn_overlayPin.Visibility = Visibility.Visible;
                }
            }
        }

        #region Click events

        private void settings_Click(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        private void issues_Click(object sender, RoutedEventArgs e)
        {
            Process myProcess = new Process();
            myProcess.StartInfo.UseShellExecute = true; // Won't run urls without this flag
            myProcess.StartInfo.FileName = "https://github.com/aidanH39/SUPLauncher-Reborn/issues";
            myProcess.Start();
        }

        private void forum_Click(object sender, RoutedEventArgs e)
        {
            Process myProcess = new Process();
            myProcess.StartInfo.UseShellExecute = true; // Won't run urls without this flag
            myProcess.StartInfo.FileName = "https://github.com/aidanH39/SUPLauncher-Reborn/issues";
            myProcess.Start();
        }

        private void credits_click(object sender, RoutedEventArgs e)
        {
            InputBox box = new InputBox("Created by: Best of all\nSteamBridge.cs: Nick\nTHIRD PARTY SOFTWARE! This is not a official launcher.", BoxType.MESSAGE_BOX, "Credits");
            box.Show();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            parentWindow.Close();
        }

        private void showLogs_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("explorer.exe", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SUPLauncher\\logs");
        }

        private void draggable(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (e.ChangedButton == MouseButton.Left)
                {
                    parentWindow.DragMove();
                }
            }
            catch (Exception)
            {
                Logger.Log(LogType.WARN, "Drag event error, keeping silent.");
            }
        }

        private void github_Click(object sender, RoutedEventArgs e)
        {
            Process myProcess = new Process();
            myProcess.StartInfo.UseShellExecute = true; // Won't run urls without this flag
            myProcess.StartInfo.FileName = "https://github.com/aidanH39/SUPLauncher-Reborn/";
            myProcess.Start();
        }

        private void btn_min_Click(object sender, RoutedEventArgs e)
        {
            parentWindow.WindowState = WindowState.Minimized;
        }

        private void btn_pin_Click(object sender, RoutedEventArgs e)
        {
            if (parentWindow.Owner is Overlay && parentWindow.Tag == "pinned")
            {
                btn_overlayPin.Content = "";
                parentWindow.Tag = null;
                if (parentWindow.Owner.Visibility == Visibility.Hidden)
                {
                    parentWindow.Visibility = Visibility.Hidden;
                }
            }
            else if (parentWindow.Owner is Overlay)
            {
                btn_overlayPin.Content = "";
                parentWindow.Tag = "pinned";
            }
        }

        private void fullscreen(object sender, RoutedEventArgs e)
        {
            if (isFullScreen)
            {
                menu_fullscreen.IsChecked = false;
                parentWindow.WindowState = WindowState.Normal;
            }
            else
            {
                menu_fullscreen.IsChecked = true;
                parentWindow.WindowState = WindowState.Maximized;
            }
            isFullScreen = !isFullScreen;
        }

        #endregion



    }
}
