using CefSharp;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection.PortableExecutable;
using System.Security.Policy;
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
using System.Windows.Threading;
using static System.Net.WebRequestMethods;
using File = System.IO.File;
using Path = System.IO.Path;
using Microsoft.VisualBasic.FileIO;
using FileSystem = Microsoft.VisualBasic.FileIO.FileSystem;
using Microsoft.Win32;

namespace SUPLauncher
{
    /// <summary>
    /// Interaction logic for DupeManager.xaml
    /// </summary>
    public partial class DupeManager : UserControl
    {

        public class Dupe
        {
            public string Name { get; set; }
            public string Thumbnail { get; set; }
        }

        Window parentWindow;
        Toolbar toolbar;
        MenuItem menuItem;
        public string rootPath = Steam.getGarrysModPath() + "\\garrysmod\\data\\advdupe2";
        public string currentPath = Steam.getGarrysModPath() + "\\garrysmod\\data\\advdupe2";

        public DupeManager()
        {
            InitializeComponent();
            txt_path.Text = currentPath;
            txt_path.IsReadOnly = true;
            loadFolder(currentPath);
            this.Loaded += new RoutedEventHandler(DupeManager_Loaded);
        }

        public static IEnumerable<T> FindVisualChildren<T>(DependencyObject depObj) where T : DependencyObject
        {
            if (depObj == null) yield return (T)Enumerable.Empty<T>();
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
            {
                DependencyObject ithChild = VisualTreeHelper.GetChild(depObj, i);
                if (ithChild == null) continue;
                if (ithChild is T t) yield return t;
                foreach (T childOfChild in FindVisualChildren<T>(ithChild)) yield return childOfChild;
            }
        }

        void DupeManager_Loaded(object sender, RoutedEventArgs e)
        {
            parentWindow = Window.GetWindow(this);

            foreach (Toolbar toolbar in FindVisualChildren<Toolbar>(parentWindow))
            {
                this.toolbar = toolbar;
            }

        }


        public async void downloadDupe(string url, string dir_path=null)
        {
            if (dir_path == null)
            {
                dir_path = currentPath;
            }
            if (parentWindow is MainWindow)
            {
                if (CustomRequestHandler.currentDupeDownloading != null)
                {
                    await CustomRequestHandler.currentDupeDownloading.EvaluateScriptAsync("document.getElementsByClassName('sup')[0].getElementsByTagName('p')[0].innerText = 'Downloading dupe to \"advdupe2/Downloads\"...';");
                }

                ((MainWindow)parentWindow).lbl_progressText.Content = "Downloading dupe...";
                ((MainWindow)parentWindow).grid_progress.Visibility = Visibility.Visible;

            }
            if (url.Contains("?key="))
            {
                url = url + "&download";
            }
            HttpResponseMessage file = await App.httpClient.GetAsync(url);

            // Check for redirection (Required if HTTPS > HTTP)
            IEnumerable<string> values;
            if (file.Headers.TryGetValues("Location", out values))
            {
                string u = values.First();
                if (u.Contains("?key="))
                {
                    u = u + "&download";
                }
                file = await App.httpClient.GetAsync(u);
            }

            if (file.StatusCode != HttpStatusCode.OK)
            {
                if (parentWindow is MainWindow)
                {
                    Logger.Log(Logger.LogType.ERROR, "Failed to download dupe. Status Code: " + file.StatusCode.ToString() + ", Response Headers: " + file.Content.Headers + ", URL: " + url);
                    if (CustomRequestHandler.currentDupeDownloading != null)
                    {
                        await CustomRequestHandler.currentDupeDownloading.EvaluateScriptAsync("document.getElementsByClassName('sup')[0].getElementsByTagName('p')[0].innerText = 'Failed to download dupe!';");
                    }
                    ((MainWindow)parentWindow).lbl_progressText.Content = "Failed to download dupe...";
                    Task.Delay(5000).ContinueWith(delegate
                    {
                        ((MainWindow)parentWindow).grid_progress.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(() => { ((MainWindow)parentWindow).grid_progress.Visibility = Visibility.Hidden; }));
                    });

                }
                
                return;
            }

            string fileName = "";

            // Try to extract the filename from the Content-Disposition header
            try
            {
                if (file.Content.Headers.GetValues("Content-Disposition").FirstOrDefault("").Length > 0)
                {
                    fileName = file.Content.Headers.GetValues("Content-Disposition").FirstOrDefault().Substring(file.Content.Headers.GetValues("Content-Disposition").FirstOrDefault().IndexOf("filename=") + 9).Replace("\"", "");
                }
            } catch (Exception e)
            {
                ((MainWindow)parentWindow).lbl_progressText.Content = "Failed to download dupe...";
            }
            if (fileName.Length < 1)
            {
                ((MainWindow)parentWindow).lbl_progressText.Content = "Failed to download dupe...";
                return;
            }


            if (!Directory.Exists(dir_path))
            {
                Directory.CreateDirectory(dir_path);
            }

            File.WriteAllBytes(dir_path + "\\" + fileName, file.Content.ReadAsByteArrayAsync().Result);
            if (parentWindow is MainWindow)
            {
                ((MainWindow)parentWindow).lbl_progressText.Content = "Downloaded dupe '" + fileName + "'";
                if (CustomRequestHandler.currentDupeDownloading != null)
                {
                    await CustomRequestHandler.currentDupeDownloading.EvaluateScriptAsync("document.getElementsByClassName('sup')[0].getElementsByTagName('p')[0].innerText = 'Dupe has been imported to \"advdupe2/Downloads\"!';");
                }
                Task.Delay(5000).ContinueWith(delegate
                {
                    ((MainWindow)parentWindow).grid_progress.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(() => { ((MainWindow)parentWindow).grid_progress.Visibility = Visibility.Hidden; }));
                });
            }
            loadFolder(dir_path);
        }

        async void importDupeURL(object sender, RoutedEventArgs e)
        {
            InputBox box = new InputBox("Enter the URL to the dupe");
            string path = currentPath;
            box.Owner = parentWindow;
            box.ShowDialog();
            if (box.getText().Length > 1)
            {
                downloadDupe(box.getText());
            }
        }

        void importDupeLocal(object sender, RoutedEventArgs e)
        {
            browseLocal(sender, e);
        }


        public void loadFolder(string path)
        {
            currentPath = path;
            txt_path.Text = currentPath;
            string[] f = Directory.GetFiles(path);
            string[] folders = Directory.GetDirectories(path);
            ListBoxFiles.Items.Clear();
            foreach (string folder in folders)
            {
                WrapPanel panel = new WrapPanel();
                panel.Orientation = Orientation.Vertical;
                panel.HorizontalAlignment = HorizontalAlignment.Stretch;
                ListBoxItem itm = new ListBoxItem();
                itm.Tag = folder;
                itm.SetResourceReference(ListBoxItem.StyleProperty, "folder");
                itm.MouseDoubleClick += onFolderClick;
                Image img = new Image();
                img.Source = new BitmapImage(new Uri("pack://application:,,,/folder.png"));
                img.Width = 45;
                img.Height = 45;
                img.HorizontalAlignment = HorizontalAlignment.Center;


                Label label = new Label();
                label.Content = Path.GetFileNameWithoutExtension(folder);
                label.Width = 100;
                itm.ToolTip = Path.GetFileNameWithoutExtension(folder);

                label.HorizontalAlignment = HorizontalAlignment.Center;
                label.HorizontalContentAlignment = HorizontalAlignment.Center;

                panel.Children.Add(img);
                panel.Children.Add(label);
                itm.Content = panel;
                ListBoxFiles.Items.Add(itm);
            }

            foreach (string s in f)
            {
                WrapPanel panel = new WrapPanel();
                panel.Orientation = Orientation.Vertical;
                panel.HorizontalAlignment = HorizontalAlignment.Stretch;
                ListBoxItem itm = new ListBoxItem();

                Image img = new Image();
                img.Source = new BitmapImage(new Uri("pack://application:,,,/textless_logo.png"));
                img.Width = 45;
                img.Height = 45;
                img.HorizontalAlignment = HorizontalAlignment.Center;


                Label label = new Label();
                label.Content = Path.GetFileNameWithoutExtension(s);
                label.HorizontalAlignment = HorizontalAlignment.Stretch;
                label.Width = 100;

                itm.ToolTip = Path.GetFileNameWithoutExtension(s);
                itm.Tag = s;
                label.HorizontalAlignment = HorizontalAlignment.Center;
                label.HorizontalContentAlignment = HorizontalAlignment.Center;

                panel.Children.Add(img);
                panel.Children.Add(label);
                itm.Content = panel;
                ListBoxFiles.Items.Add(itm);


            }
        }

        public void onFolderClick(object sender, MouseButtonEventArgs e)
        {
            ListBoxItem item = (ListBoxItem)sender;
            loadFolder(item.Tag.ToString());
        }

        private void onBackClick(object sender, RoutedEventArgs e)
        {
            if (currentPath != rootPath) 
                loadFolder(Directory.GetParent(currentPath).FullName);
        }

        private void onShareClick(object sender, RoutedEventArgs e)
        {
            ShareDialog w = new ShareDialog((string)((ListBoxItem)ListBoxFiles.SelectedItem).Tag);
            w.Owner = parentWindow;
            w.Show();
        }

        private void onHomeClick(object sender, RoutedEventArgs e)
        {
            loadFolder(rootPath);
        }

        private void onRefreshClick(object sender, RoutedEventArgs e)
        {
            loadFolder(currentPath);
        }
 
        void unloadToolbarOptions()
        {
            toolbar._menu.Items.Remove(menuItem);
        }

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
            unloadToolbarOptions();
        }

        private void UserControl_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (parentWindow is MainWindow)
            {
                if ((bool)e.NewValue == false)
                {
                    unloadToolbarOptions();
                }
                else
                {
                    MenuItem item = new MenuItem();
                    item.Header = "Import Dupe";
                    item.Name = "_menu_import";
                    MenuItem importURL = new MenuItem();
                    importURL.Header = "Import dupe by URL";
                    importURL.Click += importDupeURL;
                    MenuItem importLocal = new MenuItem();
                    importLocal.Header = "Browse for dupes on your System";
                    importLocal.Click += importDupeLocal;
                    menuItem = item;
                    item.Items.Add(importURL);
                    item.Items.Add(importLocal);
                    toolbar._menu.Items.Add(item);

                    if (parentWindow is MainWindow)
                    {
                        toolbar._appName.Header = "Dupe Manager";
                    }

                }
            }            
        }
        private void onNewFolder(object sender, RoutedEventArgs e)
        {

            string newFolderName = "New Folder";
            int i = 1;
            while (Directory.Exists(currentPath + "\\" + newFolderName)) {
                newFolderName = "New Folder (" + i + ")";
                i++;
            }

            Directory.CreateDirectory(currentPath + "\\" + newFolderName);
            loadFolder(currentPath);
        }

        private void onRename(object sender, RoutedEventArgs e)
        {
            string path = (string)((ListBoxItem)ListBoxFiles.SelectedItem).Tag;

            if (Directory.Exists(path))
            {
                InputBox box = new InputBox("Rename folder to...");
                box.Owner = parentWindow;
                box.ShowDialog();
                if (box.getText().Length > 0)
                {
                    if (Directory.Exists(Directory.GetParent(path).FullName + "\\" + box.getText())) {
                        MessageBox.Show("That folder already exists!");
                    } else
                    {
                        Directory.Move(path, Directory.GetParent(path).FullName + "\\" + box.getText());
                        loadFolder(currentPath);
                    }
                    
                }
            } else if (File.Exists(path))
            {
                InputBox box = new InputBox("Rename '" + Path.GetFileNameWithoutExtension(path) + "' to...");
                box.Owner = parentWindow;
                box.ShowDialog();
                if (box.getText().Length > 0)
                {
                    if (File.Exists(currentPath + "\\" + box.getText())) {
                        MessageBox.Show("That file already exists!");
                    }
                    else
                    {
                        Directory.Move(path, currentPath + "\\" + box.getText());
                        loadFolder(currentPath);
                    }
                }
            }

        }

        private void onDelete(object sender, RoutedEventArgs e)
        {
            InputBox box = new InputBox("Are you sure you would like to delete this file? This will be available in the Recycle Bin.", BoxType.ACCEPT_CANCEL, "Are you sure?");
            box.ShowDialog();

            if (box.getConfirm())
            {
                string path = (string)((ListBoxItem)ListBoxFiles.SelectedItem).Tag;
                FileSystem.DeleteFile(path, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                loadFolder(currentPath);
            }

        }

        private void onCopy(object sender, RoutedEventArgs e)
        {
            Clipboard.SetDataObject((string)((ListBoxItem)ListBoxFiles.SelectedItem).Tag);
        }

        private void browseLocal(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select dupe(s) to import...";
            dialog.Multiselect = true;
            dialog.CheckFileExists = true;
            dialog.DefaultExt = "txt";
            dialog.Filter = "txt files (*.txt)|*.txt";
            dialog.CheckPathExists = true;
            dialog.ValidateNames = true;
            dialog.ShowDialog();
            int i = 0;
            foreach(string s in dialog.FileNames)
            {
                File.Copy(s, currentPath + "/" + dialog.SafeFileNames[i]);
                i++;
            }
            loadFolder(currentPath);

        }

        private void onFolderDelete(object sender, RoutedEventArgs e)
        {
            string path = (string)((ListBoxItem)ListBoxFiles.SelectedItem).Tag;

            if (Directory.GetFiles(path).Length <= 0)
            {
                Directory.Delete(path, false); // Quick and easy if no files.
                loadFolder(currentPath);
            }
            else
            {
                // Make sure user wants to delete folder and all files.
                InputBox box = new InputBox("Are you sure you would like to delete this folder and all of its content? This will be available in the Recycle Bin.", BoxType.ACCEPT_CANCEL, "Are you sure?");
                box.ShowDialog();
                if (box.getConfirm())
                {
                    FileSystem.DeleteDirectory(path, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                    loadFolder(currentPath);
                }
            }

        }

    }
}
