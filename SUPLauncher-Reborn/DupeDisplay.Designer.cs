
using System;

namespace SUPLauncher_Reborn
{
    partial class DupeDisplay
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
            this.lbl_creator = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pnl_left = new System.Windows.Forms.Panel();
            this.img_displayImage = new System.Windows.Forms.PictureBox();
            this.img_creatorAvatar = new OvalPictureBox();
            this.lbl_downloads = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_displayImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_creatorAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_creator
            // 
            this.lbl_creator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_creator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbl_creator.Location = new System.Drawing.Point(195, 28);
            this.lbl_creator.Name = "lbl_creator";
            this.lbl_creator.Size = new System.Drawing.Size(208, 26);
            this.lbl_creator.TabIndex = 1;
            this.lbl_creator.Text = "Best of all";
            this.lbl_creator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_creator.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            this.lbl_creator.MouseLeave += new System.EventHandler(this.pnl_left_MouseLeave);
            // 
            // lbl_name
            // 
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(164, 2);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(263, 25);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Kappels Base Defense";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_name.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            this.lbl_name.MouseLeave += new System.EventHandler(this.pnl_left_MouseLeave);
            // 
            // pnl_left
            // 
            this.pnl_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(5, 75);
            this.pnl_left.TabIndex = 3;
            this.pnl_left.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            this.pnl_left.MouseLeave += new System.EventHandler(this.pnl_left_MouseLeave);
            // 
            // img_displayImage
            // 
            this.img_displayImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.img_displayImage.Image = global::SUPLauncher_Reborn.Properties.Resources.dupe_default;
            this.img_displayImage.Location = new System.Drawing.Point(5, 0);
            this.img_displayImage.Name = "img_displayImage";
            this.img_displayImage.Size = new System.Drawing.Size(150, 75);
            this.img_displayImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_displayImage.TabIndex = 0;
            this.img_displayImage.TabStop = false;
            this.img_displayImage.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            this.img_displayImage.MouseLeave += new System.EventHandler(this.pnl_left_MouseLeave);
            // 
            // img_creatorAvatar
            // 
            this.img_creatorAvatar.BackColor = System.Drawing.Color.DarkGray;
            this.img_creatorAvatar.Location = new System.Drawing.Point(166, 30);
            this.img_creatorAvatar.Name = "img_creatorAvatar";
            this.img_creatorAvatar.Size = new System.Drawing.Size(25, 25);
            this.img_creatorAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_creatorAvatar.TabIndex = 2;
            this.img_creatorAvatar.TabStop = false;
            this.img_creatorAvatar.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            this.img_creatorAvatar.MouseLeave += new System.EventHandler(this.pnl_left_MouseLeave);
            // 
            // lbl_downloads
            // 
            this.lbl_downloads.AutoSize = true;
            this.lbl_downloads.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_downloads.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbl_downloads.Location = new System.Drawing.Point(302, 54);
            this.lbl_downloads.Name = "lbl_downloads";
            this.lbl_downloads.Size = new System.Drawing.Size(100, 16);
            this.lbl_downloads.TabIndex = 4;
            this.lbl_downloads.Text = "Downloads: 0";
            // 
            // DupeDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.lbl_downloads);
            this.Controls.Add(this.img_creatorAvatar);
            this.Controls.Add(this.lbl_creator);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.img_displayImage);
            this.Controls.Add(this.pnl_left);
            this.DoubleBuffered = true;
            this.Name = "DupeDisplay";
            this.Size = new System.Drawing.Size(406, 75);
            
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DupeDisplay_MouseDown);
            this.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.pnl_left_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.img_displayImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_creatorAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_displayImage;
        private OvalPictureBox img_creatorAvatar;
        private System.Windows.Forms.Label lbl_creator;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Label lbl_downloads;
    }
}
