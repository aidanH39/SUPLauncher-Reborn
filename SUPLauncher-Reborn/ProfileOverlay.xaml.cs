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
using static SUPLauncher.SuperiorServers;

namespace SUPLauncher
{
    /// <summary>
    /// Interaction logic for ProfileOverlay.xaml
    /// </summary>
    public partial class ProfileOverlay : Window
    {
        public ProfileOverlay(string steamid)
        {
            InitializeComponent();
            this.Topmost = true;
            this.ShowInTaskbar = false;
            updateProfile(steamid);

        }

        Profile profile;

        /// <summary>
        /// Update the displaying profile.
        /// </summary>
        /// <param name="steamid">SteamID to display</param>
        public void updateProfile(string steamid)
        {
            Profile profile;
            try
            {
                profile = SuperiorServers.getProfile(steamid);
                img_profile.ImageSource = profile.getAvatar();
            }
            catch (Exception e)
            {
                Logger.Log(Logger.LogType.ERROR, "Error while trying to get profile of '" + steamid + "' while opening profile overlay. " + e.Message);
                return;
            }

            this.profile = profile;

            

            lbl_name.Content = profile.Badmin.Name;
            var timeSpent = TimeSpan.FromSeconds(Double.Parse(profile.Badmin.PlayTime));
            lbl_playtime.Content = "Playtime: " + Math.Floor(timeSpent.TotalHours) + ":" + timeSpent.Minutes + ":" + timeSpent.Seconds;

            if (profile.Badmin.Bans.Length > 0)
            {
                lbl_totalPo.Content = profile.Badmin.Bans.Length;
                Ban b = profile.Badmin.Bans.FirstOrDefault();
                if (b.BanID == null)
                {
                    lbl_lastPunishment.Content = "Jail - " + SuperiorServers.LengthFormat(b.Length);
                }
                else
                {
                    lbl_lastPunishment.Content = "Ban - " + SuperiorServers.LengthFormat(b.Length);
                }

            }
            else
            {
                lbl_totalPo.Content = "0";
                lbl_lastPunishment.Content = "NEVER";
            }
            punishments.Children.Clear();

            Brush brush = (Brush)new BrushConverter().ConvertFrom("#0f0f0f");

            Label label = new Label();
            label.Content = "Date";
            label.Background = brush;

            Label label2 = new Label();
            label2.Content = "Server";
            label2.Background = brush;

            Label label3 = new Label();
            label3.Content = "Type";
            label3.Background = brush;

            Label label4 = new Label();
            label4.Content = "Admin";
            label4.Background = brush;

            Label label5 = new Label();
            label5.Content = "Length";
            label5.Background = brush;

            Label label6 = new Label();
            label6.Content = "Reason";
            label6.Background = brush;

            punishments.Children.Add(label);
            punishments.Children.Add(label2);
            punishments.Children.Add(label3);
            punishments.Children.Add(label4);
            punishments.Children.Add(label5);
            punishments.Children.Add(label6);

            Grid.SetColumn(label, 0);
            Grid.SetColumn(label2, 1);
            Grid.SetColumn(label3, 2);
            Grid.SetColumn(label4, 3);
            Grid.SetColumn(label5, 4);
            Grid.SetColumn(label6, 5);

            int i = 1;
            foreach (Ban ban in profile.Badmin.Bans)
            {

                RowDefinition r = new RowDefinition();
                r.Height = (GridLength)new GridLengthConverter().ConvertFrom(30);
                punishments.RowDefinitions.Add(r);

                Label date = new Label();

                date.Content = "Date";

                Label server = new Label();
                server.Content = ban.Server;

                Label type = new Label();


                Label admin = new Label();
                Profile staffProfile = SuperiorServers.getProfile(ban.AdminSteamID64);
                admin.Content = staffProfile.Badmin.Name;

                Label length = new Label();
                length.Content = SuperiorServers.LengthFormat(ban.Length);

                Label reason = new Label();
                reason.Content = ban.Reason;


                if (ban.BanID == null)
                {
                    type.Content = "Jail";
                    date.Background = (Brush)new BrushConverter().ConvertFrom("#ff960d");
                    date.Opacity = 0.5;

                    server.Background = (Brush)new BrushConverter().ConvertFrom("#ff960d");
                    server.Opacity = 0.5;

                    type.Background = (Brush)new BrushConverter().ConvertFrom("#ff960d");
                    type.Opacity = 0.5;

                    admin.Background = (Brush)new BrushConverter().ConvertFrom("#ff960d");
                    admin.Opacity = 0.5;

                    length.Background = (Brush)new BrushConverter().ConvertFrom("#ff960d");
                    length.Opacity = 0.5;

                    reason.Background = (Brush)new BrushConverter().ConvertFrom("#ff960d");
                    reason.Opacity = 0.5;

                }
                else
                {
                    type.Content = "Ban";

                    if (ban.IsActive)
                    {
                        date.Background = (Brush)new BrushConverter().ConvertFrom("#3d2827");
                        date.Opacity = 0.5;

                        server.Background = (Brush)new BrushConverter().ConvertFrom("#3d2827");
                        server.Opacity = 0.5;

                        type.Background = (Brush)new BrushConverter().ConvertFrom("#3d2827");
                        type.Opacity = 0.5;

                        admin.Background = (Brush)new BrushConverter().ConvertFrom("#3d2827");
                        admin.Opacity = 0.5;

                        length.Background = (Brush)new BrushConverter().ConvertFrom("#3d2827");
                        length.Opacity = 0.5;

                        reason.Background = (Brush)new BrushConverter().ConvertFrom("#3d2827");
                        reason.Opacity = 0.5;
                    }

                }


                punishments.Children.Add(date);
                Grid.SetColumn(date, 0);
                Grid.SetRow(date, i);

                punishments.Children.Add(server);
                Grid.SetColumn(server, 1);
                Grid.SetRow(server, i);

                punishments.Children.Add(type);
                Grid.SetColumn(type, 2);
                Grid.SetRow(type, i);

                punishments.Children.Add(admin);
                Grid.SetColumn(admin, 3);
                Grid.SetRow(admin, i);

                punishments.Children.Add(length);
                Grid.SetColumn(length, 4);
                Grid.SetRow(length, i);

                punishments.Children.Add(reason);
                Grid.SetColumn(reason, 5);
                Grid.SetRow(reason, i);


                i++;
            }
        }

        private void onCopySteamID(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(this.profile.SteamID32);
        }
        public void onViewPunishments(object sender, RoutedEventArgs e)
        {
            if (grid_.Width == 800)
            {
                grid_.Width = 0;
            } else
            {
                grid_. Width = 800;
            }
        }

    }
}
