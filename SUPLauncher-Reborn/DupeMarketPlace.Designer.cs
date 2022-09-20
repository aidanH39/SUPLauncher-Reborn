
namespace SUPLauncher_Reborn
{
    partial class DupeMarketPlace
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
            this.pnl_topBar = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.pnl_left = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_leftHead = new System.Windows.Forms.Panel();
            this.lbl_dupeMarket = new System.Windows.Forms.Label();
            this.lbl_superiorservers = new System.Windows.Forms.Label();
            this.img_supLogo = new System.Windows.Forms.PictureBox();
            this.pnl_ownedDupes = new System.Windows.Forms.Panel();
            this.lbl_ownedDupes = new System.Windows.Forms.Label();
            this.pnl_ownedDupesInd = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_browseDupes = new System.Windows.Forms.Label();
            this.pnl_BrowseDupesInd = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_publishedDupes = new System.Windows.Forms.Label();
            this.pnl_publishedDupeInd = new System.Windows.Forms.Panel();
            this.btn_uploadDupe = new System.Windows.Forms.Button();
            this.customTabControl1 = new SUPLauncher_Reborn.CustomTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnl_ownedDupesList = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_ownedDuoesTitle = new System.Windows.Forms.Label();
            this.browseDupes = new System.Windows.Forms.TabPage();
            this.pnl_ownedDupesTab = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.pnl_browsedupeList = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_browseDupesTitle = new System.Windows.Forms.Label();
            this.publishedDupes = new System.Windows.Forms.TabPage();
            this.pnl_publishedDupes = new System.Windows.Forms.Panel();
            this.pnl_publishedDupesList = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_publishedDupesTitle = new System.Windows.Forms.Label();
            this.combo_categories = new System.Windows.Forms.ComboBox();
            this.lbl_categories = new System.Windows.Forms.Label();
            this.pnl_topBar.SuspendLayout();
            this.pnl_left.SuspendLayout();
            this.pnl_leftHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_supLogo)).BeginInit();
            this.pnl_ownedDupes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.customTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.browseDupes.SuspendLayout();
            this.pnl_ownedDupesTab.SuspendLayout();
            this.publishedDupes.SuspendLayout();
            this.pnl_publishedDupes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_topBar
            // 
            this.pnl_topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.pnl_topBar.Controls.Add(this.lbl_title);
            this.pnl_topBar.Controls.Add(this.panel2);
            this.pnl_topBar.Controls.Add(this.btn_close);
            this.pnl_topBar.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnl_topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_topBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_topBar.Name = "pnl_topBar";
            this.pnl_topBar.Size = new System.Drawing.Size(706, 28);
            this.pnl_topBar.TabIndex = 33;
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
            this.lbl_title.Size = new System.Drawing.Size(136, 19);
            this.lbl_title.TabIndex = 58;
            this.lbl_title.Text = "Dupe Marketplace";
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
            this.btn_close.Location = new System.Drawing.Point(667, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(39, 28);
            this.btn_close.TabIndex = 55;
            this.btn_close.Text = "";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.button3_Click);
            // 
            // pnl_left
            // 
            this.pnl_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.pnl_left.Controls.Add(this.pnl_leftHead);
            this.pnl_left.Controls.Add(this.pnl_ownedDupes);
            this.pnl_left.Controls.Add(this.panel1);
            this.pnl_left.Controls.Add(this.panel5);
            this.pnl_left.Controls.Add(this.btn_uploadDupe);
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnl_left.Location = new System.Drawing.Point(0, 28);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(208, 610);
            this.pnl_left.TabIndex = 34;
            // 
            // pnl_leftHead
            // 
            this.pnl_leftHead.Controls.Add(this.lbl_dupeMarket);
            this.pnl_leftHead.Controls.Add(this.lbl_superiorservers);
            this.pnl_leftHead.Controls.Add(this.img_supLogo);
            this.pnl_leftHead.Location = new System.Drawing.Point(3, 3);
            this.pnl_leftHead.Name = "pnl_leftHead";
            this.pnl_leftHead.Size = new System.Drawing.Size(211, 60);
            this.pnl_leftHead.TabIndex = 0;
            // 
            // lbl_dupeMarket
            // 
            this.lbl_dupeMarket.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dupeMarket.ForeColor = System.Drawing.Color.White;
            this.lbl_dupeMarket.Location = new System.Drawing.Point(57, 23);
            this.lbl_dupeMarket.Name = "lbl_dupeMarket";
            this.lbl_dupeMarket.Size = new System.Drawing.Size(154, 27);
            this.lbl_dupeMarket.TabIndex = 2;
            this.lbl_dupeMarket.Text = "Dupe MarketPlace";
            // 
            // lbl_superiorservers
            // 
            this.lbl_superiorservers.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_superiorservers.ForeColor = System.Drawing.Color.White;
            this.lbl_superiorservers.Location = new System.Drawing.Point(57, 5);
            this.lbl_superiorservers.Name = "lbl_superiorservers";
            this.lbl_superiorservers.Size = new System.Drawing.Size(154, 23);
            this.lbl_superiorservers.TabIndex = 1;
            this.lbl_superiorservers.Text = "SuperiorServers";
            // 
            // img_supLogo
            // 
            this.img_supLogo.Image = global::SUPLauncher_Reborn.Properties.Resources.textless_logo;
            this.img_supLogo.Location = new System.Drawing.Point(0, 5);
            this.img_supLogo.Name = "img_supLogo";
            this.img_supLogo.Size = new System.Drawing.Size(54, 45);
            this.img_supLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_supLogo.TabIndex = 0;
            this.img_supLogo.TabStop = false;
            // 
            // pnl_ownedDupes
            // 
            this.pnl_ownedDupes.Controls.Add(this.lbl_ownedDupes);
            this.pnl_ownedDupes.Controls.Add(this.pnl_ownedDupesInd);
            this.pnl_ownedDupes.Location = new System.Drawing.Point(3, 69);
            this.pnl_ownedDupes.Name = "pnl_ownedDupes";
            this.pnl_ownedDupes.Size = new System.Drawing.Size(211, 50);
            this.pnl_ownedDupes.TabIndex = 1;
            this.pnl_ownedDupes.Click += new System.EventHandler(this.pnl_ownedDupes_Click);
            // 
            // lbl_ownedDupes
            // 
            this.lbl_ownedDupes.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ownedDupes.ForeColor = System.Drawing.Color.White;
            this.lbl_ownedDupes.Location = new System.Drawing.Point(11, 0);
            this.lbl_ownedDupes.Name = "lbl_ownedDupes";
            this.lbl_ownedDupes.Size = new System.Drawing.Size(197, 50);
            this.lbl_ownedDupes.TabIndex = 1;
            this.lbl_ownedDupes.Text = "Owned Dupes";
            this.lbl_ownedDupes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_ownedDupes.Click += new System.EventHandler(this.pnl_ownedDupes_Click);
            // 
            // pnl_ownedDupesInd
            // 
            this.pnl_ownedDupesInd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(129)))), ((int)(((byte)(255)))));
            this.pnl_ownedDupesInd.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_ownedDupesInd.Location = new System.Drawing.Point(0, 0);
            this.pnl_ownedDupesInd.Name = "pnl_ownedDupesInd";
            this.pnl_ownedDupesInd.Size = new System.Drawing.Size(5, 50);
            this.pnl_ownedDupesInd.TabIndex = 0;
            this.pnl_ownedDupesInd.Click += new System.EventHandler(this.pnl_ownedDupes_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_browseDupes);
            this.panel1.Controls.Add(this.pnl_BrowseDupesInd);
            this.panel1.Location = new System.Drawing.Point(3, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 50);
            this.panel1.TabIndex = 2;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // lbl_browseDupes
            // 
            this.lbl_browseDupes.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_browseDupes.ForeColor = System.Drawing.Color.White;
            this.lbl_browseDupes.Location = new System.Drawing.Point(11, 0);
            this.lbl_browseDupes.Name = "lbl_browseDupes";
            this.lbl_browseDupes.Size = new System.Drawing.Size(197, 50);
            this.lbl_browseDupes.TabIndex = 1;
            this.lbl_browseDupes.Text = "Browse Dupes";
            this.lbl_browseDupes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_browseDupes.Click += new System.EventHandler(this.panel1_Click);
            // 
            // pnl_BrowseDupesInd
            // 
            this.pnl_BrowseDupesInd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.pnl_BrowseDupesInd.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_BrowseDupesInd.Location = new System.Drawing.Point(0, 0);
            this.pnl_BrowseDupesInd.Name = "pnl_BrowseDupesInd";
            this.pnl_BrowseDupesInd.Size = new System.Drawing.Size(5, 50);
            this.pnl_BrowseDupesInd.TabIndex = 0;
            this.pnl_BrowseDupesInd.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbl_publishedDupes);
            this.panel5.Controls.Add(this.pnl_publishedDupeInd);
            this.panel5.Location = new System.Drawing.Point(3, 181);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(211, 50);
            this.panel5.TabIndex = 3;
            this.panel5.Click += new System.EventHandler(this.panel5_Click);
            // 
            // lbl_publishedDupes
            // 
            this.lbl_publishedDupes.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_publishedDupes.ForeColor = System.Drawing.Color.White;
            this.lbl_publishedDupes.Location = new System.Drawing.Point(11, 0);
            this.lbl_publishedDupes.Name = "lbl_publishedDupes";
            this.lbl_publishedDupes.Size = new System.Drawing.Size(197, 50);
            this.lbl_publishedDupes.TabIndex = 1;
            this.lbl_publishedDupes.Text = "Your published dupes";
            this.lbl_publishedDupes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_publishedDupes.Click += new System.EventHandler(this.panel5_Click);
            // 
            // pnl_publishedDupeInd
            // 
            this.pnl_publishedDupeInd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.pnl_publishedDupeInd.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_publishedDupeInd.Location = new System.Drawing.Point(0, 0);
            this.pnl_publishedDupeInd.Name = "pnl_publishedDupeInd";
            this.pnl_publishedDupeInd.Size = new System.Drawing.Size(5, 50);
            this.pnl_publishedDupeInd.TabIndex = 0;
            this.pnl_publishedDupeInd.Click += new System.EventHandler(this.panel5_Click);
            // 
            // btn_uploadDupe
            // 
            this.btn_uploadDupe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btn_uploadDupe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_uploadDupe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_uploadDupe.ForeColor = System.Drawing.Color.White;
            this.btn_uploadDupe.Location = new System.Drawing.Point(3, 237);
            this.btn_uploadDupe.Name = "btn_uploadDupe";
            this.btn_uploadDupe.Size = new System.Drawing.Size(200, 33);
            this.btn_uploadDupe.TabIndex = 7;
            this.btn_uploadDupe.Text = "Upload Dupe";
            this.btn_uploadDupe.UseVisualStyleBackColor = false;
            this.btn_uploadDupe.Click += new System.EventHandler(this.btn_lookup_Click);
            // 
            // customTabControl1
            // 
            this.customTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customTabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.customTabControl1.Controls.Add(this.tabPage1);
            this.customTabControl1.Controls.Add(this.browseDupes);
            this.customTabControl1.Controls.Add(this.publishedDupes);
            this.customTabControl1.ItemSize = new System.Drawing.Size(20, 10);
            this.customTabControl1.Location = new System.Drawing.Point(212, 84);
            this.customTabControl1.Multiline = true;
            this.customTabControl1.Name = "customTabControl1";
            this.customTabControl1.SelectedIndex = 0;
            this.customTabControl1.Size = new System.Drawing.Size(477, 542);
            this.customTabControl1.TabIndex = 35;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::SUPLauncher_Reborn.Properties.Resources.background;
            this.tabPage1.Controls.Add(this.pnl_ownedDupesList);
            this.tabPage1.Controls.Add(this.lbl_ownedDuoesTitle);
            this.tabPage1.Location = new System.Drawing.Point(4, 14);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(469, 524);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "ownedDupes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnl_ownedDupesList
            // 
            this.pnl_ownedDupesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_ownedDupesList.AutoScroll = true;
            this.pnl_ownedDupesList.BackColor = System.Drawing.Color.Transparent;
            this.pnl_ownedDupesList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnl_ownedDupesList.Location = new System.Drawing.Point(7, 67);
            this.pnl_ownedDupesList.Name = "pnl_ownedDupesList";
            this.pnl_ownedDupesList.Size = new System.Drawing.Size(459, 474);
            this.pnl_ownedDupesList.TabIndex = 2;
            this.pnl_ownedDupesList.WrapContents = false;
            // 
            // lbl_ownedDuoesTitle
            // 
            this.lbl_ownedDuoesTitle.AutoSize = true;
            this.lbl_ownedDuoesTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ownedDuoesTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ownedDuoesTitle.ForeColor = System.Drawing.Color.White;
            this.lbl_ownedDuoesTitle.Location = new System.Drawing.Point(13, 19);
            this.lbl_ownedDuoesTitle.Name = "lbl_ownedDuoesTitle";
            this.lbl_ownedDuoesTitle.Size = new System.Drawing.Size(217, 28);
            this.lbl_ownedDuoesTitle.TabIndex = 1;
            this.lbl_ownedDuoesTitle.Text = "Your Owned Dupes";
            // 
            // browseDupes
            // 
            this.browseDupes.BackColor = System.Drawing.Color.Transparent;
            this.browseDupes.BackgroundImage = global::SUPLauncher_Reborn.Properties.Resources.background;
            this.browseDupes.Controls.Add(this.pnl_ownedDupesTab);
            this.browseDupes.Location = new System.Drawing.Point(4, 14);
            this.browseDupes.Name = "browseDupes";
            this.browseDupes.Padding = new System.Windows.Forms.Padding(3);
            this.browseDupes.Size = new System.Drawing.Size(469, 524);
            this.browseDupes.TabIndex = 0;
            this.browseDupes.Text = "browseDupes";
            // 
            // pnl_ownedDupesTab
            // 
            this.pnl_ownedDupesTab.BackColor = System.Drawing.Color.Transparent;
            this.pnl_ownedDupesTab.Controls.Add(this.btn_search);
            this.pnl_ownedDupesTab.Controls.Add(this.txt_search);
            this.pnl_ownedDupesTab.Controls.Add(this.pnl_browsedupeList);
            this.pnl_ownedDupesTab.Controls.Add(this.lbl_browseDupesTitle);
            this.pnl_ownedDupesTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_ownedDupesTab.Location = new System.Drawing.Point(3, 3);
            this.pnl_ownedDupesTab.Name = "pnl_ownedDupesTab";
            this.pnl_ownedDupesTab.Size = new System.Drawing.Size(463, 518);
            this.pnl_ownedDupesTab.TabIndex = 35;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btn_search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(228, 50);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(78, 21);
            this.btn_search.TabIndex = 37;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_search.ForeColor = System.Drawing.Color.White;
            this.txt_search.Location = new System.Drawing.Point(4, 50);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(218, 20);
            this.txt_search.TabIndex = 36;
            this.txt_search.Text = "Search";
            // 
            // pnl_browsedupeList
            // 
            this.pnl_browsedupeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_browsedupeList.AutoScroll = true;
            this.pnl_browsedupeList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnl_browsedupeList.Location = new System.Drawing.Point(4, 75);
            this.pnl_browsedupeList.Name = "pnl_browsedupeList";
            this.pnl_browsedupeList.Size = new System.Drawing.Size(456, 440);
            this.pnl_browsedupeList.TabIndex = 1;
            this.pnl_browsedupeList.WrapContents = false;
            // 
            // lbl_browseDupesTitle
            // 
            this.lbl_browseDupesTitle.AutoSize = true;
            this.lbl_browseDupesTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_browseDupesTitle.ForeColor = System.Drawing.Color.White;
            this.lbl_browseDupesTitle.Location = new System.Drawing.Point(0, 19);
            this.lbl_browseDupesTitle.Name = "lbl_browseDupesTitle";
            this.lbl_browseDupesTitle.Size = new System.Drawing.Size(162, 28);
            this.lbl_browseDupesTitle.TabIndex = 0;
            this.lbl_browseDupesTitle.Text = "Browse Dupes";
            // 
            // publishedDupes
            // 
            this.publishedDupes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.publishedDupes.BackgroundImage = global::SUPLauncher_Reborn.Properties.Resources.background;
            this.publishedDupes.Controls.Add(this.pnl_publishedDupes);
            this.publishedDupes.Location = new System.Drawing.Point(4, 14);
            this.publishedDupes.Name = "publishedDupes";
            this.publishedDupes.Padding = new System.Windows.Forms.Padding(3);
            this.publishedDupes.Size = new System.Drawing.Size(469, 524);
            this.publishedDupes.TabIndex = 1;
            this.publishedDupes.Text = "publishedDupes";
            // 
            // pnl_publishedDupes
            // 
            this.pnl_publishedDupes.BackColor = System.Drawing.Color.Transparent;
            this.pnl_publishedDupes.Controls.Add(this.pnl_publishedDupesList);
            this.pnl_publishedDupes.Controls.Add(this.lbl_publishedDupesTitle);
            this.pnl_publishedDupes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_publishedDupes.Location = new System.Drawing.Point(3, 3);
            this.pnl_publishedDupes.Name = "pnl_publishedDupes";
            this.pnl_publishedDupes.Size = new System.Drawing.Size(463, 518);
            this.pnl_publishedDupes.TabIndex = 35;
            // 
            // pnl_publishedDupesList
            // 
            this.pnl_publishedDupesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_publishedDupesList.AutoScroll = true;
            this.pnl_publishedDupesList.AutoScrollMinSize = new System.Drawing.Size(1, 0);
            this.pnl_publishedDupesList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnl_publishedDupesList.Location = new System.Drawing.Point(3, 54);
            this.pnl_publishedDupesList.Name = "pnl_publishedDupesList";
            this.pnl_publishedDupesList.Size = new System.Drawing.Size(457, 461);
            this.pnl_publishedDupesList.TabIndex = 1;
            this.pnl_publishedDupesList.WrapContents = false;
            // 
            // lbl_publishedDupesTitle
            // 
            this.lbl_publishedDupesTitle.AutoSize = true;
            this.lbl_publishedDupesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_publishedDupesTitle.ForeColor = System.Drawing.Color.White;
            this.lbl_publishedDupesTitle.Location = new System.Drawing.Point(12, 18);
            this.lbl_publishedDupesTitle.Name = "lbl_publishedDupesTitle";
            this.lbl_publishedDupesTitle.Size = new System.Drawing.Size(219, 24);
            this.lbl_publishedDupesTitle.TabIndex = 0;
            this.lbl_publishedDupesTitle.Text = "Your Published Dupes";
            // 
            // combo_categories
            // 
            this.combo_categories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.combo_categories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_categories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_categories.ForeColor = System.Drawing.Color.White;
            this.combo_categories.FormattingEnabled = true;
            this.combo_categories.Items.AddRange(new object[] {
            "Any"});
            this.combo_categories.Location = new System.Drawing.Point(535, 130);
            this.combo_categories.Name = "combo_categories";
            this.combo_categories.Size = new System.Drawing.Size(140, 21);
            this.combo_categories.TabIndex = 3;
            this.combo_categories.SelectedIndexChanged += new System.EventHandler(this.combo_categories_SelectedIndexChanged);
            // 
            // lbl_categories
            // 
            this.lbl_categories.AutoSize = true;
            this.lbl_categories.BackColor = System.Drawing.Color.Transparent;
            this.lbl_categories.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categories.ForeColor = System.Drawing.Color.White;
            this.lbl_categories.Location = new System.Drawing.Point(531, 105);
            this.lbl_categories.Name = "lbl_categories";
            this.lbl_categories.Size = new System.Drawing.Size(65, 19);
            this.lbl_categories.TabIndex = 4;
            this.lbl_categories.Text = "Category";
            // 
            // DupeMarketPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SUPLauncher_Reborn.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(706, 638);
            this.Controls.Add(this.lbl_categories);
            this.Controls.Add(this.combo_categories);
            this.Controls.Add(this.pnl_left);
            this.Controls.Add(this.pnl_topBar);
            this.Controls.Add(this.customTabControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(706, 638);
            this.Name = "DupeMarketPlace";
            this.Text = "DupeMarketPlace";
            this.Load += new System.EventHandler(this.DupeMarketPlace_Load);
            this.pnl_topBar.ResumeLayout(false);
            this.pnl_topBar.PerformLayout();
            this.pnl_left.ResumeLayout(false);
            this.pnl_leftHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_supLogo)).EndInit();
            this.pnl_ownedDupes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.customTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.browseDupes.ResumeLayout(false);
            this.pnl_ownedDupesTab.ResumeLayout(false);
            this.pnl_ownedDupesTab.PerformLayout();
            this.publishedDupes.ResumeLayout(false);
            this.pnl_publishedDupes.ResumeLayout(false);
            this.pnl_publishedDupes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_topBar;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.FlowLayoutPanel pnl_left;
        private System.Windows.Forms.Panel pnl_leftHead;
        private System.Windows.Forms.Label lbl_dupeMarket;
        private System.Windows.Forms.Label lbl_superiorservers;
        private System.Windows.Forms.PictureBox img_supLogo;
        private System.Windows.Forms.Panel pnl_ownedDupes;
        private System.Windows.Forms.Label lbl_ownedDupes;
        private System.Windows.Forms.Panel pnl_ownedDupesInd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_browseDupes;
        private System.Windows.Forms.Panel pnl_BrowseDupesInd;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_publishedDupes;
        private System.Windows.Forms.Panel pnl_publishedDupeInd;
        private CustomTabControl customTabControl1;
        private System.Windows.Forms.TabPage browseDupes;
        private System.Windows.Forms.TabPage publishedDupes;
        private System.Windows.Forms.Panel pnl_ownedDupesTab;
        private System.Windows.Forms.FlowLayoutPanel pnl_browsedupeList;
        private System.Windows.Forms.Label lbl_browseDupesTitle;
        private DupeDisplay dupeDisplay1;
        private DupeDisplay dupeDisplay2;
        private DupeDisplay dupeDisplay3;
        private DupeDisplay dupeDisplay4;
        private DupeDisplay dupeDisplay5;
        private System.Windows.Forms.Panel pnl_publishedDupes;
        private System.Windows.Forms.FlowLayoutPanel pnl_publishedDupesList;
        private System.Windows.Forms.Label lbl_publishedDupesTitle;
        private System.Windows.Forms.Button btn_uploadDupe;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel pnl_ownedDupesList;
        private System.Windows.Forms.Label lbl_ownedDuoesTitle;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_categories;
        private System.Windows.Forms.ComboBox combo_categories;
    }
}