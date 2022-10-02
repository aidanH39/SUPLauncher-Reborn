using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SUPLauncher_Reborn.Logger;
using static SUPLauncher_Reborn.SuperiorServers;

namespace SUPLauncher_Reborn
{
    public partial class Overlay : Form
    {
        // Rectangle. Rectangle.
        public struct RECT
        {
            public int left, top, right, bottom;
        }

        RECT rect;
        public OverlayProfile overlayProfile; // Profile overlay instance.
        #region imports from user32.dll
        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll")]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(IntPtr hwnd, out RECT ipRect);
        [DllImport("User32.dll")]
        protected static extern int SetClipboardViewer(int hWndNewViewer);
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);
        #endregion

        public Overlay()
        {
            InitializeComponent();
            new ControlResize(pnl_, null, false, false, true, false);
        }

        private void Overlay_Load(object sender, EventArgs e)
        {
            Logger.Log(LogType.INFO, "Starting overlay form.");
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            try {
                SetClipboardViewer(this.Handle); // Set clipboard viewer to this form. So this form can catch when user copies.
            } catch (Exception ex)
            {
                Logger.Log(LogType.ERROR, "Failed to set clipboard viewer. " + ex.Message + "\n" + ex.StackTrace);
            }

            // Set to size of garry's mod window.
            Logger.Log(LogType.INFO, "Resizing overlay to gmod window...");
            IntPtr handle = Steam.getGMOD();
            GetWindowRect(handle, out rect);
            this.Size = new Size(rect.right - rect.left, rect.bottom - rect.top);
            this.Top = rect.top;
            this.Left = rect.right - this.Bounds.Width;
            this.Focus();





            Profile profile = SuperiorServers.getProfile(Program.steamid.ToString()); // Get SUP profile of current user.
            overlay_ProfileWidget1.loadProfile(profile);

            overlay_sitWidget1.loadSitCount(profile);

            chk_profileOverlay.Checked = Properties.Settings.Default.profileOverlayEnabled;
            Notification n = new Notification("OVERLAY", "Overlay has been loaded (" + ((ModifierKeys)Properties.Settings.Default.overlayModiferKey).ToString() + " + " + ((Keys)Properties.Settings.Default.overlayKey).ToString() + ")");
            n.Show();
            Logger.Log(LogType.INFO, "Overlay has been fully loaded. ");
        }

        /// <summary>
        /// Event when clipboard was changed.
        /// </summary>
        public class ClipboardChangedEventArgs : EventArgs
        {
            public readonly IDataObject DataObject;
            public ClipboardChangedEventArgs(IDataObject dataObject)
            {
                DataObject = dataObject;
            }
        }

        /// <summary>
        /// Open a form as a overlay window. Will have top most and can be minimised to the overlay.
        /// </summary>
        /// <param name="form">The form to start.</param>
        public void openOverlayWindow(Form form)
        {
            OverlayWindowTab tab = new OverlayWindowTab();
            tab.form = form;
            pnl_tabs.Controls.Add(tab);
            tab.Visible = false;
            form.Show();
            form.TopMost = true;
            form.SizeChanged += delegate
            {
                if (form.WindowState == FormWindowState.Minimized)
                {
                    tab.Visible = true;
                    form.Visible = false;
                } else
                {
                    form.Visible = true;
                    tab.Visible = false;
                }
            };
        }
        protected override void WndProc(ref Message m) // Catch messages from windows.
        {
            // Handle messages...
            base.WndProc(ref m);
            if (!Properties.Settings.Default.profileOverlayEnabled) return;
            if (m.Msg == 0x308 || m.Msg == 0x031D) // If message is WM_DRAWCLIPBOARD OR WM_CLIPBOARDUPDATE
            {
                // Gotta make sure its a steamid.
                bool steamid = false;
                long s = 0;
                string text = Clipboard.GetText(); // Get text from clipboard

                if (text.StartsWith("STEAM_") && text.Length > 17)
                {
                    steamid = true;
                }
                else if (long.TryParse(text, out s) && text.Length == 17)
                {
                    steamid = true;
                }

                if (steamid)
                {
                    // Ok... its a steamid. show the profile.
                    if (overlayProfile == null || overlayProfile.IsDisposed)
                    {
                        Logger.Log(LogType.INFO, "Copy event caught. Is SteamID. Showing overlay profile of steamid '" + text + "'");
                        overlayProfile = new OverlayProfile();
                        overlayProfile.loadProfile(SuperiorServers.getProfile(text));
                        overlayProfile.PointToScreen(new Point(0, 150));
                        overlayProfile.Show();

                    } else {
                        overlayProfile.Close();
                        overlayProfile = new OverlayProfile();
                        overlayProfile.loadProfile(SuperiorServers.getProfile(text));
                        overlayProfile.Show();
                    }
                }
            }
        }


        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "STEAM_ID")
            {
                textBox1.Text = "";
            }
        }

        private void btn_dupeMang_Click(object sender, EventArgs e)
        {
            openOverlayWindow(new DupeManager());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                openOverlayWindow(new ProfileForm(textBox1.Text, true));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(frm_main.serversList["Danktown"].Connect);
        }

        private void btn_zombies_Click(object sender, EventArgs e)
        {
            Process.Start(frm_main.serversList["Zombies"].Connect);
        }

        private void btn_cwrp_Click(object sender, EventArgs e)
        {
            Process.Start(frm_main.serversList["CWRP"].Connect);
        }

        private void btn_cwrp2_Click(object sender, EventArgs e)
        {
            Process.Start(frm_main.serversList["Events"].Connect);
        }

        private void btn_milrp_Click(object sender, EventArgs e)
        {
            Process.Start(frm_main.serversList["MilRP"].Connect);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.openOverlayWindow(new ProfileForm(Program.steamid.ToString(), true));
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.profileOverlayEnabled = chk_profileOverlay.Checked;
            Properties.Settings.Default.Save();
        }

        // Steam friend checker
        private void friendChecker(object sender, EventArgs e)
        {
            string oplayer1 = Interaction.InputBox("Enter steamid of a player.", "Enter SteamID", true);
            string oplayer2 = Interaction.InputBox("Enter steamid of the other player. To check if they are friends on steam.", "Enter SteamID", true);

            string player1 = oplayer1;
            string player2 = oplayer2;

            if (player1 == null || player2 == null)
            {
                return;
            }

            if (player1.StartsWith("STEAM_"))
            {
                player1 = Steam.SteamID32To64(oplayer1).ToString();
            }

            if (player2.StartsWith("STEAM_"))
            {
                player2 = Steam.SteamID32To64(player2).ToString();
            }

            Logger.Log(LogType.INFO, "Looking for freinds connection between steamid '" + player1 + "' & '" + player2 + "'");

            List<String> player1Friends = Steam.getFriends(player1);
            List<String> player2Friends = Steam.getFriends(player2);

            bool friends = false;

            if (player1Friends.Contains(player2))
            {
                friends = true;
            }
            if (player2Friends.Contains(player1))
            {
                friends = true;
            }
            if (friends)
            {
                Notification not = new Notification("✔️ STEAM FRIEND LOOKUP", "These player's are friends on steam\n" + oplayer1 + " & " + oplayer2);
                not.Show();
            } else
            {
                Notification not = new Notification("❌ STEAM FRIEND LOOKUP", "These player's are not friends on steam\n" + oplayer1 + " &\n" + oplayer2);
                not.Show();
            }


        }

        private void Overlay_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Escape)
            {
                if (this.Visible)
                {
                    this.Visible = false;
                    WindowHelper.SetForegroundWindow(Steam.getGMOD());
                }
            }
        }

        private void btn_browser_Click(object sender, EventArgs e)
        {
            this.openOverlayWindow(new InGameBrowser());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openOverlayWindow(new NotesWriter());
        }
    }
}
