namespace SUPLauncher_Reborn
{
    partial class Overlay_ProfileWidget
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_left = new System.Windows.Forms.Panel();
            this.lbl_playtime = new System.Windows.Forms.Label();
            this.lbl_steamid = new System.Windows.Forms.Label();
            this.lbl_player_name = new System.Windows.Forms.Label();
            this.img_avatar = new OvalPictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel2.Controls.Add(this.pnl_left);
            this.panel2.Controls.Add(this.lbl_playtime);
            this.panel2.Controls.Add(this.lbl_steamid);
            this.panel2.Controls.Add(this.lbl_player_name);
            this.panel2.Controls.Add(this.img_avatar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 154);
            this.panel2.TabIndex = 3;
            // 
            // pnl_left
            // 
            this.pnl_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(129)))), ((int)(((byte)(255)))));
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(4, 154);
            this.pnl_left.TabIndex = 58;
            // 
            // lbl_playtime
            // 
            this.lbl_playtime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_playtime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playtime.ForeColor = System.Drawing.Color.Silver;
            this.lbl_playtime.Location = new System.Drawing.Point(165, 112);
            this.lbl_playtime.Name = "lbl_playtime";
            this.lbl_playtime.Size = new System.Drawing.Size(141, 27);
            this.lbl_playtime.TabIndex = 3;
            // 
            // lbl_steamid
            // 
            this.lbl_steamid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_steamid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_steamid.ForeColor = System.Drawing.Color.Silver;
            this.lbl_steamid.Location = new System.Drawing.Point(165, 64);
            this.lbl_steamid.Name = "lbl_steamid";
            this.lbl_steamid.Size = new System.Drawing.Size(141, 27);
            this.lbl_steamid.TabIndex = 2;
            // 
            // lbl_player_name
            // 
            this.lbl_player_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_player_name.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_player_name.ForeColor = System.Drawing.Color.White;
            this.lbl_player_name.Location = new System.Drawing.Point(165, 37);
            this.lbl_player_name.Name = "lbl_player_name";
            this.lbl_player_name.Size = new System.Drawing.Size(141, 27);
            this.lbl_player_name.TabIndex = 1;
            // 
            // img_avatar
            // 
            this.img_avatar.BackColor = System.Drawing.Color.DarkGray;
            this.img_avatar.Location = new System.Drawing.Point(15, 23);
            this.img_avatar.Name = "img_avatar";
            this.img_avatar.Size = new System.Drawing.Size(100, 100);
            this.img_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_avatar.TabIndex = 0;
            this.img_avatar.TabStop = false;
            // 
            // Overlay_ProfileWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Name = "Overlay_ProfileWidget";
            this.Size = new System.Drawing.Size(333, 154);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Label lbl_playtime;
        private System.Windows.Forms.Label lbl_steamid;
        private System.Windows.Forms.Label lbl_player_name;
        private OvalPictureBox img_avatar;
    }
}
