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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SUPLauncher
{
    /// <summary>
    /// Interaction logic for OverlayPicker.xaml
    /// </summary>
    public partial class OverlayPicker : UserControl
    {
        Window parentWindow;
        /// <summary>
        /// Used to pick between options when in the overlay. Should only be used in Overlay.cs
        /// </summary>
        /// <param name="values"></param>
        public OverlayPicker(params MenuOption[] values)
        {
            this.Loaded += onLoad;
            InitializeComponent();
            bool i = false; // Turns true after first option
            foreach (MenuOption option in values)
            {

                // Image
                Image image = new Image();
                image.Source = option.image;

                // Button
                Button button = new Button();
                button.Content = image;
                button.SetResourceReference(Control.StyleProperty, "OverlaymenuButtons");
                button.MouseEnter += mouseOver;
                button.Click += option.callback;
                button.Tag = option.title;

                // Rectangle
                Rectangle rect = new Rectangle();
                rect.Width = 2;
                rect.Fill = (Brush)new BrushConverter().ConvertFrom("#2d2d2d");
                rect.Margin = new Thickness(50, 0, 50, 0);

                // Add content to parents
                if (i)
                {
                    pnl_options.Children.Add(rect);
                }
                i = true;
                pnl_options.Children.Add(button);
            }
        } 


        void onLoad(object sender, RoutedEventArgs e)
        {
            // Close any other OverlayPicker instances
            parentWindow = Window.GetWindow(this);
            Overlay overlay = ((Overlay)parentWindow);
            if (overlay.picker != null)
            {
                overlay.mainGrid.Children.Remove(overlay.picker);
            }
            overlay.picker = this;
        }

        private void mouseOver(object sender, MouseEventArgs e)
        {
            // Change text to buttons tag
            Button but = (Button)sender;
            lbl_optionName.Content = but.Tag;
        }
    }

    public class MenuOption
    {
        public String? title;
        public  BitmapImage? image;
        public RoutedEventHandler? callback;
    }

}
