using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SUPLauncher
{
    /// <summary>
    /// Interaction logic for SettingsPanel.xaml
    /// </summary>
    public partial class SettingsPanel : UserControl
    {


        /// <summary>
        /// Not gonna lie. Most messy file in the whole project. Needs work in future lmao.
        /// </summary>
        public SettingsPanel()
        {
            InitializeComponent();
            this.Loaded += loaded;
        }

        // Vars
        Window parentWindow;
        ModifierKeys overlay_modifier;
        Key overlay_key;

        ModifierKeys staff_show_modifier;
        Key staff_show_key;

        ModifierKeys staff_po_modifier;
        Key staff_po_key;


        private void loaded(object sender, RoutedEventArgs e)
        {
            if (!DesignerProperties.GetIsInDesignMode(this))
            {
                // Find parent window and capture key press events
                parentWindow = Window.GetWindow(this);
                parentWindow.KeyDown += UserControl_KeyDown;


                overlay_modifier = (ModifierKeys)AppSettings.Default.bind_overlay_modifier;
                overlay_key = KeyInterop.KeyFromVirtualKey((int)AppSettings.Default.bind_overlay_key);
                staff_po_key = KeyInterop.KeyFromVirtualKey((int)AppSettings.Default.bind_staff_po_key);
                staff_po_modifier = (ModifierKeys)AppSettings.Default.bind_staff_po_modifier;
                staff_show_key = KeyInterop.KeyFromVirtualKey((int)AppSettings.Default.bind_staff_show_key);
                staff_show_modifier = (ModifierKeys)AppSettings.Default.bind_staff_show_modifier;


                overlay_key_button.Content = overlay_key;
                overlay_modifier_button.Content = overlay_modifier.ToString();

                staff_po_modifier_button.Content = staff_po_modifier.ToString();
                staff_po_key_button.Content = staff_po_key;

                staff_show_modifier_button.Content = staff_show_modifier.ToString();
                staff_show_key_button.Content = staff_show_key;

                check_afk.IsChecked = AppSettings.Default.enable_afk;
                check_discord.IsChecked = AppSettings.Default.enable_discord_actvity;

                check_overlay.IsChecked = AppSettings.Default.enable_overlay;

                txt_afk_args.Text = AppSettings.Default.afk_arguments;

                check_profileOverlay.IsChecked = AppSettings.Default.enable_profileOverlay;
                string startUpFolderPath =
                Environment.GetFolderPath(Environment.SpecialFolder.Startup);

                check_startup.IsChecked = System.IO.File.Exists(startUpFolderPath + "\\SUPLauncher.lnk");
            }


        }


        Button editingKeybind = null;

        private void Modifier_Click(object sender, RoutedEventArgs e)
        {
            // Start setting a keybind
            Button button = (Button)sender;
            button.Content = "-";
            button.Background = (Brush)new BrushConverter().ConvertFrom("#4d4d4d");
            editingKeybind = button;
        }



        private void UserControl_KeyDown(object sender, KeyEventArgs e)
        {
            // Capture key press events.
            if (editingKeybind != null)
            {

                if ((string)editingKeybind.Tag == "modifier")
                {

                    if (e.Key == Key.LeftCtrl)
                    {
                        editingKeybind.Content = "LCTRL";
                    }
                    else if (e.Key == Key.RightCtrl)
                    {
                        editingKeybind.Content = "RCTRL";

                    }
                    else if (e.Key == Key.System)
                    {
                        editingKeybind.Content = "ALT";
                    }
                    else
                    {
                        return;
                    }
                }
                else if (e.Key != Key.System && e.Key != Key.LeftCtrl && e.Key != Key.RightCtrl && e.Key != Key.LeftShift && e.Key != Key.RightShift && e.Key != Key.LWin && e.Key != Key.Tab)
                {
                    editingKeybind.Content = e.Key.ToString();
                }
                else
                {
                    return;
                }



                if ((Button)editingKeybind == overlay_key_button)
                {
                    overlay_key = e.Key;
                }
                else if ((Button)editingKeybind == overlay_modifier_button)
                {
                    overlay_modifier = parseModifier(e.Key);
                }
                else if ((Button)editingKeybind == staff_show_modifier_button)
                {
                    staff_show_modifier = parseModifier(e.Key);
                }
                else if ((Button)editingKeybind == staff_show_key_button)
                {
                    staff_show_key = e.Key;
                }
                else if ((Button)editingKeybind == staff_po_modifier_button)
                {
                    staff_po_modifier = parseModifier(e.Key);
                }
                else if ((Button)editingKeybind == staff_po_key_button)
                {
                    staff_po_key = e.Key;
                }

                editingKeybind.Background = (Brush)new BrushConverter().ConvertFrom("#2d2d2d");
                editingKeybind = null;
            }
        }

        private ModifierKeys parseModifier(Key key)
        {
            if (key == Key.LeftCtrl || key == Key.RightCtrl)
            {
                return ModifierKeys.Control;
            }
            else if (key == Key.LeftAlt || key == Key.RightAlt || key == Key.System)
            {
                return ModifierKeys.Alt;
            }
            return ModifierKeys.None;
        }

        private void UserControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Cancel setting key bind
            if (editingKeybind != null)
            {
                editingKeybind.Background = (Brush)new BrushConverter().ConvertFrom("#2d2d2d");
                editingKeybind = null;
            }

        }

        // Registers a hot key with Windows.
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private const int HOTKEY_ID = 9001;
        private void settings_save(object sender, RoutedEventArgs e)
        {
            AppSettings.Default.bind_overlay_modifier = (uint)overlay_modifier;
            AppSettings.Default.bind_overlay_key = (uint)KeyInterop.VirtualKeyFromKey(overlay_key);
            AppSettings.Default.bind_staff_show_modifier = (uint)staff_show_modifier;
            AppSettings.Default.bind_staff_show_key = (uint)KeyInterop.VirtualKeyFromKey(staff_show_key);
            AppSettings.Default.bind_staff_po_modifier = (uint)staff_po_modifier;
            AppSettings.Default.bind_staff_po_key = (uint)KeyInterop.VirtualKeyFromKey(staff_po_key);


            AppSettings.Default.afk_arguments = txt_afk_args.Text;
            AppSettings.Default.enable_afk = (bool)check_afk.IsChecked;
            AppSettings.Default.enable_discord_actvity = (bool)check_discord.IsChecked;
            AppSettings.Default.enable_profileOverlay = (bool)check_profileOverlay.IsChecked;
            AppSettings.Default.enable_overlay = (bool)check_overlay.IsChecked;

            WshShell wshShell = new WshShell();



            IWshRuntimeLibrary.IWshShortcut shortcut;
            string startUpFolderPath =
              Environment.GetFolderPath(Environment.SpecialFolder.Startup);

            if ((bool)check_startup.IsChecked && !System.IO.File.Exists(startUpFolderPath + "\\SUPLauncher.lnk"))
            {
                // Create the shortcut
                shortcut =
                  (IWshRuntimeLibrary.IWshShortcut)wshShell.CreateShortcut(
                    startUpFolderPath + "\\SUPLauncher" + ".lnk");

                shortcut.TargetPath = Process.GetCurrentProcess().MainModule.FileName;
                shortcut.WorkingDirectory = System.AppDomain.CurrentDomain.BaseDirectory;
                shortcut.Description = "Launch SUPLauncher";
                shortcut.Save();
            } else if (!(bool)check_startup.IsChecked && System.IO.File.Exists(startUpFolderPath + "\\SUPLauncher.lnk"))
            {
                System.IO.File.Delete(startUpFolderPath + "\\SUPLauncher.lnk");
            }

            AppSettings.Default.Save();

            InputBox box = new InputBox("Settings have been saved! The application will now restart.", BoxType.MESSAGE_BOX, "Saved settings!");
            box.ShowDialog();

            // Restart app
            Process.Start(Process.GetCurrentProcess().MainModule.FileName);
            Application.Current.Shutdown();
        }

    }
}
