using CefSharp;
using CefSharp.DevTools.Network;
using CefSharp.DevTools.Page;
using CefSharp.Wpf;
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
    /// Interaction logic for Browser.xaml
    /// </summary>
    public partial class Browser : Window
    {

        ChromeLifeSpanHandler LifeSpanHandler = new ChromeLifeSpanHandler();
        CustomRequestHandler requestHandler = new CustomRequestHandler();

        public Browser()
        {
            InitializeComponent();
            LifeSpanHandler.windowInstance = this;
            requestHandler.windowInstance = this;
            grid_loading.Visibility = Visibility.Visible;
            newTab(null, null);
        }

        private void chrome_browser_AddressChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (!e.NewValue.ToString().StartsWith("data:text/"))
            {
                currentTabLabel.Content = currentBrowser.Title;
            }
        }

        private async void txt_address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) 
            {
                // Load url from textbox
                grid_loading.Dispatcher.Invoke(() => { grid_loading.Visibility = Visibility.Visible; });
                currentBrowser.Load(txt_address.Text);
            }
        }

        private void but_back_Click(object sender, RoutedEventArgs e)
        {

        }

        private void but_refresh_Click(object sender, RoutedEventArgs e)
        {
            currentBrowser.GetBrowser().Reload();
        }

        private void chrome_browser_FrameLoadStart(object sender, CefSharp.FrameLoadStartEventArgs e)
        {
            grid_loading.Dispatcher.Invoke(() => { grid_loading.Visibility = Visibility.Visible; });
        }

        private void chrome_browser_FrameLoadEnd(object sender, CefSharp.FrameLoadEndEventArgs e)
        {

            this.Dispatcher.Invoke(() =>
            {
                try
                {
                    ChromiumWebBrowser browser = (ChromiumWebBrowser)sender;
                    if (!browser.Address.StartsWith("data:text/"))
                    {
                        if (browser == currentBrowser)
                        {
                            txt_address.Text = currentBrowser.Address.ToString();
                        }
                        currentTabLabel.Content = currentBrowser.Title;
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log(Logger.LogType.ERROR, "[SUPBrowser] " + ex.Message + ".\nStack trace: " + ex.StackTrace);
                }
            });

            grid_loading.Dispatcher.Invoke(() => { grid_loading.Visibility = Visibility.Hidden; });

        }

        public Button currentTab;
        Label currentTabLabel;
        public ChromiumWebBrowser currentBrowser;

        // Click event
        public void newTab(object sender, RoutedEventArgs e)
        {
            newTab();
        }

        /// <summary>
        /// Creates a new tab in the window.
        /// </summary>
        /// <returns>The created browser in the new tab</returns>
        public ChromiumWebBrowser newTab()
        {
            foreach (ChromiumWebBrowser b in browsers.Children)
            {
                b.Visibility = Visibility.Hidden;
            }
            foreach (Button button in tabs_content.Children)
            {
                button.Background = (Brush)new BrushConverter().ConvertFrom("#2f2f2f");
            }

            ChromiumWebBrowser browser = new ChromiumWebBrowser();
            browser.HorizontalAlignment = HorizontalAlignment.Stretch;
            browser.VerticalAlignment = VerticalAlignment.Stretch;
            browser.AddressChanged += chrome_browser_AddressChanged;
            browser.FrameLoadStart += chrome_browser_FrameLoadStart;
            browser.FrameLoadEnd += chrome_browser_FrameLoadEnd;
            browser.LifeSpanHandler = LifeSpanHandler;
            browser.RequestHandler = requestHandler;
            browser.LoadError += onLoadError;
            browsers.Children.Add(browser);
            currentBrowser = browser;

            Button tabButton = new Button();
            tabButton.Background = (Brush)new BrushConverter().ConvertFrom("#1f1f1f");
            tabButton.Tag = browser;
            tabButton.Click += delegate
            {
                changeTab(tabButton);
            };
            Label label = new Label();

            currentTab = tabButton;
            currentTabLabel = label;

            Button closeButton = new Button();
            closeButton.Tag = browser;
            closeButton.Click += closeTab;
            closeButton.SetResourceReference(Control.StyleProperty, "redButton");
            closeButton.Height = 15;
            closeButton.Width = 15;
            closeButton.Content = "";
            closeButton.FontFamily = (FontFamily)new FontFamilyConverter().ConvertFrom("Segoe MDL2 Assets");

            WrapPanel panel = new WrapPanel();
            panel.Margin = new Thickness(5, 0, 5, 0);

            tabButton.Content = panel;
            panel.Children.Add(label);
            panel.Children.Add(closeButton);

            tabs_content.Children.Add(tabButton);

            browser.Load("superiorservers.co");
            return browser;
        }

        private void onLoadError(object sender, LoadErrorEventArgs e)
        {
            // Catch errors and display a page
            if (!e.FailedUrl.Contains("sup://")) ((ChromiumWebBrowser)sender).GetMainFrame().LoadHtml("\r\n\r\n<head>\r\n    <link rel=\"preconnect\" href=\"https://fonts.googleapis.com\">\r\n    <link rel=\"preconnect\" href=\"https://fonts.gstatic.com\" crossorigin>\r\n    <link href=\"https://fonts.googleapis.com/css2?family=Roboto&display=swap\" rel=\"stylesheet\">\r\n    <style>\r\n        body {\r\n            background: #1f1f1f;\r\n            color: white;\r\n            font-family: Roboto;\r\n            padding: 50px;\r\n        }\r\n\r\n        a {\r\n            text-decoration: none;\r\n            color: #1A9CFA;\r\n        }\r\n\r\n        img {\r\n            height: 180px;\r\n        }\r\n\r\n    </style>\r\n</head>\r\n\r\n<body>\r\n<div style=\"text-align: center;\">\r\n    <img src=\"https://superiorservers.co/static/images/textless_logo.png\" alt=\"SuperiorServers UnOfficial Launcher\">\r\n    <h1>Could not load this site!</h1>\r\n    <h3 style=\"color: #7f7f7f;\">" + e.ErrorText + "</h3>\r\n</div>\r\n</body>");
        }
        public void closeTab(object sender, RoutedEventArgs e)
        {
            Button tabButton = (Button)((WrapPanel)((Button)sender).Parent).Parent;
            bool isSameTab = currentTab == tabButton;

            ChromiumWebBrowser browser = (ChromiumWebBrowser)tabButton.Tag;
            browsers.Children.Remove(browser);
            browser.Dispose();

            tabs_content.Children.Remove(tabButton);

            Task.Delay(200).ContinueWith((e) =>
            {
                this.Dispatcher.Invoke(() =>
                {
                    if (isSameTab)
                    {
                        if (((Button)tabs_content.Children[tabs_content.Children.Count - 1]).Tag != null)
                        {
                            changeTab((Button)tabs_content.Children[tabs_content.Children.Count - 1]);
                        }
                        else
                        {
                            newTab(null, null);
                        }

                    }
                });
            });


        }


        /// <summary>
        /// Change to a different tab
        /// </summary>
        public void changeTab(Button tabButton)
        {

            foreach (Button button in tabs_content.Children)
            {
                button.Background = (Brush)new BrushConverter().ConvertFrom("#2f2f2f");
            }

            foreach (ChromiumWebBrowser b in browsers.Children)
            {
                b.Visibility = Visibility.Hidden;
            }

            tabButton.Background = (Brush)new BrushConverter().ConvertFrom("#1f1f1f");

            ((ChromiumWebBrowser)tabButton.Tag).Visibility = Visibility.Visible;
            currentTab = tabButton;
            currentBrowser = (ChromiumWebBrowser)tabButton.Tag;
            currentTabLabel = (Label)((WrapPanel)currentTab.Content).Children[0];


            txt_address.Text = currentBrowser.Address.ToString();
            currentTabLabel.Content = currentBrowser.Title;


        }

        private void but_back_click(object sender, RoutedEventArgs e)
        {
            currentBrowser.GetBrowser().GoBack();
        }


    }
}
