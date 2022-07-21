namespace SUPLauncher
{
    partial class DupeManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DupeManager));
            this.FolderMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Import = new System.Windows.Forms.OpenFileDialog();
            this.TopBar = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Drop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.imgrefresh = new System.Windows.Forms.PictureBox();
            this.Dupes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.path = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FolderMenu.SuspendLayout();
            this.TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Drop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgrefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FolderMenu
            // 
            this.FolderMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFolderToolStripMenuItem,
            this.importToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteFolderToolStripMenuItem,
            this.renameToolStripMenuItem});
            this.FolderMenu.Name = "FolderMenu";
            this.FolderMenu.Size = new System.Drawing.Size(142, 98);
            this.FolderMenu.Opening += new System.ComponentModel.CancelEventHandler(this.FolderMenu_Opening);
            // 
            // newFolderToolStripMenuItem
            // 
            this.newFolderToolStripMenuItem.Name = "newFolderToolStripMenuItem";
            this.newFolderToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.newFolderToolStripMenuItem.Text = "New Folder";
            this.newFolderToolStripMenuItem.Click += new System.EventHandler(this.NewFolderToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.importToolStripMenuItem.Text = "Import Dupe";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            // 
            // deleteFolderToolStripMenuItem
            // 
            this.deleteFolderToolStripMenuItem.Name = "deleteFolderToolStripMenuItem";
            this.deleteFolderToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.deleteFolderToolStripMenuItem.Text = "Delete";
            this.deleteFolderToolStripMenuItem.Click += new System.EventHandler(this.deleteFolderToolStripMenuItem_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // Import
            // 
            this.Import.FileName = "Import";
            this.Import.Multiselect = true;
            this.Import.Title = "Select a dupe to import...";
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.TopBar.Controls.Add(this.pictureBox2);
            this.TopBar.Controls.Add(this.button3);
            this.TopBar.Controls.Add(this.button2);
            this.TopBar.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(557, 28);
            this.TopBar.TabIndex = 32;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            this.TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseMove);
            this.TopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SUPLauncher.Properties.Resources.suplogo;
            this.pictureBox2.Location = new System.Drawing.Point(5, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 56;
            this.pictureBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(512, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 28);
            this.button3.TabIndex = 55;
            this.button3.Text = "";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(758, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 22);
            this.button2.TabIndex = 52;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Drop
            // 
            this.Drop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.Drop.Controls.Add(this.label1);
            this.Drop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Drop.Location = new System.Drawing.Point(0, 569);
            this.Drop.Name = "Drop";
            this.Drop.Size = new System.Drawing.Size(557, 54);
            this.Drop.TabIndex = 33;
            this.Drop.Visible = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "DROP TO IMPORT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgrefresh
            // 
            this.imgrefresh.BackColor = System.Drawing.Color.Transparent;
            this.imgrefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgrefresh.Image = ((System.Drawing.Image)(resources.GetObject("imgrefresh.Image")));
            this.imgrefresh.Location = new System.Drawing.Point(732, 44);
            this.imgrefresh.Name = "imgrefresh";
            this.imgrefresh.Size = new System.Drawing.Size(17, 20);
            this.imgrefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgrefresh.TabIndex = 49;
            this.imgrefresh.TabStop = false;
            this.imgrefresh.Click += new System.EventHandler(this.Imgrefresh_Click);
            // 
            // Dupes
            // 
            this.Dupes.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.Dupes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Dupes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dupes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.Dupes.ContextMenuStrip = this.FolderMenu;
            this.Dupes.ForeColor = System.Drawing.Color.White;
            this.Dupes.HideSelection = false;
            this.Dupes.LargeImageList = this.iconList;
            this.Dupes.Location = new System.Drawing.Point(12, 66);
            this.Dupes.Name = "Dupes";
            this.Dupes.Size = new System.Drawing.Size(533, 500);
            this.Dupes.TabIndex = 50;
            this.Dupes.UseCompatibleStateImageBehavior = false;
            this.Dupes.SelectedIndexChanged += new System.EventHandler(this.Dupes_SelectedIndexChanged);
            this.Dupes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Dupes_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Dupe Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "File Size";
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.White;
            this.iconList.Images.SetKeyName(0, "folder");
            this.iconList.Images.SetKeyName(1, "txt.png");
            // 
            // path
            // 
            this.path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.path.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.path.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.path.ForeColor = System.Drawing.Color.White;
            this.path.Location = new System.Drawing.Point(75, 43);
            this.path.Multiline = true;
            this.path.Name = "path";
            this.path.ReadOnly = true;
            this.path.Size = new System.Drawing.Size(470, 23);
            this.path.TabIndex = 51;
            this.path.Text = "/";
            this.path.WordWrap = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel1.Location = new System.Drawing.Point(63, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(77, 23);
            this.panel1.TabIndex = 52;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(13, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 53;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // DupeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(557, 623);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.path);
            this.Controls.Add(this.Dupes);
            this.Controls.Add(this.imgrefresh);
            this.Controls.Add(this.Drop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TopBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DupeManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DupeManager_FormClosing);
            this.Load += new System.EventHandler(this.DupeManager_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.DupeManager_DragDrop);
            this.DragLeave += new System.EventHandler(this.DupeManager_DragLeave);
            this.FolderMenu.ResumeLayout(false);
            this.TopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Drop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgrefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip FolderMenu;
        private System.Windows.Forms.ToolStripMenuItem newFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteFolderToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog Import;
        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Panel Drop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgrefresh;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView Dupes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
    }
}