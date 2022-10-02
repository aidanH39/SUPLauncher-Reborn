namespace SUPLauncher_Reborn
{
    partial class NoteFile
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
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbl_eval = new System.Windows.Forms.Label();
            this.pnl_left = new System.Windows.Forms.Panel();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lbl_eval);
            this.panel8.Controls.Add(this.pnl_left);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(227, 55);
            this.panel8.TabIndex = 1;
            // 
            // lbl_eval
            // 
            this.lbl_eval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_eval.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eval.Location = new System.Drawing.Point(4, 0);
            this.lbl_eval.Name = "lbl_eval";
            this.lbl_eval.Size = new System.Drawing.Size(223, 55);
            this.lbl_eval.TabIndex = 1;
            this.lbl_eval.Text = "Eval";
            this.lbl_eval.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_eval.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_eval_MouseClick);
            this.lbl_eval.MouseEnter += new System.EventHandler(this.lbl_eval_MouseEnter);
            this.lbl_eval.MouseLeave += new System.EventHandler(this.lbl_eval_MouseLeave);
            // 
            // pnl_left
            // 
            this.pnl_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(4, 55);
            this.pnl_left.TabIndex = 0;
            // 
            // EvalFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.panel8);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "EvalFile";
            this.Size = new System.Drawing.Size(227, 55);
            this.MouseEnter += new System.EventHandler(this.EvalFile_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.EvalFile_MouseLeave);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lbl_eval;
        private System.Windows.Forms.Panel pnl_left;
    }
}
