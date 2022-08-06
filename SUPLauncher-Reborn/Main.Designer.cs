
namespace SUPLauncher_Reborn
{
    partial class frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.pnl_topBar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.img_icon = new System.Windows.Forms.PictureBox();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_afkMode = new System.Windows.Forms.CheckBox();
            this.pnl_afkHead = new System.Windows.Forms.Panel();
            this.lbl_afk = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.img_warning = new System.Windows.Forms.PictureBox();
            this.btn_settings = new System.Windows.Forms.PictureBox();
            this.btn_lookup = new System.Windows.Forms.Button();
            this.pnl_lookup = new System.Windows.Forms.Panel();
            this.lbl_lookup = new System.Windows.Forms.Label();
            this.pnl_4 = new System.Windows.Forms.Panel();
            this.txt_lookup = new System.Windows.Forms.TextBox();
            this.lbl_server = new System.Windows.Forms.Label();
            this.lbl_playerName = new System.Windows.Forms.Label();
            this.lbl_version = new System.Windows.Forms.Label();
            this.pnl_servers = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_progress = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tip_afk = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.cProgressBar1 = new SUPLauncher_Reborn.CProgressBar();
            this.img_avatar = new OvalPictureBox();
            this.pnl_topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_icon)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnl_afkHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_warning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_settings)).BeginInit();
            this.pnl_lookup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_topBar
            // 
            this.pnl_topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pnl_topBar.Controls.Add(this.panel2);
            this.pnl_topBar.Controls.Add(this.lbl_title);
            this.pnl_topBar.Controls.Add(this.img_icon);
            this.pnl_topBar.Controls.Add(this.btn_minimize);
            this.pnl_topBar.Controls.Add(this.btn_close);
            this.pnl_topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_topBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_topBar.Name = "pnl_topBar";
            this.pnl_topBar.Size = new System.Drawing.Size(580, 35);
            this.pnl_topBar.TabIndex = 0;
            this.pnl_topBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            this.pnl_topBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseMove);
            this.pnl_topBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(129)))), ((int)(((byte)(255)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 35);
            this.panel2.TabIndex = 58;
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(44, 4);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(116, 26);
            this.lbl_title.TabIndex = 3;
            this.lbl_title.Text = "SUPLauncher";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // img_icon
            // 
            this.img_icon.Image = global::SUPLauncher_Reborn.Properties.Resources.textless_logo;
            this.img_icon.Location = new System.Drawing.Point(9, 1);
            this.img_icon.Name = "img_icon";
            this.img_icon.Size = new System.Drawing.Size(30, 31);
            this.img_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_icon.TabIndex = 2;
            this.img_icon.TabStop = false;
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.ForeColor = System.Drawing.Color.White;
            this.btn_minimize.Location = new System.Drawing.Point(510, 0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(35, 35);
            this.btn_minimize.TabIndex = 1;
            this.btn_minimize.Text = "⏤";
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(545, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(35, 35);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "╳";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chk_afkMode);
            this.panel1.Controls.Add(this.pnl_afkHead);
            this.panel1.Controls.Add(this.img_warning);
            this.panel1.Controls.Add(this.btn_settings);
            this.panel1.Controls.Add(this.btn_lookup);
            this.panel1.Controls.Add(this.pnl_lookup);
            this.panel1.Controls.Add(this.txt_lookup);
            this.panel1.Controls.Add(this.lbl_server);
            this.panel1.Controls.Add(this.lbl_playerName);
            this.panel1.Controls.Add(this.img_avatar);
            this.panel1.Controls.Add(this.lbl_version);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 580);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "Dupe Manager";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 59);
            this.label1.TabIndex = 10;
            this.label1.Text = "AFK mode will run garry\'s mod in the background. Using less resources. Whenever y" +
    "our gmod is closed.";
            // 
            // chk_afkMode
            // 
            this.chk_afkMode.AutoSize = true;
            this.chk_afkMode.ForeColor = System.Drawing.Color.White;
            this.chk_afkMode.Location = new System.Drawing.Point(27, 422);
            this.chk_afkMode.Name = "chk_afkMode";
            this.chk_afkMode.Size = new System.Drawing.Size(118, 17);
            this.chk_afkMode.TabIndex = 9;
            this.chk_afkMode.Text = "AFK Mode Enabled";
            this.tip_afk.SetToolTip(this.chk_afkMode, "Check this to enable AFK mode. Whenever garrys mod is closed.");
            this.chk_afkMode.UseVisualStyleBackColor = true;
            this.chk_afkMode.CheckedChanged += new System.EventHandler(this.chk_afkMode_CheckedChanged);
            // 
            // pnl_afkHead
            // 
            this.pnl_afkHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnl_afkHead.Controls.Add(this.lbl_afk);
            this.pnl_afkHead.Controls.Add(this.panel4);
            this.pnl_afkHead.Location = new System.Drawing.Point(12, 384);
            this.pnl_afkHead.Name = "pnl_afkHead";
            this.pnl_afkHead.Size = new System.Drawing.Size(219, 29);
            this.pnl_afkHead.TabIndex = 6;
            // 
            // lbl_afk
            // 
            this.lbl_afk.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_afk.ForeColor = System.Drawing.Color.White;
            this.lbl_afk.Location = new System.Drawing.Point(11, 1);
            this.lbl_afk.Name = "lbl_afk";
            this.lbl_afk.Size = new System.Drawing.Size(156, 25);
            this.lbl_afk.TabIndex = 1;
            this.lbl_afk.Text = "AFK Options";
            this.lbl_afk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(129)))), ((int)(((byte)(255)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 29);
            this.panel4.TabIndex = 0;
            // 
            // img_warning
            // 
            this.img_warning.Image = global::SUPLauncher_Reborn.Properties.Resources.SecurityAndMaintenance_Alert;
            this.img_warning.Location = new System.Drawing.Point(204, 548);
            this.img_warning.Name = "img_warning";
            this.img_warning.Size = new System.Drawing.Size(34, 24);
            this.img_warning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_warning.TabIndex = 8;
            this.img_warning.TabStop = false;
            this.img_warning.Visible = false;
            this.img_warning.Click += new System.EventHandler(this.img_warning_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_settings.Image = global::SUPLauncher_Reborn.Properties.Resources.PngItem_64059891;
            this.btn_settings.Location = new System.Drawing.Point(12, 533);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(46, 35);
            this.btn_settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_settings.TabIndex = 3;
            this.btn_settings.TabStop = false;
            this.btn_settings.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_lookup
            // 
            this.btn_lookup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btn_lookup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_lookup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lookup.ForeColor = System.Drawing.Color.White;
            this.btn_lookup.Location = new System.Drawing.Point(13, 342);
            this.btn_lookup.Name = "btn_lookup";
            this.btn_lookup.Size = new System.Drawing.Size(218, 23);
            this.btn_lookup.TabIndex = 6;
            this.btn_lookup.Text = "Show Profile";
            this.btn_lookup.UseVisualStyleBackColor = false;
            this.btn_lookup.Click += new System.EventHandler(this.btn_lookup_Click);
            this.btn_lookup.MouseEnter += new System.EventHandler(this.btn_lookup_MouseEnter);
            // 
            // pnl_lookup
            // 
            this.pnl_lookup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnl_lookup.Controls.Add(this.lbl_lookup);
            this.pnl_lookup.Controls.Add(this.pnl_4);
            this.pnl_lookup.Location = new System.Drawing.Point(12, 280);
            this.pnl_lookup.Name = "pnl_lookup";
            this.pnl_lookup.Size = new System.Drawing.Size(219, 29);
            this.pnl_lookup.TabIndex = 5;
            // 
            // lbl_lookup
            // 
            this.lbl_lookup.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lookup.ForeColor = System.Drawing.Color.White;
            this.lbl_lookup.Location = new System.Drawing.Point(11, 1);
            this.lbl_lookup.Name = "lbl_lookup";
            this.lbl_lookup.Size = new System.Drawing.Size(156, 25);
            this.lbl_lookup.TabIndex = 1;
            this.lbl_lookup.Text = "Profile Lookup";
            this.lbl_lookup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_4
            // 
            this.pnl_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(129)))), ((int)(((byte)(255)))));
            this.pnl_4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_4.Location = new System.Drawing.Point(0, 0);
            this.pnl_4.Name = "pnl_4";
            this.pnl_4.Size = new System.Drawing.Size(5, 29);
            this.pnl_4.TabIndex = 0;
            // 
            // txt_lookup
            // 
            this.txt_lookup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txt_lookup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lookup.Location = new System.Drawing.Point(12, 315);
            this.txt_lookup.Name = "txt_lookup";
            this.txt_lookup.Size = new System.Drawing.Size(219, 20);
            this.txt_lookup.TabIndex = 4;
            // 
            // lbl_server
            // 
            this.lbl_server.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_server.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_server.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_server.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_server.Location = new System.Drawing.Point(0, 161);
            this.lbl_server.Name = "lbl_server";
            this.lbl_server.Size = new System.Drawing.Size(244, 26);
            this.lbl_server.TabIndex = 2;
            this.lbl_server.Text = "Currently not playing SUP";
            this.lbl_server.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_playerName
            // 
            this.lbl_playerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_playerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_playerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playerName.ForeColor = System.Drawing.Color.White;
            this.lbl_playerName.Location = new System.Drawing.Point(0, 139);
            this.lbl_playerName.Name = "lbl_playerName";
            this.lbl_playerName.Size = new System.Drawing.Size(244, 26);
            this.lbl_playerName.TabIndex = 1;
            this.lbl_playerName.Text = "PLAYER_NAME";
            this.lbl_playerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_version
            // 
            this.lbl_version.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_version.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_version.Location = new System.Drawing.Point(0, 548);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(244, 23);
            this.lbl_version.TabIndex = 7;
            this.lbl_version.Text = "V1.0.0";
            this.lbl_version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_version.Click += new System.EventHandler(this.lbl_version_Click);
            this.lbl_version.MouseEnter += new System.EventHandler(this.lbl_version_MouseEnter);
            // 
            // pnl_servers
            // 
            this.pnl_servers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_servers.BackColor = System.Drawing.Color.Transparent;
            this.pnl_servers.Location = new System.Drawing.Point(255, 50);
            this.pnl_servers.Name = "pnl_servers";
            this.pnl_servers.Size = new System.Drawing.Size(315, 481);
            this.pnl_servers.TabIndex = 2;
            // 
            // lbl_progress
            // 
            this.lbl_progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_progress.BackColor = System.Drawing.Color.Transparent;
            this.lbl_progress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_progress.ForeColor = System.Drawing.Color.White;
            this.lbl_progress.Location = new System.Drawing.Point(250, 583);
            this.lbl_progress.Name = "lbl_progress";
            this.lbl_progress.Size = new System.Drawing.Size(330, 23);
            this.lbl_progress.TabIndex = 5;
            this.lbl_progress.Text = "Launching Danktown...";
            this.lbl_progress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_progress.Visible = false;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // tip_afk
            // 
            this.tip_afk.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tip_afk.ToolTipTitle = "AFK Mode";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "The SUPLauncher is in the background. Right-click on the icon bottom right to clo" +
    "se.";
            this.notifyIcon1.BalloonTipTitle = "SUPLauncher is not closed!";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "SUPLauncher";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "Dupe Marketplace";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cProgressBar1
            // 
            this.cProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.cProgressBar1.Location = new System.Drawing.Point(243, 607);
            this.cProgressBar1.Maximum = 100;
            this.cProgressBar1.Minimum = 0;
            this.cProgressBar1.Name = "cProgressBar1";
            this.cProgressBar1.ProgressBarColor = System.Drawing.Color.DodgerBlue;
            this.cProgressBar1.Size = new System.Drawing.Size(337, 10);
            this.cProgressBar1.TabIndex = 4;
            this.cProgressBar1.Value = 0;
            this.cProgressBar1.Visible = false;
            // 
            // img_avatar
            // 
            this.img_avatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.img_avatar.BackColor = System.Drawing.Color.DarkGray;
            this.img_avatar.Location = new System.Drawing.Point(59, 6);
            this.img_avatar.Name = "img_avatar";
            this.img_avatar.Size = new System.Drawing.Size(128, 128);
            this.img_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_avatar.TabIndex = 0;
            this.img_avatar.TabStop = false;
            this.img_avatar.Click += new System.EventHandler(this.img_avatar_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SUPLauncher_Reborn.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(580, 615);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl_progress);
            this.Controls.Add(this.cProgressBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_servers);
            this.Controls.Add(this.pnl_topBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(580, 615);
            this.MinimumSize = new System.Drawing.Size(580, 615);
            this.Name = "frm_main";
            this.Opacity = 0D;
            this.Text = "SUP Launcher";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.pnl_topBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_icon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_afkHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_warning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_settings)).EndInit();
            this.pnl_lookup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_topBar;
        private System.Windows.Forms.PictureBox img_icon;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_server;
        private System.Windows.Forms.Label lbl_playerName;
        private OvalPictureBox img_avatar;
        private System.Windows.Forms.FlowLayoutPanel pnl_servers;
        private System.Windows.Forms.PictureBox btn_settings;
        private CProgressBar cProgressBar1;
        private System.Windows.Forms.Label lbl_progress;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_lookup;
        private System.Windows.Forms.Label lbl_lookup;
        private System.Windows.Forms.Panel pnl_4;
        private System.Windows.Forms.TextBox txt_lookup;
        private System.Windows.Forms.Button btn_lookup;
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox img_warning;
        private System.Windows.Forms.ToolTip tip_afk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_afkMode;
        private System.Windows.Forms.Panel pnl_afkHead;
        private System.Windows.Forms.Label lbl_afk;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

