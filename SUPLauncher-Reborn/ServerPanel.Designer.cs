
namespace SUPLauncher_Reborn
{
    partial class ServerPanel
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
            this.pnl_server = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.img = new System.Windows.Forms.PictureBox();
            this.pnl_danktown_top = new System.Windows.Forms.Panel();
            this.lbl_playerCount = new System.Windows.Forms.Label();
            this.lbl_serverName = new System.Windows.Forms.Label();
            this.pnl_server.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.pnl_danktown_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_server
            // 
            this.pnl_server.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pnl_server.Controls.Add(this.img);
            this.pnl_server.Controls.Add(this.pnl_danktown_top);
            this.pnl_server.Location = new System.Drawing.Point(0, 0);
            this.pnl_server.Name = "pnl_server";
            this.pnl_server.Size = new System.Drawing.Size(150, 100);
            this.pnl_server.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 31);
            this.panel2.TabIndex = 5;
            // 
            // img
            // 
            this.img.Dock = System.Windows.Forms.DockStyle.Fill;
            this.img.Image = global::SUPLauncher_Reborn.Properties.Resources.danktown2;
            this.img.Location = new System.Drawing.Point(0, 31);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(150, 69);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img.TabIndex = 1;
            this.img.TabStop = false;
            // 
            // pnl_danktown_top
            // 
            this.pnl_danktown_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnl_danktown_top.Controls.Add(this.panel2);
            this.pnl_danktown_top.Controls.Add(this.lbl_playerCount);
            this.pnl_danktown_top.Controls.Add(this.lbl_serverName);
            this.pnl_danktown_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_danktown_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_danktown_top.Name = "pnl_danktown_top";
            this.pnl_danktown_top.Size = new System.Drawing.Size(150, 31);
            this.pnl_danktown_top.TabIndex = 0;
            // 
            // lbl_playerCount
            // 
            this.lbl_playerCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_playerCount.AutoSize = true;
            this.lbl_playerCount.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playerCount.ForeColor = System.Drawing.Color.White;
            this.lbl_playerCount.Location = new System.Drawing.Point(103, 8);
            this.lbl_playerCount.Name = "lbl_playerCount";
            this.lbl_playerCount.Size = new System.Drawing.Size(43, 16);
            this.lbl_playerCount.TabIndex = 2;
            this.lbl_playerCount.Text = "89/128";
            // 
            // lbl_serverName
            // 
            this.lbl_serverName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_serverName.ForeColor = System.Drawing.Color.White;
            this.lbl_serverName.Location = new System.Drawing.Point(10, 0);
            this.lbl_serverName.Name = "lbl_serverName";
            this.lbl_serverName.Size = new System.Drawing.Size(140, 31);
            this.lbl_serverName.TabIndex = 0;
            this.lbl_serverName.Text = "Danktown";
            this.lbl_serverName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ServerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_server);
            this.Name = "ServerPanel";
            this.Size = new System.Drawing.Size(150, 100);
            this.pnl_server.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.pnl_danktown_top.ResumeLayout(false);
            this.pnl_danktown_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_server;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.Panel pnl_danktown_top;
        private System.Windows.Forms.Label lbl_playerCount;
        private System.Windows.Forms.Label lbl_serverName;
    }
}
