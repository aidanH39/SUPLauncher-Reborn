
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
            this.img_warning = new System.Windows.Forms.PictureBox();
            this.btn_settings = new System.Windows.Forms.PictureBox();
            this.btn_lookup = new System.Windows.Forms.Button();
            this.pnl_lookup = new System.Windows.Forms.Panel();
            this.lbl_lookup = new System.Windows.Forms.Label();
            this.pnl_4 = new System.Windows.Forms.Panel();
            this.txt_lookup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_playerName = new System.Windows.Forms.Label();
            this.img_avatar = new OvalPictureBox();
            this.lbl_version = new System.Windows.Forms.Label();
            this.pnl_servers = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_progress = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cProgressBar1 = new SUPLauncher_Reborn.CProgressBar();
            this.pnl_topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_icon)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.panel1.Controls.Add(this.img_warning);
            this.panel1.Controls.Add(this.btn_settings);
            this.panel1.Controls.Add(this.btn_lookup);
            this.panel1.Controls.Add(this.pnl_lookup);
            this.panel1.Controls.Add(this.txt_lookup);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_playerName);
            this.panel1.Controls.Add(this.img_avatar);
            this.panel1.Controls.Add(this.lbl_version);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 580);
            this.panel1.TabIndex = 1;
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
            this.btn_lookup.Location = new System.Drawing.Point(13, 320);
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
            this.pnl_lookup.Location = new System.Drawing.Point(12, 258);
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
            this.txt_lookup.Location = new System.Drawing.Point(12, 293);
            this.txt_lookup.Name = "txt_lookup";
            this.txt_lookup.Size = new System.Drawing.Size(219, 20);
            this.txt_lookup.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(0, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Currently playing Danktown";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lbl_playerName.Text = "Best of all";
            this.lbl_playerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SUPLauncher_Reborn.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(580, 615);
            this.Controls.Add(this.lbl_progress);
            this.Controls.Add(this.cProgressBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_servers);
            this.Controls.Add(this.pnl_topBar);
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
        private System.Windows.Forms.Label label1;
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
    }
}

