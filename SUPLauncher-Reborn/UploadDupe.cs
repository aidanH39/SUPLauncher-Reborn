using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUPLauncher_Reborn
{
    public partial class UploadDupe : Form
    {
        public UploadDupe(string path=null)
        {
            InitializeComponent();
            fileDialog_dupe.FileName = path;
            lbl_selectDupeHead.Text = "Select Dupe (" + fileDialog_dupe.SafeFileName + ")";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            fileDialog_image.ShowDialog();
        }

        bool isTopPanelDragged = false;
        bool isWindowMaximized = false;
        Point offset;
        Size _normalWindowSize;
        Point _normalWindowLocation = Point.Empty;
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

                        isWindowMaximized = false;
                    }
                }
            }
        }

        private void TopBar_MouseUp(object sender, MouseEventArgs e)
        {
            isTopPanelDragged = false;
            if (this.Location.Y <= 5)
            {
                if (!isWindowMaximized)
                {
                    _normalWindowSize = this.Size;
                    _normalWindowLocation = this.Location;

                    Rectangle rect = Screen.PrimaryScreen.WorkingArea;
                    this.Location = new Point(0, 0);
                    this.Size = new System.Drawing.Size(rect.Width, rect.Height);

                    isWindowMaximized = true;
                }
            }
        }


        private void btn_selectDupe_Click(object sender, EventArgs e)
        {
            fileDialog_dupe.ShowDialog();
        }

        private void fileDialog_image_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            if (fileDialog_dupe.FileName.Length < 1)
            {
                pnl_indDupeSelect.BackColor = Color.FromArgb(175, 125, 125);
                Interaction.MessageBox("You have not selected a dupe file!", "Select a dupe file!");
                return;
            }


            if (txt_dupeName.Text.Length < 1)
            {
                pnl_indDupeName.BackColor = Color.FromArgb(175, 125, 125);
                return;
            }

            if (txt_dupeDesc.Text.Length < 1)
            {
                pnl_indDescription.BackColor = Color.FromArgb(175, 125, 125);
                return;
            }

            if (combo_type.Text.Length < 1)
            {
                pnl_indVisibility.BackColor = Color.FromArgb(175, 125, 125);
                return;
            }

            HttpContent fileStreamContent = new StreamContent(fileDialog_dupe.OpenFile());
            HttpContent imageStreamContent = null;
            if (fileDialog_image.FileName.Length > 0)
            {
                imageStreamContent = new StreamContent(fileDialog_image.OpenFile());
            }
            using (var client = new HttpClient())
            using (var formData = new MultipartFormDataContent())
            {
                formData.Add(fileStreamContent, "file", "file");

                if (imageStreamContent != null)
                {
                    formData.Add(imageStreamContent, "image", "image");
                }
                
                
                formData.Add(new StringContent(Properties.Settings.Default.apiSecret), "key");
                formData.Add(new StringContent(txt_dupeName.Text), "name");
                formData.Add(new StringContent(txt_dupeDesc.Text), "description");
                formData.Add(new StringContent(combo_type.Text), "type");
                var response = await client.PostAsync("http://bestofall.ml:2095/api/editDupe.php?upload", formData);
                if (!response.IsSuccessStatusCode)
                {
                    Interaction.MessageBox("Something went wrong. Status code: " + response.StatusCode.ToString());
                } else
                {
                    Interaction.MessageBox("Success!");
                }
                
            }
        }

        private void fileDialog_dupe_FileOk(object sender, CancelEventArgs e)
        {
            lbl_selectDupeHead.Text = "Select Dupe (" + fileDialog_dupe.SafeFileName + ")";
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
