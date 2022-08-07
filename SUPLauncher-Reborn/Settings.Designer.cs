
namespace SUPLauncher_Reborn
{
    partial class Settings
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
            this.pnl_topBar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.img_icon = new System.Windows.Forms.PictureBox();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_overlayKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chk_discordActivity = new System.Windows.Forms.CheckBox();
            this.chk_autoStartup = new System.Windows.Forms.CheckBox();
            this.tip = new System.Windows.Forms.ToolTip(this.components);
            this.chk_overlay = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_profileOverlayExpandKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_profileOverlayKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_icon)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.pnl_topBar.Size = new System.Drawing.Size(603, 35);
            this.pnl_topBar.TabIndex = 1;
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
            this.lbl_title.Text = "Settings";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btn_minimize.Location = new System.Drawing.Point(533, 0);
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
            this.btn_close.Location = new System.Drawing.Point(568, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(35, 35);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "╳";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.Items.AddRange(new object[] {
            "CTRL",
            "ALT",
            "SHIFT"});
            this.comboBox1.Location = new System.Drawing.Point(31, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(107, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "ALT";
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(103)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(9, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Update Keybinds";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_overlayKey
            // 
            this.txt_overlayKey.Location = new System.Drawing.Point(31, 139);
            this.txt_overlayKey.Name = "txt_overlayKey";
            this.txt_overlayKey.ReadOnly = true;
            this.txt_overlayKey.Size = new System.Drawing.Size(100, 20);
            this.txt_overlayKey.TabIndex = 6;
            this.txt_overlayKey.Text = "S";
            this.txt_overlayKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.txt_overlayKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Overlay hotkey";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(423, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 25);
            this.button2.TabIndex = 8;
            this.button2.Text = "Login to sup";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(420, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 51);
            this.label3.TabIndex = 9;
            this.label3.Text = "You can login to the sup website. This will allow things such as sit count to be " +
    "displayed.";
            // 
            // chk_discordActivity
            // 
            this.chk_discordActivity.AutoSize = true;
            this.chk_discordActivity.ForeColor = System.Drawing.Color.White;
            this.chk_discordActivity.Location = new System.Drawing.Point(423, 83);
            this.chk_discordActivity.Name = "chk_discordActivity";
            this.chk_discordActivity.Size = new System.Drawing.Size(102, 17);
            this.chk_discordActivity.TabIndex = 10;
            this.chk_discordActivity.Text = "Discord Activity ";
            this.chk_discordActivity.UseVisualStyleBackColor = true;
            this.chk_discordActivity.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chk_autoStartup
            // 
            this.chk_autoStartup.AutoSize = true;
            this.chk_autoStartup.ForeColor = System.Drawing.Color.White;
            this.chk_autoStartup.Location = new System.Drawing.Point(423, 129);
            this.chk_autoStartup.Name = "chk_autoStartup";
            this.chk_autoStartup.Size = new System.Drawing.Size(85, 17);
            this.chk_autoStartup.TabIndex = 11;
            this.chk_autoStartup.Text = "Auto Startup";
            this.tip.SetToolTip(this.chk_autoStartup, "Automaticlly start SUPLauncher on windows startup. If AFK auto startup is enabled" +
        " this will be enabled. Disable that first.");
            this.chk_autoStartup.UseVisualStyleBackColor = true;
            this.chk_autoStartup.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // tip
            // 
            this.tip.ToolTipTitle = "Infomation";
            // 
            // chk_overlay
            // 
            this.chk_overlay.AutoSize = true;
            this.chk_overlay.ForeColor = System.Drawing.Color.White;
            this.chk_overlay.Location = new System.Drawing.Point(423, 174);
            this.chk_overlay.Name = "chk_overlay";
            this.chk_overlay.Size = new System.Drawing.Size(104, 17);
            this.chk_overlay.TabIndex = 16;
            this.chk_overlay.Text = "Overlay Enabled";
            this.tip.SetToolTip(this.chk_overlay, "Automaticlly start SUPLauncher on windows startup. If AFK auto startup is enabled" +
        " this will be enabled. Disable that first.");
            this.chk_overlay.UseVisualStyleBackColor = true;
            this.chk_overlay.CheckedChanged += new System.EventHandler(this.chk_overlay_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Staff Profile Overlay (Toggle Hide)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_profileOverlayExpandKey);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_profileOverlayKey);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(27, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 109);
            this.panel1.TabIndex = 13;
            // 
            // txt_profileOverlayExpandKey
            // 
            this.txt_profileOverlayExpandKey.Location = new System.Drawing.Point(4, 86);
            this.txt_profileOverlayExpandKey.Name = "txt_profileOverlayExpandKey";
            this.txt_profileOverlayExpandKey.ReadOnly = true;
            this.txt_profileOverlayExpandKey.Size = new System.Drawing.Size(100, 20);
            this.txt_profileOverlayExpandKey.TabIndex = 20;
            this.txt_profileOverlayExpandKey.Text = "S";
            this.txt_profileOverlayExpandKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Staff Profile Overlay (Toggle Expand)";
            // 
            // txt_profileOverlayKey
            // 
            this.txt_profileOverlayKey.Location = new System.Drawing.Point(4, 26);
            this.txt_profileOverlayKey.Name = "txt_profileOverlayKey";
            this.txt_profileOverlayKey.ReadOnly = true;
            this.txt_profileOverlayKey.Size = new System.Drawing.Size(100, 20);
            this.txt_profileOverlayKey.TabIndex = 16;
            this.txt_profileOverlayKey.Text = "S";
            this.txt_profileOverlayKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Modifier Key";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(144, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 55);
            this.label1.TabIndex = 15;
            this.label1.Text = "Modifier Key will be the key you also press when using these keys.";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(603, 348);
            this.Controls.Add(this.chk_overlay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chk_autoStartup);
            this.Controls.Add(this.chk_discordActivity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_overlayKey);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pnl_topBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.pnl_topBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_icon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_topBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox img_icon;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_overlayKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chk_discordActivity;
        private System.Windows.Forms.CheckBox chk_autoStartup;
        private System.Windows.Forms.ToolTip tip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_profileOverlayExpandKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_profileOverlayKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_overlay;
    }
}