namespace SUPLauncher_Updater
{
    partial class UpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_updating = new System.Windows.Forms.Label();
            this.cProgressBar1 = new SUPLauncher_Reborn.CProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SUPLauncher_Updater.Properties.Resources.site_logo_reduced;
            this.pictureBox1.Location = new System.Drawing.Point(100, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_updating
            // 
            this.lbl_updating.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_updating.BackColor = System.Drawing.Color.Transparent;
            this.lbl_updating.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_updating.ForeColor = System.Drawing.Color.White;
            this.lbl_updating.Location = new System.Drawing.Point(0, 213);
            this.lbl_updating.Name = "lbl_updating";
            this.lbl_updating.Size = new System.Drawing.Size(500, 23);
            this.lbl_updating.TabIndex = 2;
            this.lbl_updating.Text = "Updating";
            this.lbl_updating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cProgressBar1
            // 
            this.cProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cProgressBar1.Location = new System.Drawing.Point(0, 240);
            this.cProgressBar1.Maximum = 100;
            this.cProgressBar1.Minimum = 0;
            this.cProgressBar1.Name = "cProgressBar1";
            this.cProgressBar1.ProgressBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(129)))), ((int)(((byte)(255)))));
            this.cProgressBar1.Size = new System.Drawing.Size(500, 10);
            this.cProgressBar1.TabIndex = 1;
            this.cProgressBar1.Value = 75;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.lbl_updating);
            this.Controls.Add(this.cProgressBar1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 250);
            this.MinimumSize = new System.Drawing.Size(500, 250);
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SUPLauncher - Updater";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private SUPLauncher_Reborn.CProgressBar cProgressBar1;
        private System.Windows.Forms.Label lbl_updating;
    }
}

