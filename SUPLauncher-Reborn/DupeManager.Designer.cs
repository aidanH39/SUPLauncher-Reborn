namespace SUPLauncher_Reborn
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
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.strip_uploadToMarket = new System.Windows.Forms.ToolStripMenuItem();
            this.Import = new System.Windows.Forms.OpenFileDialog();
            this.pnl_topBar = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Drop = new System.Windows.Forms.Panel();
            this.lbl_dropToImport = new System.Windows.Forms.Label();
            this.imgrefresh = new System.Windows.Forms.PictureBox();
            this.listview_dupes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.txt_path = new System.Windows.Forms.TextBox();
            this.pnl_randomPanel = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.PictureBox();
            this.btn_marketPlace = new System.Windows.Forms.Button();
            this.FolderMenu.SuspendLayout();
            this.pnl_topBar.SuspendLayout();
            this.Drop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgrefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_refresh)).BeginInit();
            this.SuspendLayout();
            // 
            // FolderMenu
            // 
            this.FolderMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFolderToolStripMenuItem,
            this.importToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteFolderToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.toolStripSeparator2,
            this.strip_uploadToMarket});
            this.FolderMenu.Name = "FolderMenu";
            this.FolderMenu.Size = new System.Drawing.Size(227, 126);
            this.FolderMenu.Opening += new System.ComponentModel.CancelEventHandler(this.FolderMenu_Opening);
            // 
            // newFolderToolStripMenuItem
            // 
            this.newFolderToolStripMenuItem.Name = "newFolderToolStripMenuItem";
            this.newFolderToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.newFolderToolStripMenuItem.Text = "New Folder";
            this.newFolderToolStripMenuItem.Click += new System.EventHandler(this.NewFolderToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.importToolStripMenuItem.Text = "Import Dupe";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(223, 6);
            // 
            // deleteFolderToolStripMenuItem
            // 
            this.deleteFolderToolStripMenuItem.Name = "deleteFolderToolStripMenuItem";
            this.deleteFolderToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.deleteFolderToolStripMenuItem.Text = "Delete";
            this.deleteFolderToolStripMenuItem.Click += new System.EventHandler(this.deleteFolderToolStripMenuItem_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(223, 6);
            // 
            // strip_uploadToMarket
            // 
            this.strip_uploadToMarket.Name = "strip_uploadToMarket";
            this.strip_uploadToMarket.Size = new System.Drawing.Size(226, 22);
            this.strip_uploadToMarket.Text = "Upload Dupe To MarketPlace";
            this.strip_uploadToMarket.Click += new System.EventHandler(this.uploadDupeToMarketPlaceToolStripMenuItem_Click);
            // 
            // Import
            // 
            this.Import.FileName = "Import";
            this.Import.Multiselect = true;
            this.Import.Title = "Select a dupe to import...";
            // 
            // pnl_topBar
            // 
            this.pnl_topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.pnl_topBar.Controls.Add(this.lbl_title);
            this.pnl_topBar.Controls.Add(this.panel2);
            this.pnl_topBar.Controls.Add(this.btn_close);
            this.pnl_topBar.Controls.Add(this.button2);
            this.pnl_topBar.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnl_topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_topBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_topBar.Name = "pnl_topBar";
            this.pnl_topBar.Size = new System.Drawing.Size(557, 28);
            this.pnl_topBar.TabIndex = 32;
            this.pnl_topBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            this.pnl_topBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseMove);
            this.pnl_topBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseUp);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(10, 4);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(112, 19);
            this.lbl_title.TabIndex = 58;
            this.lbl_title.Text = "Dupe Manager";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(129)))), ((int)(((byte)(255)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 28);
            this.panel2.TabIndex = 57;
            // 
            // btn_close
            // 
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(512, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(45, 28);
            this.btn_close.TabIndex = 55;
            this.btn_close.Text = "";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.button3_Click);
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
            this.Drop.Controls.Add(this.lbl_dropToImport);
            this.Drop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Drop.Location = new System.Drawing.Point(0, 569);
            this.Drop.Name = "Drop";
            this.Drop.Size = new System.Drawing.Size(557, 54);
            this.Drop.TabIndex = 33;
            this.Drop.Visible = false;
            // 
            // lbl_dropToImport
            // 
            this.lbl_dropToImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_dropToImport.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dropToImport.ForeColor = System.Drawing.Color.White;
            this.lbl_dropToImport.Location = new System.Drawing.Point(0, 0);
            this.lbl_dropToImport.Name = "lbl_dropToImport";
            this.lbl_dropToImport.Size = new System.Drawing.Size(557, 54);
            this.lbl_dropToImport.TabIndex = 0;
            this.lbl_dropToImport.Text = "DROP TO IMPORT";
            this.lbl_dropToImport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // listview_dupes
            // 
            this.listview_dupes.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listview_dupes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.listview_dupes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listview_dupes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listview_dupes.ContextMenuStrip = this.FolderMenu;
            this.listview_dupes.ForeColor = System.Drawing.Color.White;
            this.listview_dupes.HideSelection = false;
            this.listview_dupes.LargeImageList = this.iconList;
            this.listview_dupes.Location = new System.Drawing.Point(12, 82);
            this.listview_dupes.Name = "listview_dupes";
            this.listview_dupes.Size = new System.Drawing.Size(533, 484);
            this.listview_dupes.TabIndex = 50;
            this.listview_dupes.UseCompatibleStateImageBehavior = false;
            this.listview_dupes.SelectedIndexChanged += new System.EventHandler(this.Dupes_SelectedIndexChanged);
            this.listview_dupes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Dupes_MouseDoubleClick);
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
            // txt_path
            // 
            this.txt_path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.txt_path.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_path.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_path.ForeColor = System.Drawing.Color.White;
            this.txt_path.Location = new System.Drawing.Point(211, 43);
            this.txt_path.Multiline = true;
            this.txt_path.Name = "txt_path";
            this.txt_path.ReadOnly = true;
            this.txt_path.Size = new System.Drawing.Size(334, 23);
            this.txt_path.TabIndex = 51;
            this.txt_path.Text = "/";
            this.txt_path.WordWrap = false;
            // 
            // pnl_randomPanel
            // 
            this.pnl_randomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.pnl_randomPanel.Location = new System.Drawing.Point(201, 43);
            this.pnl_randomPanel.Name = "pnl_randomPanel";
            this.pnl_randomPanel.Size = new System.Drawing.Size(77, 23);
            this.pnl_randomPanel.TabIndex = 52;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(13, 41);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(27, 23);
            this.btn_back.TabIndex = 53;
            this.btn_back.Text = "<";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Transparent;
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.Location = new System.Drawing.Point(40, 46);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(16, 16);
            this.btn_refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_refresh.TabIndex = 54;
            this.btn_refresh.TabStop = false;
            this.btn_refresh.Click += new System.EventHandler(this.pictureBox1_Click);
            this.btn_refresh.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.btn_refresh.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // btn_marketPlace
            // 
            this.btn_marketPlace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btn_marketPlace.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.btn_marketPlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_marketPlace.ForeColor = System.Drawing.Color.White;
            this.btn_marketPlace.Location = new System.Drawing.Point(62, 43);
            this.btn_marketPlace.Name = "btn_marketPlace";
            this.btn_marketPlace.Size = new System.Drawing.Size(133, 23);
            this.btn_marketPlace.TabIndex = 55;
            this.btn_marketPlace.Text = "Marketplace";
            this.btn_marketPlace.UseVisualStyleBackColor = false;
            this.btn_marketPlace.Click += new System.EventHandler(this.button4_Click);
            // 
            // DupeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(557, 623);
            this.ControlBox = false;
            this.Controls.Add(this.btn_marketPlace);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.listview_dupes);
            this.Controls.Add(this.imgrefresh);
            this.Controls.Add(this.Drop);
            this.Controls.Add(this.pnl_randomPanel);
            this.Controls.Add(this.pnl_topBar);
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
            this.pnl_topBar.ResumeLayout(false);
            this.pnl_topBar.PerformLayout();
            this.Drop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgrefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_refresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip FolderMenu;
        private System.Windows.Forms.ToolStripMenuItem newFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteFolderToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog Import;
        private System.Windows.Forms.Panel pnl_topBar;
        private System.Windows.Forms.Panel Drop;
        private System.Windows.Forms.Label lbl_dropToImport;
        private System.Windows.Forms.PictureBox imgrefresh;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listview_dupes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.Panel pnl_randomPanel;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.PictureBox btn_refresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_marketPlace;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem strip_uploadToMarket;
    }
}