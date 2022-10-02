
namespace SUPLauncher_Reborn
{
    partial class InGameBrowser
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
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.pnl_topBar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.img_icon = new System.Windows.Forms.PictureBox();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.pnl_loading = new System.Windows.Forms.Panel();
            this.cProgressBar1 = new SUPLauncher_Reborn.CProgressBar();
            this.lbl_loading = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_toolBar = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_forward = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.pnl_topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_icon)).BeginInit();
            this.pnl_loading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_toolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
            this.chromiumWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(0, 71);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(1073, 510);
            this.chromiumWebBrowser1.TabIndex = 0;
            this.chromiumWebBrowser1.LoadError += new System.EventHandler<CefSharp.LoadErrorEventArgs>(this.chromiumWebBrowser1_LoadError);
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
            this.pnl_topBar.Size = new System.Drawing.Size(1073, 35);
            this.pnl_topBar.TabIndex = 1;
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
            this.lbl_title.Location = new System.Drawing.Point(43, 4);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(192, 26);
            this.lbl_title.TabIndex = 3;
            this.lbl_title.Text = "SUPLauncher | Browser";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // img_icon
            // 
            this.img_icon.Image = global::SUPLauncher_Reborn.Properties.Resources.textless_logo;
            this.img_icon.Location = new System.Drawing.Point(10, 0);
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
            this.btn_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.ForeColor = System.Drawing.Color.White;
            this.btn_minimize.Location = new System.Drawing.Point(1003, 0);
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
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(1038, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(35, 35);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "╳";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pnl_loading
            // 
            this.pnl_loading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.pnl_loading.Controls.Add(this.cProgressBar1);
            this.pnl_loading.Controls.Add(this.lbl_loading);
            this.pnl_loading.Controls.Add(this.pictureBox1);
            this.pnl_loading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_loading.Location = new System.Drawing.Point(0, 71);
            this.pnl_loading.Name = "pnl_loading";
            this.pnl_loading.Size = new System.Drawing.Size(1073, 510);
            this.pnl_loading.TabIndex = 2;
            // 
            // cProgressBar1
            // 
            this.cProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cProgressBar1.Location = new System.Drawing.Point(0, 500);
            this.cProgressBar1.Maximum = 100;
            this.cProgressBar1.Minimum = 0;
            this.cProgressBar1.Name = "cProgressBar1";
            this.cProgressBar1.ProgressBarColor = System.Drawing.Color.DodgerBlue;
            this.cProgressBar1.Size = new System.Drawing.Size(1073, 5);
            this.cProgressBar1.TabIndex = 2;
            this.cProgressBar1.Value = 50;
            // 
            // lbl_loading
            // 
            this.lbl_loading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_loading.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loading.ForeColor = System.Drawing.Color.White;
            this.lbl_loading.Location = new System.Drawing.Point(437, 381);
            this.lbl_loading.Name = "lbl_loading";
            this.lbl_loading.Size = new System.Drawing.Size(219, 38);
            this.lbl_loading.TabIndex = 1;
            this.lbl_loading.Text = "Loading...";
            this.lbl_loading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::SUPLauncher_Reborn.Properties.Resources.textless_logo;
            this.pictureBox1.Location = new System.Drawing.Point(434, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_toolBar
            // 
            this.pnl_toolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.pnl_toolBar.Controls.Add(this.textBox1);
            this.pnl_toolBar.Controls.Add(this.button1);
            this.pnl_toolBar.Controls.Add(this.btn_forward);
            this.pnl_toolBar.Controls.Add(this.btn_back);
            this.pnl_toolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_toolBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.pnl_toolBar.Location = new System.Drawing.Point(0, 35);
            this.pnl_toolBar.Name = "pnl_toolBar";
            this.pnl_toolBar.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.pnl_toolBar.Size = new System.Drawing.Size(1073, 36);
            this.pnl_toolBar.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBox1.Location = new System.Drawing.Point(97, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(691, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "https://superiorservers.co";
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(68, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "⟳";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_forward
            // 
            this.btn_forward.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_forward.FlatAppearance.BorderSize = 0;
            this.btn_forward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_forward.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_forward.Location = new System.Drawing.Point(39, 5);
            this.btn_forward.Name = "btn_forward";
            this.btn_forward.Size = new System.Drawing.Size(29, 26);
            this.btn_forward.TabIndex = 4;
            this.btn_forward.Text = "▶";
            this.btn_forward.UseVisualStyleBackColor = true;
            this.btn_forward.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_back
            // 
            this.btn_back.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(10, 5);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(29, 26);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "◀";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.button2_Click);
            // 
            // InGameBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 581);
            this.Controls.Add(this.pnl_loading);
            this.Controls.Add(this.chromiumWebBrowser1);
            this.Controls.Add(this.pnl_toolBar);
            this.Controls.Add(this.pnl_topBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InGameBrowser";
            this.Text = "Profile";
            this.pnl_topBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_icon)).EndInit();
            this.pnl_loading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_toolBar.ResumeLayout(false);
            this.pnl_toolBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
        private System.Windows.Forms.Panel pnl_topBar;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox img_icon;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel pnl_loading;
        private CProgressBar cProgressBar1;
        private System.Windows.Forms.Label lbl_loading;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_toolBar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_forward;
    }
}