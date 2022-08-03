
namespace SUPLauncher_Reborn
{
    partial class Notification
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
            this.img_icon = new System.Windows.Forms.PictureBox();
            this.lbl_header = new System.Windows.Forms.Label();
            this.lbl_info = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.img_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // img_icon
            // 
            this.img_icon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.img_icon.Image = global::SUPLauncher_Reborn.Properties.Resources.textless_logo;
            this.img_icon.Location = new System.Drawing.Point(12, 18);
            this.img_icon.Name = "img_icon";
            this.img_icon.Size = new System.Drawing.Size(88, 80);
            this.img_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_icon.TabIndex = 0;
            this.img_icon.TabStop = false;
            // 
            // lbl_header
            // 
            this.lbl_header.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbl_header.Location = new System.Drawing.Point(103, 19);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(234, 27);
            this.lbl_header.TabIndex = 1;
            this.lbl_header.Text = "SETTINGS CHANGED";
            // 
            // lbl_info
            // 
            this.lbl_info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.ForeColor = System.Drawing.Color.White;
            this.lbl_info.Location = new System.Drawing.Point(104, 46);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(294, 52);
            this.lbl_info.TabIndex = 2;
            this.lbl_info.Text = "Overlay has been enabled!";
            this.lbl_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(129)))), ((int)(((byte)(255)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(406, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 121);
            this.panel2.TabIndex = 58;
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(410, 121);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.lbl_header);
            this.Controls.Add(this.img_icon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notification";
            this.Text = "Notification";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Notification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_icon;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Panel panel2;
    }
}