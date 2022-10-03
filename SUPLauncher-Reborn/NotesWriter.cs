using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUPLauncher_Reborn
{
    public partial class NotesWriter : Form
    {
        // Fuck flickering
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private string evalName;

        public NotesWriter()
        {
            InitializeComponent();
            new FormResize(this, pnl_topBar);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            pnl_load.AutoScroll = false;
            pnl_load.HorizontalScroll.Enabled = false;
            pnl_load.HorizontalScroll.Visible = false;
            pnl_load.HorizontalScroll.Maximum = 0;
            pnl_load.AutoScroll = true;
            if (!Directory.Exists(Application.StartupPath + "/evals/"))
            {
                Directory.CreateDirectory(Application.StartupPath + "/evals/");
            }
            loadEvals();
        }

        public void loadEvals()
        {
            pnl_load.Controls.Clear();
            foreach (Control control in pnl_load.Controls)
            {
                control.Dispose();
            }
            foreach (string file in Directory.EnumerateFiles(Application.StartupPath + "/evals/"))
            {
                NoteFile f = new NoteFile(Path.GetFileName(file));
                pnl_load.Controls.Add(f);
                f.Width = 150;
                f.MouseClick += loadEval;
            }
        }

        public void loadEval(object sender, MouseEventArgs e)
        {
            NoteFile f = (NoteFile)sender;
            if (e.Button == MouseButtons.Left)
            {
                if (this.evalName != null)
                {
                    File.WriteAllText(Application.StartupPath + "/evals/" + evalName, txt_content.Rtf); // Save when swapping file to avoid data loss.
                }
                txt_content.Rtf = File.ReadAllText(Application.StartupPath + "/evals/" + f.file);
                this.evalName = f.file;
            } else if (e.Button == MouseButtons.Right)
            {
                if (Interaction.InputBox("Are you sure you want to delete eval '" + f.file + "'? Type \"delete\" to confirm.", "Are you sure?", true) == "delete")
                {
                    File.Delete(Application.StartupPath + "/evals/" + f.file);
                    loadEvals();
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FontStyle newFontStyle = txt_content.SelectionFont.Style;
            if (txt_content.SelectionFont.Bold)
            {
                newFontStyle &= ~FontStyle.Bold;
            } else
            {
                newFontStyle |= FontStyle.Bold;
            }
            txt_content.SelectionFont = new Font(txt_content.SelectionFont, newFontStyle);
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            if (txt_content.SelectionFont.Bold)
            {
                btn_bold.BackColor = Color.FromArgb(35,35,35);
            } else
            {
                btn_bold.BackColor = Color.FromArgb(25, 25, 25);
            }

            if (txt_content.SelectionFont.Italic)
            {
                btn_italic.BackColor = Color.FromArgb(35, 35, 35);
            }
            else
            {
                btn_italic.BackColor = Color.FromArgb(25, 25, 25);
            }

            if (txt_content.SelectionFont.Underline)
            {
                btn_underline.BackColor = Color.FromArgb(35, 35, 35);
            }
            else
            {
                btn_underline.BackColor = Color.FromArgb(25, 25, 25);
            }

            if (txt_content.SelectionFont.Strikeout)
            {
                btn_strike.BackColor = Color.FromArgb(35, 35, 35);
            }
            else
            {
                btn_strike.BackColor = Color.FromArgb(25, 25, 25);
            }

            if (txt_content.SelectionBullet)
            {
                btn_bullets.BackColor = Color.FromArgb(35, 35, 35);
            } else
            {
                btn_bullets.BackColor = Color.FromArgb(25, 25, 25);
            }

            btn_color.BackColor = txt_content.SelectionColor;
            txt_fontSize.Text = txt_content.SelectionFont.Size.ToString();

        }

        private void btn_italic_Click(object sender, EventArgs e)
        {
            FontStyle newFontStyle = txt_content.SelectionFont.Style;
            if (txt_content.SelectionFont.Italic)
            {
                newFontStyle &= ~FontStyle.Italic;
            }
            else
            {
                newFontStyle |= FontStyle.Italic;
            }
            txt_content.SelectionFont = new Font(txt_content.SelectionFont, newFontStyle);
        }

        private void btn_underline_Click(object sender, EventArgs e)
        {
            FontStyle newFontStyle = txt_content.SelectionFont.Style;
            if (txt_content.SelectionFont.Underline)
            {
                newFontStyle &= ~FontStyle.Underline;
            }
            else
            {
                newFontStyle |= FontStyle.Underline;
            }
            txt_content.SelectionFont = new Font(txt_content.SelectionFont, newFontStyle);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {


            if (File.Exists(Application.StartupPath + "/evals/" + txt_name.Text))
            {
                Interaction.MessageBox("Another Eval is already called \"" + txt_name.Text + "\". Use a different name.");
            } else
            {
                File.WriteAllText(Application.StartupPath + "/evals/" + txt_name.Text, txt_content.Rtf);
                evalName = txt_name.Text;
                lbl_autosave.Text = "Autosave Enabled";
                loadEvals();
            }

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            if (pnl_leftLoad.Width < 200)
            {
                this.pnl_leftLoad.Width = 200;
            } else
            {
                this.pnl_leftLoad.Width = 0;
            }
            
        }
        int previousSaveLen = 0;
        private void tmr_autoSave_Tick(object sender, EventArgs e)
        {
            if (evalName != null)
            {
                this.Text = "Notes Writer - " + evalName;
                if (txt_content.Rtf.Length != previousSaveLen)
                {
                    previousSaveLen = txt_content.Rtf.Length;
                    lbl_autosave.Text = "Saving...";
                    File.WriteAllText(Application.StartupPath + "/evals/" + evalName, txt_content.Rtf);
                    lbl_autosave.Text = "Saved.";
                }
            } else
            {
                this.Text = "Eval Writer";
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

        private void btn_color_Click(object sender, EventArgs e)
        {
            content_color.ShowDialog();
            btn_color.BackColor = content_color.Color;
            txt_content.SelectionColor = content_color.Color;
        }

        private void btn_strike_Click(object sender, EventArgs e)
        {
            FontStyle newFontStyle = txt_content.SelectionFont.Style;
            if (txt_content.SelectionFont.Strikeout)
            {
                newFontStyle &= ~FontStyle.Strikeout;
            }
            else
            {
                newFontStyle |= FontStyle.Strikeout;
            }
            txt_content.SelectionFont = new Font(txt_content.SelectionFont, newFontStyle);
        }

        private void btn_bullets_Click(object sender, EventArgs e)
        {
            if (txt_content.SelectionBullet)
            {
                txt_content.SelectionBullet = false;
            } else
            {
                txt_content.SelectionBullet = true;
            }
        }

        private void txt_fontSize_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (Int32.TryParse(txt_fontSize.Text, out i))
            {
                Font newFont = new Font(txt_content.SelectionFont.FontFamily, i, txt_content.SelectionFont.Style);
                txt_content.SelectionFont = newFont;
            } else
            {
                txt_fontSize.Text = "12";
            }
        }

        bool bDown = false;
        bool uDown = false;
        bool iDown = false;
        bool sDown = false;

        private void txt_content_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.B)
            {
                bDown = true;
            } else if (e.KeyCode == Keys.S)
            {
                sDown = true;
            }
            else if (e.KeyCode == Keys.I)
            {
                iDown = true;
            }
            else if (e.KeyCode == Keys.U)
            {
                uDown = true;
            }

            if (ModifierKeys.HasFlag(Keys.Control) && bDown)
            {
                button1_Click(null, null);
            } else if (ModifierKeys.HasFlag(Keys.Control) && uDown)
            {
                btn_underline_Click(null, null);
            }
            else if (ModifierKeys.HasFlag(Keys.Control) && sDown)
            {
                btn_strike_Click(null, null);
            }
            else if (ModifierKeys.HasFlag(Keys.Control) && iDown)
            {
                btn_italic_Click(null, null);
            }
        }

        private void txt_content_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.B)
            {
                bDown = false;
            }
            else if (e.KeyCode == Keys.S)
            {
                sDown = false;
            }
            else if (e.KeyCode == Keys.U)
            {
                uDown = false;
            }
            else if (e.KeyCode == Keys.I)
            {
                iDown = false;
            }
        }
    }
}
