using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUPLauncher_Reborn
{
    public partial class Settings : Form
    {

        public Keys overlayOpenKey = (Keys)Properties.Settings.Default.overlayKey;
        public ModifierKeys overOpenModifier = (ModifierKeys)Properties.Settings.Default.overlayModiferKey;

        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            this.overlayOpenKey = e.KeyCode;
            this.textBox1.Text = e.KeyCode.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Program.overlayHotkeyHook.RegisterKeybind((uint)overOpenModifier, (int)overlayOpenKey);
                Properties.Settings.Default.overlayKey = (int)overlayOpenKey;
                Properties.Settings.Default.overlayModiferKey = (uint)overOpenModifier;
                Properties.Settings.Default.Save();

                MessageBox.Show("Settings changed! Application will now restart!");
                Application.Restart();
            } catch(Exception)
            {
                MessageBox.Show("This keybind could not be set! Try a different one!");
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "CTRL")
            {
                overOpenModifier = SUPLauncher_Reborn.ModifierKeys.Control;
            } else if (comboBox1.Text == "ALT") {
                overOpenModifier = SUPLauncher_Reborn.ModifierKeys.Alt;
            } else if (comboBox1.Text == "SHIFT") {
                overOpenModifier = SUPLauncher_Reborn.ModifierKeys.Shift;
            }
        }

        // Window Drag

        bool isTopPanelDragged = false;
        Size _normalWindowSize;
        Point _normalWindowLocation = Point.Empty;
        Point offset;
        private void TopBar_MouseUp(object sender, MouseEventArgs e)
        {
            isTopPanelDragged = false;
            if (this.Location.Y <= 5)
            {
                _normalWindowSize = this.Size;
                _normalWindowLocation = this.Location;

                Rectangle rect = Screen.PrimaryScreen.WorkingArea;
                this.Location = new Point(0, 0);
                this.Size = new System.Drawing.Size(rect.Width, rect.Height);
            }
        }

        private void TopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isTopPanelDragged)
            {
                Point newPoint = pnl_topBar.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(offset);
                this.Location = newPoint;

                if (this.Location.X > 2 || this.Location.Y > 2)
                {
                    if (this.WindowState == FormWindowState.Maximized)
                    {
                        this.Location = _normalWindowLocation;
                        this.Size = _normalWindowSize;
                    }
                }
            }
        }

        private void TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isTopPanelDragged = true;
                Point pointStartPosition = this.PointToScreen(new Point(e.X, e.Y));
                offset = new Point
                {
                    X = this.Location.X - pointStartPosition.X,
                    Y = this.Location.Y - pointStartPosition.Y
                };
            }
            else
            {
                isTopPanelDragged = false;
            }
            if (e.Clicks == 2)
            {
                isTopPanelDragged = false;

            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
        }
    }
}
