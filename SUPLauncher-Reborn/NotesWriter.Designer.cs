namespace SUPLauncher_Reborn
{
    partial class NotesWriter
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
            this.lbl_autosave = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.img_icon = new System.Windows.Forms.PictureBox();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.txt_content = new System.Windows.Forms.RichTextBox();
            this.pnl_wrapper = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnl_toolbar = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_bold = new System.Windows.Forms.Button();
            this.btn_italic = new System.Windows.Forms.Button();
            this.btn_underline = new System.Windows.Forms.Button();
            this.btn_strike = new System.Windows.Forms.Button();
            this.btn_bullets = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            this.tmr_autoSave = new System.Windows.Forms.Timer(this.components);
            this.pnl_leftLoad = new System.Windows.Forms.Panel();
            this.pnl_load = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.content_color = new System.Windows.Forms.ColorDialog();
            this.txt_fontSize = new System.Windows.Forms.TextBox();
            this.pnl_topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_icon)).BeginInit();
            this.pnl_wrapper.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_toolbar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnl_leftLoad.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_topBar
            // 
            this.pnl_topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pnl_topBar.Controls.Add(this.lbl_autosave);
            this.pnl_topBar.Controls.Add(this.panel2);
            this.pnl_topBar.Controls.Add(this.lbl_title);
            this.pnl_topBar.Controls.Add(this.img_icon);
            this.pnl_topBar.Controls.Add(this.btn_minimize);
            this.pnl_topBar.Controls.Add(this.btn_close);
            this.pnl_topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_topBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_topBar.Name = "pnl_topBar";
            this.pnl_topBar.Size = new System.Drawing.Size(634, 35);
            this.pnl_topBar.TabIndex = 2;
            // 
            // lbl_autosave
            // 
            this.lbl_autosave.AutoSize = true;
            this.lbl_autosave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbl_autosave.Location = new System.Drawing.Point(100, 11);
            this.lbl_autosave.Name = "lbl_autosave";
            this.lbl_autosave.Size = new System.Drawing.Size(174, 13);
            this.lbl_autosave.TabIndex = 8;
            this.lbl_autosave.Text = "Autosave is not enabled. Save first.";
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
            this.lbl_title.Size = new System.Drawing.Size(99, 26);
            this.lbl_title.TabIndex = 3;
            this.lbl_title.Text = "Notes";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btn_minimize.Location = new System.Drawing.Point(564, 0);
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
            this.btn_close.Location = new System.Drawing.Point(599, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(35, 35);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "╳";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txt_content
            // 
            this.txt_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txt_content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_content.EnableAutoDragDrop = true;
            this.txt_content.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txt_content.HideSelection = false;
            this.txt_content.Location = new System.Drawing.Point(10, 43);
            this.txt_content.Name = "txt_content";
            this.txt_content.ShowSelectionMargin = true;
            this.txt_content.Size = new System.Drawing.Size(594, 244);
            this.txt_content.TabIndex = 3;
            this.txt_content.Text = "";
            this.txt_content.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
            this.txt_content.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_content_KeyDown);
            this.txt_content.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_content_KeyUp);
            // 
            // pnl_wrapper
            // 
            this.pnl_wrapper.BackColor = System.Drawing.Color.Transparent;
            this.pnl_wrapper.Controls.Add(this.btn_save);
            this.pnl_wrapper.Controls.Add(this.txt_name);
            this.pnl_wrapper.Controls.Add(this.btn_load);
            this.pnl_wrapper.Controls.Add(this.panel1);
            this.pnl_wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_wrapper.Location = new System.Drawing.Point(0, 35);
            this.pnl_wrapper.Name = "pnl_wrapper";
            this.pnl_wrapper.Padding = new System.Windows.Forms.Padding(10, 40, 10, 10);
            this.pnl_wrapper.Size = new System.Drawing.Size(634, 342);
            this.pnl_wrapper.TabIndex = 4;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(543, 11);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(81, 23);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_name
            // 
            this.txt_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txt_name.Location = new System.Drawing.Point(390, 13);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(151, 20);
            this.txt_name.TabIndex = 6;
            this.txt_name.Text = "Name";
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btn_load.FlatAppearance.BorderSize = 0;
            this.btn_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_load.ForeColor = System.Drawing.Color.White;
            this.btn_load.Location = new System.Drawing.Point(10, 11);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(101, 23);
            this.btn_load.TabIndex = 5;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.txt_content);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pnl_toolbar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 40);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.panel1.Size = new System.Drawing.Size(614, 292);
            this.panel1.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 33);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(594, 10);
            this.panel4.TabIndex = 5;
            // 
            // pnl_toolbar
            // 
            this.pnl_toolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.pnl_toolbar.Controls.Add(this.flowLayoutPanel1);
            this.pnl_toolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_toolbar.Location = new System.Drawing.Point(10, 5);
            this.pnl_toolbar.Name = "pnl_toolbar";
            this.pnl_toolbar.Size = new System.Drawing.Size(594, 28);
            this.pnl_toolbar.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_bold);
            this.flowLayoutPanel1.Controls.Add(this.btn_italic);
            this.flowLayoutPanel1.Controls.Add(this.btn_underline);
            this.flowLayoutPanel1.Controls.Add(this.btn_strike);
            this.flowLayoutPanel1.Controls.Add(this.btn_bullets);
            this.flowLayoutPanel1.Controls.Add(this.btn_color);
            this.flowLayoutPanel1.Controls.Add(this.txt_fontSize);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(594, 28);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btn_bold
            // 
            this.btn_bold.FlatAppearance.BorderSize = 0;
            this.btn_bold.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn_bold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bold.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bold.ForeColor = System.Drawing.Color.White;
            this.btn_bold.Location = new System.Drawing.Point(3, 3);
            this.btn_bold.Name = "btn_bold";
            this.btn_bold.Size = new System.Drawing.Size(29, 23);
            this.btn_bold.TabIndex = 0;
            this.btn_bold.Text = "B";
            this.btn_bold.UseVisualStyleBackColor = true;
            this.btn_bold.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_italic
            // 
            this.btn_italic.FlatAppearance.BorderSize = 0;
            this.btn_italic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn_italic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_italic.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_italic.ForeColor = System.Drawing.Color.White;
            this.btn_italic.Location = new System.Drawing.Point(38, 3);
            this.btn_italic.Name = "btn_italic";
            this.btn_italic.Size = new System.Drawing.Size(29, 23);
            this.btn_italic.TabIndex = 1;
            this.btn_italic.Text = "I";
            this.btn_italic.UseVisualStyleBackColor = true;
            this.btn_italic.Click += new System.EventHandler(this.btn_italic_Click);
            // 
            // btn_underline
            // 
            this.btn_underline.FlatAppearance.BorderSize = 0;
            this.btn_underline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn_underline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_underline.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_underline.ForeColor = System.Drawing.Color.White;
            this.btn_underline.Location = new System.Drawing.Point(73, 3);
            this.btn_underline.Name = "btn_underline";
            this.btn_underline.Size = new System.Drawing.Size(29, 23);
            this.btn_underline.TabIndex = 2;
            this.btn_underline.Text = "U";
            this.btn_underline.UseVisualStyleBackColor = true;
            this.btn_underline.Click += new System.EventHandler(this.btn_underline_Click);
            // 
            // btn_strike
            // 
            this.btn_strike.FlatAppearance.BorderSize = 0;
            this.btn_strike.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn_strike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_strike.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_strike.ForeColor = System.Drawing.Color.White;
            this.btn_strike.Location = new System.Drawing.Point(108, 3);
            this.btn_strike.Name = "btn_strike";
            this.btn_strike.Size = new System.Drawing.Size(29, 23);
            this.btn_strike.TabIndex = 4;
            this.btn_strike.Text = "S";
            this.btn_strike.UseVisualStyleBackColor = true;
            this.btn_strike.Click += new System.EventHandler(this.btn_strike_Click);
            // 
            // btn_bullets
            // 
            this.btn_bullets.FlatAppearance.BorderSize = 0;
            this.btn_bullets.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn_bullets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bullets.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bullets.ForeColor = System.Drawing.Color.White;
            this.btn_bullets.Location = new System.Drawing.Point(143, 3);
            this.btn_bullets.Name = "btn_bullets";
            this.btn_bullets.Size = new System.Drawing.Size(29, 23);
            this.btn_bullets.TabIndex = 5;
            this.btn_bullets.Text = "●";
            this.btn_bullets.UseVisualStyleBackColor = true;
            this.btn_bullets.Click += new System.EventHandler(this.btn_bullets_Click);
            // 
            // btn_color
            // 
            this.btn_color.BackColor = System.Drawing.Color.White;
            this.btn_color.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_color.FlatAppearance.BorderSize = 5;
            this.btn_color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_color.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_color.ForeColor = System.Drawing.Color.White;
            this.btn_color.Location = new System.Drawing.Point(178, 3);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(29, 23);
            this.btn_color.TabIndex = 3;
            this.btn_color.UseVisualStyleBackColor = false;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // tmr_autoSave
            // 
            this.tmr_autoSave.Enabled = true;
            this.tmr_autoSave.Interval = 5000;
            this.tmr_autoSave.Tick += new System.EventHandler(this.tmr_autoSave_Tick);
            // 
            // pnl_leftLoad
            // 
            this.pnl_leftLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.pnl_leftLoad.Controls.Add(this.pnl_load);
            this.pnl_leftLoad.Controls.Add(this.panel6);
            this.pnl_leftLoad.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_leftLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnl_leftLoad.Location = new System.Drawing.Point(0, 35);
            this.pnl_leftLoad.Name = "pnl_leftLoad";
            this.pnl_leftLoad.Size = new System.Drawing.Size(0, 342);
            this.pnl_leftLoad.TabIndex = 5;
            // 
            // pnl_load
            // 
            this.pnl_load.AutoScroll = true;
            this.pnl_load.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_load.Location = new System.Drawing.Point(0, 42);
            this.pnl_load.Name = "pnl_load";
            this.pnl_load.Padding = new System.Windows.Forms.Padding(10);
            this.pnl_load.Size = new System.Drawing.Size(0, 300);
            this.pnl_load.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(10);
            this.panel6.Size = new System.Drawing.Size(0, 42);
            this.panel6.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(129)))), ((int)(((byte)(255)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(10, 10);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(4, 22);
            this.panel7.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Open";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // content_color
            // 
            this.content_color.AnyColor = true;
            this.content_color.Color = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.content_color.SolidColorOnly = true;
            // 
            // txt_fontSize
            // 
            this.txt_fontSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txt_fontSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fontSize.ForeColor = System.Drawing.Color.White;
            this.txt_fontSize.Location = new System.Drawing.Point(213, 3);
            this.txt_fontSize.MaxLength = 3;
            this.txt_fontSize.Name = "txt_fontSize";
            this.txt_fontSize.Size = new System.Drawing.Size(41, 20);
            this.txt_fontSize.TabIndex = 6;
            this.txt_fontSize.Text = "12";
            this.txt_fontSize.TextChanged += new System.EventHandler(this.txt_fontSize_TextChanged);
            // 
            // NotesWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SUPLauncher_Reborn.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 377);
            this.Controls.Add(this.pnl_wrapper);
            this.Controls.Add(this.pnl_leftLoad);
            this.Controls.Add(this.pnl_topBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotesWriter";
            this.Text = "Notes";
            this.pnl_topBar.ResumeLayout(false);
            this.pnl_topBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_icon)).EndInit();
            this.pnl_wrapper.ResumeLayout(false);
            this.pnl_wrapper.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnl_toolbar.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.pnl_leftLoad.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_topBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox img_icon;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.RichTextBox txt_content;
        private System.Windows.Forms.Panel pnl_wrapper;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnl_toolbar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_bold;
        private System.Windows.Forms.Button btn_italic;
        private System.Windows.Forms.Button btn_underline;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Timer tmr_autoSave;
        private System.Windows.Forms.Label lbl_autosave;
        private System.Windows.Forms.Panel pnl_leftLoad;
        private System.Windows.Forms.FlowLayoutPanel pnl_load;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.ColorDialog content_color;
        private System.Windows.Forms.Button btn_strike;
        private System.Windows.Forms.Button btn_bullets;
        private System.Windows.Forms.TextBox txt_fontSize;
    }
}