
namespace SUPLauncher_Reborn
{
    partial class UploadDupe
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.img_icon = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_dupeName = new System.Windows.Forms.TextBox();
            this.pnl_lookup = new System.Windows.Forms.Panel();
            this.lbl_lookup = new System.Windows.Forms.Label();
            this.pnl_indDupeName = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_indDescription = new System.Windows.Forms.Panel();
            this.txt_dupeDesc = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl_indVisibility = new System.Windows.Forms.Panel();
            this.combo_type = new System.Windows.Forms.ComboBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.btn_selectDupe = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_selectDupeHead = new System.Windows.Forms.Label();
            this.pnl_indDupeSelect = new System.Windows.Forms.Panel();
            this.btn_upload = new System.Windows.Forms.Button();
            this.fileDialog_dupe = new System.Windows.Forms.OpenFileDialog();
            this.fileDialog_image = new System.Windows.Forms.OpenFileDialog();
            this.pnl_topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_lookup.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_topBar
            // 
            this.pnl_topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pnl_topBar.Controls.Add(this.panel2);
            this.pnl_topBar.Controls.Add(this.lbl_title);
            this.pnl_topBar.Controls.Add(this.img_icon);
            this.pnl_topBar.Controls.Add(this.btn_close);
            this.pnl_topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_topBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_topBar.Name = "pnl_topBar";
            this.pnl_topBar.Size = new System.Drawing.Size(478, 35);
            this.pnl_topBar.TabIndex = 2;
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
            this.lbl_title.Size = new System.Drawing.Size(124, 26);
            this.lbl_title.TabIndex = 3;
            this.lbl_title.Text = "SUPLauncher";
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
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(443, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(35, 35);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "╳";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Upload Dupe To MarketPlace";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Screenshot (Click to change)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SUPLauncher_Reborn.Properties.Resources.dupe_default;
            this.pictureBox1.Location = new System.Drawing.Point(12, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_dupeName
            // 
            this.txt_dupeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txt_dupeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_dupeName.ForeColor = System.Drawing.Color.White;
            this.txt_dupeName.Location = new System.Drawing.Point(13, 279);
            this.txt_dupeName.Name = "txt_dupeName";
            this.txt_dupeName.Size = new System.Drawing.Size(218, 20);
            this.txt_dupeName.TabIndex = 7;
            // 
            // pnl_lookup
            // 
            this.pnl_lookup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnl_lookup.Controls.Add(this.lbl_lookup);
            this.pnl_lookup.Controls.Add(this.pnl_indDupeName);
            this.pnl_lookup.Location = new System.Drawing.Point(12, 250);
            this.pnl_lookup.Name = "pnl_lookup";
            this.pnl_lookup.Size = new System.Drawing.Size(219, 29);
            this.pnl_lookup.TabIndex = 8;
            // 
            // lbl_lookup
            // 
            this.lbl_lookup.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lookup.ForeColor = System.Drawing.Color.White;
            this.lbl_lookup.Location = new System.Drawing.Point(11, 1);
            this.lbl_lookup.Name = "lbl_lookup";
            this.lbl_lookup.Size = new System.Drawing.Size(156, 25);
            this.lbl_lookup.TabIndex = 1;
            this.lbl_lookup.Text = "Dupe Name";
            this.lbl_lookup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_indDupeName
            // 
            this.pnl_indDupeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(129)))), ((int)(((byte)(255)))));
            this.pnl_indDupeName.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_indDupeName.Location = new System.Drawing.Point(0, 0);
            this.pnl_indDupeName.Name = "pnl_indDupeName";
            this.pnl_indDupeName.Size = new System.Drawing.Size(5, 29);
            this.pnl_indDupeName.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pnl_indDescription);
            this.panel1.Location = new System.Drawing.Point(12, 305);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 29);
            this.panel1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(420, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Description (Can use markdown for formatting)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_indDescription
            // 
            this.pnl_indDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(129)))), ((int)(((byte)(255)))));
            this.pnl_indDescription.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_indDescription.Location = new System.Drawing.Point(0, 0);
            this.pnl_indDescription.Name = "pnl_indDescription";
            this.pnl_indDescription.Size = new System.Drawing.Size(5, 29);
            this.pnl_indDescription.TabIndex = 0;
            // 
            // txt_dupeDesc
            // 
            this.txt_dupeDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txt_dupeDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_dupeDesc.ForeColor = System.Drawing.Color.White;
            this.txt_dupeDesc.Location = new System.Drawing.Point(15, 334);
            this.txt_dupeDesc.Name = "txt_dupeDesc";
            this.txt_dupeDesc.Size = new System.Drawing.Size(438, 129);
            this.txt_dupeDesc.TabIndex = 11;
            this.txt_dupeDesc.Text = "";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.pnl_indVisibility);
            this.panel4.Location = new System.Drawing.Point(15, 469);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(219, 29);
            this.panel4.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Visibility";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_indVisibility
            // 
            this.pnl_indVisibility.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(129)))), ((int)(((byte)(255)))));
            this.pnl_indVisibility.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_indVisibility.Location = new System.Drawing.Point(0, 0);
            this.pnl_indVisibility.Name = "pnl_indVisibility";
            this.pnl_indVisibility.Size = new System.Drawing.Size(5, 29);
            this.pnl_indVisibility.TabIndex = 0;
            // 
            // combo_type
            // 
            this.combo_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.combo_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_type.ForeColor = System.Drawing.Color.White;
            this.combo_type.FormattingEnabled = true;
            this.combo_type.Items.AddRange(new object[] {
            "Public",
            "Private"});
            this.combo_type.Location = new System.Drawing.Point(16, 498);
            this.combo_type.Name = "combo_type";
            this.combo_type.Size = new System.Drawing.Size(218, 21);
            this.combo_type.TabIndex = 12;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.ForeColor = System.Drawing.Color.White;
            this.richTextBox2.Location = new System.Drawing.Point(240, 470);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(213, 82);
            this.richTextBox2.TabIndex = 13;
            this.richTextBox2.Text = "Public - Will be shown & downloadable on the marketplace to everyone.\n\nPrivate - " +
    "Will not be shown on the marketplace, and you chose who has access.";
            // 
            // btn_selectDupe
            // 
            this.btn_selectDupe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btn_selectDupe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.btn_selectDupe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_selectDupe.ForeColor = System.Drawing.Color.White;
            this.btn_selectDupe.Location = new System.Drawing.Point(15, 554);
            this.btn_selectDupe.Name = "btn_selectDupe";
            this.btn_selectDupe.Size = new System.Drawing.Size(219, 34);
            this.btn_selectDupe.TabIndex = 14;
            this.btn_selectDupe.Text = "Choose Dupe";
            this.btn_selectDupe.UseVisualStyleBackColor = false;
            this.btn_selectDupe.Click += new System.EventHandler(this.btn_selectDupe_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel6.Controls.Add(this.lbl_selectDupeHead);
            this.panel6.Controls.Add(this.pnl_indDupeSelect);
            this.panel6.Location = new System.Drawing.Point(15, 525);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(218, 29);
            this.panel6.TabIndex = 9;
            // 
            // lbl_selectDupeHead
            // 
            this.lbl_selectDupeHead.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selectDupeHead.ForeColor = System.Drawing.Color.White;
            this.lbl_selectDupeHead.Location = new System.Drawing.Point(11, 1);
            this.lbl_selectDupeHead.Name = "lbl_selectDupeHead";
            this.lbl_selectDupeHead.Size = new System.Drawing.Size(204, 25);
            this.lbl_selectDupeHead.TabIndex = 1;
            this.lbl_selectDupeHead.Text = "Select Dupe (None Selected)";
            this.lbl_selectDupeHead.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_indDupeSelect
            // 
            this.pnl_indDupeSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(129)))), ((int)(((byte)(255)))));
            this.pnl_indDupeSelect.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_indDupeSelect.Location = new System.Drawing.Point(0, 0);
            this.pnl_indDupeSelect.Name = "pnl_indDupeSelect";
            this.pnl_indDupeSelect.Size = new System.Drawing.Size(5, 29);
            this.pnl_indDupeSelect.TabIndex = 0;
            // 
            // btn_upload
            // 
            this.btn_upload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btn_upload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.btn_upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_upload.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_upload.ForeColor = System.Drawing.Color.White;
            this.btn_upload.Location = new System.Drawing.Point(10, 612);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(456, 34);
            this.btn_upload.TabIndex = 15;
            this.btn_upload.Text = "Upload dupe";
            this.btn_upload.UseVisualStyleBackColor = false;
            this.btn_upload.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileDialog_dupe
            // 
            this.fileDialog_dupe.Filter = "txt files(*.txt) | *.txt*";
            this.fileDialog_dupe.Title = "Select dupe to upload...";
            this.fileDialog_dupe.FileOk += new System.ComponentModel.CancelEventHandler(this.fileDialog_dupe_FileOk);
            // 
            // fileDialog_image
            // 
            this.fileDialog_image.Filter = "Image Files|*.jpg;*.jpeg;*.png;...";
            this.fileDialog_image.Title = "Select image to upload...";
            this.fileDialog_image.FileOk += new System.ComponentModel.CancelEventHandler(this.fileDialog_image_FileOk);
            // 
            // UploadDupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SUPLauncher_Reborn.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(478, 658);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.btn_selectDupe);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.combo_type);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txt_dupeDesc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_lookup);
            this.Controls.Add(this.txt_dupeName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_topBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UploadDupe";
            this.Text = "UploadDupe";
            this.pnl_topBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_lookup.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_topBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox img_icon;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_dupeName;
        private System.Windows.Forms.Panel pnl_lookup;
        private System.Windows.Forms.Label lbl_lookup;
        private System.Windows.Forms.Panel pnl_indDupeName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnl_indDescription;
        private System.Windows.Forms.RichTextBox txt_dupeDesc;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnl_indVisibility;
        private System.Windows.Forms.ComboBox combo_type;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button btn_selectDupe;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_selectDupeHead;
        private System.Windows.Forms.Panel pnl_indDupeSelect;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.OpenFileDialog fileDialog_dupe;
        private System.Windows.Forms.OpenFileDialog fileDialog_image;
    }
}