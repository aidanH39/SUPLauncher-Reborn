using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace SUPLauncher_Reborn
{
    public partial class DupeManager : Form
    {
        public DupeManager()
        {
            InitializeComponent();
            this.AllowDrop = true;
            Opacity = 0;      //first the opacity is 0

            t1.Interval = 10;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start();
        }
        #region Fade
        /*
            Opacity = 0;      //first the opacity is 0

            t1.Interval = 10;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start(); 
         */
        System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();
        

        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
        }

        void fadeOut(object sender, EventArgs e)
        {
            if (Opacity <= 0)     //check if opacity is 0
            {
                t1.Stop();    //if it is, we stop the timer
                Close();   //and we try to close the form
            }
            else
                Opacity -= 0.05;
        }
        #endregion
        private TreeNode lastNode;
        private DirectoryInfo[] lastSubDirs;
        string copiedNode;
        string copiedNodeName;
        object selectedPath;
        bool isMouseOver = false;
        private Image refresh_img;
        private Image original_refreshimg;

        private void rotateInThread(Bitmap bm, float angle)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<Bitmap, float>(rotateInThread), new object[] { bm, angle });
            }
            refresh_img = RotateBitmap(bm, angle);
        }
        private void GetPointBounds(PointF[] points,
    out float xmin, out float xmax,
    out float ymin, out float ymax)
        {
            xmin = points[0].X;
            xmax = xmin;
            ymin = points[0].Y;
            ymax = ymin;
            foreach (PointF point in points)
            {
                if (xmin > point.X) xmin = point.X;
                if (xmax < point.X) xmax = point.X;
                if (ymin > point.Y) ymin = point.Y;
                if (ymax < point.Y) ymax = point.Y;
            }
        }

        private Bitmap RotateBitmap(Bitmap bm, float angle)
        {
            // Make a Matrix to represent rotation
            // by this angle.
            Matrix rotate_at_origin = new Matrix();
            rotate_at_origin.Rotate(angle);

            // Rotate the image's corners to see how big
            // it will be after rotation.
            PointF[] points =
            {
        new PointF(0, 0),
        new PointF(bm.Width, 0),
        new PointF(bm.Width, bm.Height),
        new PointF(0, bm.Height),
    };
            rotate_at_origin.TransformPoints(points);
            float xmin, xmax, ymin, ymax;
            GetPointBounds(points, out xmin, out xmax,
                out ymin, out ymax);

            // Make a bitmap to hold the rotated result.
            int wid = (int)Math.Round(xmax - xmin);
            int hgt = (int)Math.Round(ymax - ymin);
            Bitmap result = new Bitmap(wid, hgt);

            // Create the real rotation transformation.
            Matrix rotate_at_center = new Matrix();
            rotate_at_center.RotateAt(angle,
                new PointF(wid / 2f, hgt / 2f));

            // Draw the image onto the new bitmap rotated.
            using (Graphics gr = Graphics.FromImage(result))
            {
                // Use smooth image interpolation.
                gr.InterpolationMode = InterpolationMode.High;

                // Clear with the color in the image's upper left corner.
                gr.Clear(bm.GetPixel(0, 0));

                //// For debugging. (It's easier to see the background.)
                //gr.Clear(Color.LightBlue);

                // Set up the transformation to rotate.
                gr.Transform = rotate_at_center;

                // Draw the image centered on the bitmap.
                int x = (wid - bm.Width) / 2;
                int y = (hgt - bm.Height) / 2;
                gr.DrawImage(bm, x, y);
            }

            // Return the result bitmap.
            return result;
        }

        private void DupeManager_Load(object sender, EventArgs e) // Get nodes for the treeview
        {
            try
            {
                refresh_img = imgrefresh.Image;
                original_refreshimg = imgrefresh.Image;
                reloadFoldersAndFiles();
            }
            catch (Exception)
            {
                this.Visible = true;
            }
        }



        private void reloadFoldersAndFiles()
        {

            DirectoryInfo dInfo = new DirectoryInfo(Program.dupePath + @"\" + path.Text); // Directory info to see what directories we have to work with


            Dupes.Items.Clear(); // Make sure the listview has no items before loading these items below

            foreach (DirectoryInfo subDir in dInfo.GetDirectories())
            {
                ListViewItem newItem = Dupes.Items.Add(subDir.Name, 0);
                newItem.Tag = "folder";

            }

            foreach (FileInfo subDir in dInfo.GetFiles())
            {
                ListViewItem newItem = Dupes.Items.Add(subDir.Name, 1);

                newItem.Tag = "file";
            }

        }




        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete " + Dupes.SelectedItems[0].ToString() + "?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {

                File.Delete(Program.dupePath + path.Text + @"\" + Dupes.SelectedItems[0].Text);
                Dupes.Items.RemoveAt(Dupes.SelectedIndices[0]);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copiedNode = Program.dupePath + path.Text + @"\" + Dupes.SelectedItems[0].Text;
            copiedNodeName = Dupes.Text;
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (File.Exists(copiedNode.ToString()))
            {
                int i = 1;
                while (File.Exists(Program.dupePath + path.Text + @"\" + copiedNodeName + "(" + i + ")"))
                {
                    i = i + 1;

                }
                File.Copy(copiedNode.ToString(), Program.dupePath + path.Text + @"\" + copiedNodeName + "(" + i + ")");

            }
            else
            {
                try
                {
                    File.Copy(copiedNode.ToString(), Program.dupePath + path.Text + "/" + @"\" + copiedNode);
                }
                catch (Exception) // Stops errors popping up if the file does not exist anymore
                {

                }
            }

        }

        private void CreateNewFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String name = Interaction.InputBox("Folder name:", "Please enter folder name");
            Directory.CreateDirectory(Program.dupePath + Program.dupePath + path.Text + @"\" + copiedNode + name);

        }

        private void Dupes_MouseLeave(object sender, EventArgs e)
        {
            isMouseOver = false;
        }

        private void Dupes_MouseEnter(object sender, EventArgs e)
        {
            isMouseOver = true;
        }

        private void Dupes_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void NewFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {

            String filename = Interaction.InputBox("Folder Name", "Please enter folder name");
            if (Directory.Exists(Program.dupePath + path.Text + "/" + filename))
            {
                MessageBox.Show("Folder already exsists!", "SUPLauncher");
                return;
            }
            else
            {
                Directory.CreateDirectory(Program.dupePath + path.Text + @"\" + filename);
                reloadFoldersAndFiles();

            }
        }










        private void DupeManager_DragLeave(object sender, EventArgs e)
        {
            Drop.Visible = false;
        }
        private void DupeManager_DragDrop(object sender, DragEventArgs e)
        {
            String[] DupePath = (string[])e.Data.GetData(DataFormats.FileDrop);
            {
                foreach (String dupe in DupePath)
                {
                    if (Path.GetFileName(dupe).EndsWith(".txt"))
                    {
                        Drop.Visible = false;
                        File.Copy(dupe, Program.dupePath + Program.dupePath + path.Text + @"\" + Path.GetFileName(dupe));
                    }
                }

                Drop.Visible = false;
            }
        }

        private void Imgrefresh_Click(object sender, EventArgs e)
        {

            Dupes.Items.Clear();
            new Thread(() =>
            {
                int i = 0;
                while (i != 10)
                {
                    i = i + 1;
                    Thread.Sleep(70);
                    rotateInThread(new Bitmap(refresh_img), 90);
                    imgrefresh.Image = refresh_img;
                }

                imgrefresh.Image = original_refreshimg;
                return;
            }).Start();
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
                Point newPoint = TopBar.PointToScreen(new Point(e.X, e.Y));
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

        private void Dupes_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (Directory.Exists(Program.dupePath + path.Text + @"\" + Dupes.SelectedItems[0].Text))
            {
                history.Add(path.Text);
                if (path.Text[path.Text.Length - 1] == '/')
                {
                    path.Text = path.Text + Dupes.SelectedItems[0].Text;
                }
                else
                {
                    path.Text = path.Text + @"/" + Dupes.SelectedItems[0].Text;
                }

                reloadFoldersAndFiles();
            }
        }

        private void Dupes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            new Thread(() =>
            {
                int i = 0;
                while (i != 10)
                {
                    i = i + 1;
                    Thread.Sleep(70);
                    rotateInThread(new Bitmap(refresh_img), 90);
                    pictureBox1.Image = refresh_img;
                }

                pictureBox1.Image = original_refreshimg;
                return;
            }).Start();

            reloadFoldersAndFiles();
        }

        List<string> history = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            if (path.Text != "/")
            {
                string[] a = history.ToArray();

                path.Text = a[a.Length - 1];
                history.RemoveAt(a.Length - 1);
                reloadFoldersAndFiles();
            }
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = Import.ShowDialog();
            if (d != DialogResult.Cancel)
            {
                if (File.Exists(Import.FileName))
                {
                    if (File.Exists(Program.dupePath + path.Text + "/" + Import.SafeFileName) == false)
                    {
                        File.Copy(Import.FileName, Program.dupePath + path.Text + "/" + Import.SafeFileName);
                        reloadFoldersAndFiles();
                    }
                }
            }
        }

        private void FolderMenu_Opening(object sender, CancelEventArgs e)
        {
            if (Dupes.SelectedItems.Count < 1)
            {
                deleteFolderToolStripMenuItem.Enabled = false;
                renameToolStripMenuItem.Enabled = false;
            }
            else
            {
                deleteFolderToolStripMenuItem.Enabled = true;
                renameToolStripMenuItem.Enabled = true;
            }

            if (Dupes.SelectedItems.Count != 1)
            {
                renameToolStripMenuItem.Enabled = false;
            }
            else
            {
                renameToolStripMenuItem.Enabled = true;
            }

        }

        public void deleteFolder(string path)
        {
            DirectoryInfo dInfo = new DirectoryInfo(path); // Directory info to see what directories we have to work with


            foreach (FileInfo file in dInfo.GetFiles())
            {
                File.Delete(file.FullName);
            }

            foreach (DirectoryInfo folder in dInfo.GetDirectories())
            {
                deleteFolder(folder.FullName);
            }

            Directory.Delete(path);
            reloadFoldersAndFiles();

        }



        private void deleteFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Dupes.SelectedItems.Count > 0)
            {
                DialogResult d = MessageBox.Show("Are you sure you want to delete " + Dupes.SelectedItems.Count + " file(s)?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    foreach (ListViewItem item in Dupes.SelectedItems)
                    {
                        if (item.Tag == "folder")
                        {
                            deleteFolder(Program.dupePath + path.Text + "/" + item.Text);
                        }
                        else
                        {
                            File.Delete(Program.dupePath + path.Text + "/" + item.Text);
                        }
                    }
                }
            }
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Dupes.SelectedItems[0].Tag == "file")
            {

                String filename = Interaction.InputBox("New file name for '" + Dupes.SelectedItems[0].Text + "'. You do not need to include .txt at the end its done for you otherwise you may have problems loading in your dupe.", "Input File Name");

                if (!File.Exists(Program.dupePath + path.Text + "/" + filename))
                {
                    File.Move(Program.dupePath + path.Text + "/" + Dupes.SelectedItems[0].Text, Program.dupePath + path.Text + "/" + filename);
                    reloadFoldersAndFiles();
                }

            }
            else
            {
                String filename = Interaction.InputBox("New folder name for '" + Dupes.SelectedItems[0].Text + "'", "Input Folder Name");
                if (!Directory.Exists(Program.dupePath + path.Text + "/" + filename))
                {
                    Directory.Move(Program.dupePath + path.Text + "/" + Dupes.SelectedItems[0].Text, Program.dupePath + path.Text + "/" + filename);
                    reloadFoldersAndFiles();
                }
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(200, 14, 14, 14);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void DupeManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            t1 = new System.Windows.Forms.Timer();
            t1.Interval = 10;
            e.Cancel = true;    //cancel the event so the form won't be closed

            t1.Tick += new EventHandler(fadeOut);  //this calls the fade out function
            t1.Start();

            if (Opacity == 0)   //if the form is completly transparent
                e.Cancel = false;   //resume the event - the program can be closed


        }

        private void button4_Click(object sender, EventArgs e)
        {
            DupeMarketPlace form = new DupeMarketPlace();
            form.Show();
            form.TopMost = TopMost;
        }
    }
}
