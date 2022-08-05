
namespace SUPLauncher_Reborn
{
    partial class DupeDetails
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
            this.TopBar = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.img_screenshot = new System.Windows.Forms.PictureBox();
            this.lbl_dupeName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.img_creator = new OvalPictureBox();
            this.lbl_creator = new System.Windows.Forms.Label();
            this.web_description = new System.Windows.Forms.WebBrowser();
            this.btn_download = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_access = new System.Windows.Forms.Button();
            this.TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_screenshot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_creator)).BeginInit();
            this.SuspendLayout();
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.TopBar.Controls.Add(this.lbl_title);
            this.TopBar.Controls.Add(this.panel2);
            this.TopBar.Controls.Add(this.button3);
            this.TopBar.Controls.Add(this.button2);
            this.TopBar.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(478, 28);
            this.TopBar.TabIndex = 34;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            this.TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseMove);
            this.TopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseUp);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(10, 4);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(247, 19);
            this.lbl_title.TabIndex = 58;
            this.lbl_title.Text = "Dupe Marketplace (Viewing Dupe)";
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
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(433, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 28);
            this.button3.TabIndex = 55;
            this.button3.Text = "";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            // 
            // img_screenshot
            // 
            this.img_screenshot.BackColor = System.Drawing.Color.Transparent;
            this.img_screenshot.ErrorImage = global::SUPLauncher_Reborn.Properties.Resources.dupe_default;
            this.img_screenshot.Image = global::SUPLauncher_Reborn.Properties.Resources.dupe_default;
            this.img_screenshot.Location = new System.Drawing.Point(0, 31);
            this.img_screenshot.Name = "img_screenshot";
            this.img_screenshot.Size = new System.Drawing.Size(478, 170);
            this.img_screenshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_screenshot.TabIndex = 35;
            this.img_screenshot.TabStop = false;
            // 
            // lbl_dupeName
            // 
            this.lbl_dupeName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dupeName.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dupeName.ForeColor = System.Drawing.Color.White;
            this.lbl_dupeName.Location = new System.Drawing.Point(0, 204);
            this.lbl_dupeName.Name = "lbl_dupeName";
            this.lbl_dupeName.Size = new System.Drawing.Size(478, 23);
            this.lbl_dupeName.TabIndex = 36;
            this.lbl_dupeName.Text = "Dupe Name";
            this.lbl_dupeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.label2.Location = new System.Drawing.Point(0, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(478, 23);
            this.label2.TabIndex = 37;
            this.label2.Text = "Created By";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // img_creator
            // 
            this.img_creator.BackColor = System.Drawing.Color.DarkGray;
            this.img_creator.Location = new System.Drawing.Point(175, 245);
            this.img_creator.Name = "img_creator";
            this.img_creator.Size = new System.Drawing.Size(35, 35);
            this.img_creator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_creator.TabIndex = 38;
            this.img_creator.TabStop = false;
            // 
            // lbl_creator
            // 
            this.lbl_creator.AutoSize = true;
            this.lbl_creator.BackColor = System.Drawing.Color.Transparent;
            this.lbl_creator.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_creator.ForeColor = System.Drawing.Color.White;
            this.lbl_creator.Location = new System.Drawing.Point(215, 254);
            this.lbl_creator.Name = "lbl_creator";
            this.lbl_creator.Size = new System.Drawing.Size(70, 15);
            this.lbl_creator.TabIndex = 39;
            this.lbl_creator.Text = "Best of all";
            // 
            // web_description
            // 
            this.web_description.Location = new System.Drawing.Point(12, 292);
            this.web_description.MinimumSize = new System.Drawing.Size(20, 20);
            this.web_description.Name = "web_description";
            this.web_description.Size = new System.Drawing.Size(454, 195);
            this.web_description.TabIndex = 40;
            // 
            // btn_download
            // 
            this.btn_download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btn_download.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.btn_download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_download.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_download.ForeColor = System.Drawing.Color.White;
            this.btn_download.Location = new System.Drawing.Point(14, 493);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(196, 46);
            this.btn_download.TabIndex = 41;
            this.btn_download.Text = "Download";
            this.btn_download.UseVisualStyleBackColor = false;
            this.btn_download.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btn_remove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.Location = new System.Drawing.Point(373, 493);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(93, 46);
            this.btn_remove.TabIndex = 42;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_access
            // 
            this.btn_access.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btn_access.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.btn_access.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_access.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_access.ForeColor = System.Drawing.Color.White;
            this.btn_access.Location = new System.Drawing.Point(245, 493);
            this.btn_access.Name = "btn_access";
            this.btn_access.Size = new System.Drawing.Size(122, 46);
            this.btn_access.TabIndex = 43;
            this.btn_access.Text = "Give Access";
            this.btn_access.UseVisualStyleBackColor = false;
            this.btn_access.Click += new System.EventHandler(this.btn_access_Click);
            // 
            // DupeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SUPLauncher_Reborn.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(478, 553);
            this.Controls.Add(this.btn_access);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_download);
            this.Controls.Add(this.web_description);
            this.Controls.Add(this.lbl_creator);
            this.Controls.Add(this.img_creator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_dupeName);
            this.Controls.Add(this.img_screenshot);
            this.Controls.Add(this.TopBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(399, 452);
            this.Name = "DupeDetails";
            this.Text = "DupeDetails";
            this.Load += new System.EventHandler(this.DupeDetails_Load);
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_screenshot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_creator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox img_screenshot;
        private System.Windows.Forms.Label lbl_dupeName;
        private System.Windows.Forms.Label label2;
        private OvalPictureBox img_creator;
        private System.Windows.Forms.Label lbl_creator;
        private System.Windows.Forms.WebBrowser web_description;
        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_access;
    }
}