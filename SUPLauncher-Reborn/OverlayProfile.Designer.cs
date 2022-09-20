
namespace SUPLauncher_Reborn
{
    partial class OverlayProfile
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
            this.pnl_profile = new System.Windows.Forms.Panel();
            this.pnl_topBar = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_previousOffenses = new System.Windows.Forms.Label();
            this.lbl_playTime = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.img_avatar = new OvalPictureBox();
            this.btn_expand = new System.Windows.Forms.Button();
            this.tmr_giveBackFocus = new System.Windows.Forms.Timer(this.components);
            this.pnl_bans = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnl_profile.SuspendLayout();
            this.pnl_topBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_avatar)).BeginInit();
            this.pnl_bans.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_profile
            // 
            this.pnl_profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.pnl_profile.Controls.Add(this.pnl_topBar);
            this.pnl_profile.Controls.Add(this.panel2);
            this.pnl_profile.Controls.Add(this.panel1);
            this.pnl_profile.Controls.Add(this.lbl_previousOffenses);
            this.pnl_profile.Controls.Add(this.lbl_playTime);
            this.pnl_profile.Controls.Add(this.lbl_name);
            this.pnl_profile.Controls.Add(this.img_avatar);
            this.pnl_profile.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_profile.Location = new System.Drawing.Point(0, 0);
            this.pnl_profile.MaximumSize = new System.Drawing.Size(231, 207);
            this.pnl_profile.Name = "pnl_profile";
            this.pnl_profile.Size = new System.Drawing.Size(231, 207);
            this.pnl_profile.TabIndex = 1;
            // 
            // pnl_topBar
            // 
            this.pnl_topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnl_topBar.Controls.Add(this.btn_close);
            this.pnl_topBar.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnl_topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_topBar.Location = new System.Drawing.Point(4, 0);
            this.pnl_topBar.Name = "pnl_topBar";
            this.pnl_topBar.Size = new System.Drawing.Size(227, 18);
            this.pnl_topBar.TabIndex = 60;
            this.pnl_topBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            this.pnl_topBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseMove);
            this.pnl_topBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseUp);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(172, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(55, 18);
            this.btn_close.TabIndex = 1;
            this.btn_close.TabStop = false;
            this.btn_close.Text = "╳";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(129)))), ((int)(((byte)(255)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 207);
            this.panel2.TabIndex = 59;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(15, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 51);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "12/21/2016";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "First Join";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_previousOffenses
            // 
            this.lbl_previousOffenses.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_previousOffenses.ForeColor = System.Drawing.Color.White;
            this.lbl_previousOffenses.Location = new System.Drawing.Point(89, 75);
            this.lbl_previousOffenses.Name = "lbl_previousOffenses";
            this.lbl_previousOffenses.Size = new System.Drawing.Size(132, 23);
            this.lbl_previousOffenses.TabIndex = 3;
            this.lbl_previousOffenses.Text = "2 Total PO\'s";
            // 
            // lbl_playTime
            // 
            this.lbl_playTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.lbl_playTime.Location = new System.Drawing.Point(90, 54);
            this.lbl_playTime.Name = "lbl_playTime";
            this.lbl_playTime.Size = new System.Drawing.Size(111, 23);
            this.lbl_playTime.TabIndex = 2;
            this.lbl_playTime.Text = "2353:52:23";
            // 
            // lbl_name
            // 
            this.lbl_name.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(89, 31);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(112, 23);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Best of all";
            // 
            // img_avatar
            // 
            this.img_avatar.BackColor = System.Drawing.Color.DarkGray;
            this.img_avatar.Location = new System.Drawing.Point(14, 26);
            this.img_avatar.Name = "img_avatar";
            this.img_avatar.Size = new System.Drawing.Size(64, 64);
            this.img_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_avatar.TabIndex = 0;
            this.img_avatar.TabStop = false;
            // 
            // btn_expand
            // 
            this.btn_expand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(44)))));
            this.btn_expand.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_expand.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_expand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_expand.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_expand.ForeColor = System.Drawing.Color.White;
            this.btn_expand.Location = new System.Drawing.Point(231, 0);
            this.btn_expand.Name = "btn_expand";
            this.btn_expand.Size = new System.Drawing.Size(23, 208);
            this.btn_expand.TabIndex = 2;
            this.btn_expand.Text = ">";
            this.btn_expand.UseVisualStyleBackColor = false;
            this.btn_expand.Click += new System.EventHandler(this.btn_expand_Click);
            // 
            // tmr_giveBackFocus
            // 
            this.tmr_giveBackFocus.Enabled = true;
            this.tmr_giveBackFocus.Interval = 1000;
            // 
            // pnl_bans
            // 
            this.pnl_bans.BackColor = System.Drawing.Color.Transparent;
            this.pnl_bans.Controls.Add(this.flowLayoutPanel1);
            this.pnl_bans.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_bans.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnl_bans.Location = new System.Drawing.Point(254, 0);
            this.pnl_bans.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_bans.Name = "pnl_bans";
            this.pnl_bans.Size = new System.Drawing.Size(870, 208);
            this.pnl_bans.TabIndex = 3;
            this.pnl_bans.WrapContents = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.label9);
            this.flowLayoutPanel1.Controls.Add(this.label10);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(868, 35);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label6.Location = new System.Drawing.Point(115, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 35);
            this.label6.TabIndex = 1;
            this.label6.Text = "Server";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label7.Location = new System.Drawing.Point(245, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 35);
            this.label7.TabIndex = 2;
            this.label7.Text = "Admin";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label8.Location = new System.Drawing.Point(366, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 35);
            this.label8.TabIndex = 3;
            this.label8.Text = "Length";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label9.Location = new System.Drawing.Point(442, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(219, 35);
            this.label9.TabIndex = 4;
            this.label9.Text = "Reason";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label10.Location = new System.Drawing.Point(667, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 35);
            this.label10.TabIndex = 5;
            this.label10.Text = "Unban Reason";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OverlayProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SUPLauncher_Reborn.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(257, 208);
            this.Controls.Add(this.pnl_bans);
            this.Controls.Add(this.btn_expand);
            this.Controls.Add(this.pnl_profile);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 50);
            this.MaximumSize = new System.Drawing.Size(1130, 208);
            this.Name = "OverlayProfile";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "OverlayProfile";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OverlayProfile_Load);
            this.pnl_profile.ResumeLayout(false);
            this.pnl_topBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_avatar)).EndInit();
            this.pnl_bans.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private OvalPictureBox img_avatar;
        private System.Windows.Forms.Panel pnl_profile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_previousOffenses;
        private System.Windows.Forms.Label lbl_playTime;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_expand;
        private System.Windows.Forms.Timer tmr_giveBackFocus;
        private System.Windows.Forms.FlowLayoutPanel pnl_bans;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_topBar;
        private System.Windows.Forms.Button btn_close;
    }
}