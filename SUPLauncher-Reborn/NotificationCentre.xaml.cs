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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace SUPLauncher
{
    /// <summary>
    /// Interaction logic for NotificationCentre.xaml
    /// </summary>
    public partial class NotificationCentre : Window
    {
        public NotificationCentre()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var desktopWorkingArea = System.Windows.SystemParameters.WorkArea;
            this.Left = desktopWorkingArea.Right - this.Width;
            this.Top = desktopWorkingArea.Bottom - this.Height;
            NotificationCentre.instance = this;
        }

        private static NotificationCentre instance;
        Duration animationDuration = new Duration(new TimeSpan(0, 0, 0, 0, 450));
        
        public static void notify(string title, string message, Action clickCallback=null)
        {
            NotificationCentre.instance.Dispatcher.Invoke(() =>
            {
                Notification n = new Notification();
                n.lbl_message.Text = message;
                n.lbl_title.Content = title;

                TranslateTransform t = new TranslateTransform();
                DoubleAnimation anim = new DoubleAnimation(0, NotificationCentre.instance.animationDuration);
                t.X = 360;
                n.RenderTransform = t;
                NotificationCentre.instance.pnl_wrap.Children.Add(n);
                n.RenderTransform.BeginAnimation(TranslateTransform.XProperty, anim);

                n.MouseDoubleClick += delegate
                {
                    new Task(clickCallback).RunSynchronously();
                };

                Task.Delay(8000).ContinueWith(delegate
                {
                    NotificationCentre.instance.Dispatcher.Invoke(() =>
                    {
                        NotificationCentre.instance.afterNotify(n);
                    });
                });
            });
        }

        private void afterNotify(Notification not)
        {
            DoubleAnimation anim = new DoubleAnimation(360, NotificationCentre.instance.animationDuration);
            not.RenderTransform.BeginAnimation(TranslateTransform.XProperty, anim);
        }


    }
}
