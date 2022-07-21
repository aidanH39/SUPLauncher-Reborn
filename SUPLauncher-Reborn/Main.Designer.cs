
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
            this.pnl_topBar = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.img_icon = new System.Windows.Forms.PictureBox();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_playerName = new System.Windows.Forms.Label();
            this.pnl_servers = new System.Windows.Forms.FlowLayoutPanel();
            this.img_avatar = new OvalPictureBox();
            this.pnl_topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_icon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_topBar
            // 
            this.pnl_topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pnl_topBar.Controls.Add(this.lbl_title);
            this.pnl_topBar.Controls.Add(this.img_icon);
            this.pnl_topBar.Controls.Add(this.btn_minimize);
            this.pnl_topBar.Controls.Add(this.btn_close);
            this.pnl_topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_topBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_topBar.Name = "pnl_topBar";
            this.pnl_topBar.Size = new System.Drawing.Size(580, 35);
            this.pnl_topBar.TabIndex = 0;
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(41, 4);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(116, 26);
            this.lbl_title.TabIndex = 3;
            this.lbl_title.Text = "SUPLauncher";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // img_icon
            // 
            this.img_icon.Image = global::SUPLauncher_Reborn.Properties.Resources.textless_logo;
            this.img_icon.Location = new System.Drawing.Point(0, 0);
            this.img_icon.Name = "img_icon";
            this.img_icon.Size = new System.Drawing.Size(35, 35);
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
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_playerName);
            this.panel1.Controls.Add(this.img_avatar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 202);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(0, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Currently playing Danktown";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_playerName
            // 
            this.lbl_playerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_playerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_playerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playerName.ForeColor = System.Drawing.Color.White;
            this.lbl_playerName.Location = new System.Drawing.Point(0, 137);
            this.lbl_playerName.Name = "lbl_playerName";
            this.lbl_playerName.Size = new System.Drawing.Size(580, 26);
            this.lbl_playerName.TabIndex = 1;
            this.lbl_playerName.Text = "Best of all";
            this.lbl_playerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_servers
            // 
            this.pnl_servers.BackColor = System.Drawing.Color.Transparent;
            this.pnl_servers.Location = new System.Drawing.Point(0, 239);
            this.pnl_servers.Name = "pnl_servers";
            this.pnl_servers.Size = new System.Drawing.Size(580, 214);
            this.pnl_servers.TabIndex = 2;
            // 
            // img_avatar
            // 
            this.img_avatar.BackColor = System.Drawing.Color.DarkGray;
            this.img_avatar.Location = new System.Drawing.Point(227, 6);
            this.img_avatar.Name = "img_avatar";
            this.img_avatar.Size = new System.Drawing.Size(128, 128);
            this.img_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_avatar.TabIndex = 0;
            this.img_avatar.TabStop = false;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SUPLauncher_Reborn.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(580, 615);
            this.Controls.Add(this.pnl_servers);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_topBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_main";
            this.Text = "SUP Launcher";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.pnl_topBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_icon)).EndInit();
            this.panel1.ResumeLayout(false);
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
    }
}

