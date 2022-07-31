
namespace SUPLauncher_Reborn
{
    partial class SitCount
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
            this.pnl_sits_total = new System.Windows.Forms.Panel();
            this.lbl_sits = new System.Windows.Forms.Label();
            this.lbl_sits_head = new System.Windows.Forms.Label();
            this.pnl_sits_total.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_sits_total
            // 
            this.pnl_sits_total.Controls.Add(this.lbl_sits);
            this.pnl_sits_total.Controls.Add(this.lbl_sits_head);
            this.pnl_sits_total.Location = new System.Drawing.Point(3, 3);
            this.pnl_sits_total.Name = "pnl_sits_total";
            this.pnl_sits_total.Size = new System.Drawing.Size(97, 56);
            this.pnl_sits_total.TabIndex = 1;
            // 
            // lbl_sits
            // 
            this.lbl_sits.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sits.ForeColor = System.Drawing.Color.White;
            this.lbl_sits.Location = new System.Drawing.Point(3, 24);
            this.lbl_sits.Name = "lbl_sits";
            this.lbl_sits.Size = new System.Drawing.Size(94, 23);
            this.lbl_sits.TabIndex = 1;
            this.lbl_sits.Text = "0";
            this.lbl_sits.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_sits_head
            // 
            this.lbl_sits_head.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sits_head.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbl_sits_head.Location = new System.Drawing.Point(3, 3);
            this.lbl_sits_head.Name = "lbl_sits_head";
            this.lbl_sits_head.Size = new System.Drawing.Size(94, 23);
            this.lbl_sits_head.TabIndex = 0;
            this.lbl_sits_head.Text = "TOTAL";
            this.lbl_sits_head.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SitCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.Controls.Add(this.pnl_sits_total);
            this.Name = "SitCount";
            this.Size = new System.Drawing.Size(106, 66);
            this.Load += new System.EventHandler(this.SitCount_Load);
            this.pnl_sits_total.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_sits_total;
        private System.Windows.Forms.Label lbl_sits;
        private System.Windows.Forms.Label lbl_sits_head;
    }
}
