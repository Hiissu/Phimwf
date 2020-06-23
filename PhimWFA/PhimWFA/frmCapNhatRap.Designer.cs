namespace PhimWFA
{
    partial class frmCapNhatRap
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
            this.btCapNhatRap = new System.Windows.Forms.Button();
            this.tbIdPhim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clbRap = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btCapNhatRap
            // 
            this.btCapNhatRap.Location = new System.Drawing.Point(914, 64);
            this.btCapNhatRap.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btCapNhatRap.Name = "btCapNhatRap";
            this.btCapNhatRap.Size = new System.Drawing.Size(160, 46);
            this.btCapNhatRap.TabIndex = 49;
            this.btCapNhatRap.Text = "Cập nhật";
            this.btCapNhatRap.UseVisualStyleBackColor = true;
            this.btCapNhatRap.Click += new System.EventHandler(this.btCapNhatRap_Click);
            // 
            // tbIdPhim
            // 
            this.tbIdPhim.Location = new System.Drawing.Point(680, 33);
            this.tbIdPhim.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbIdPhim.Name = "tbIdPhim";
            this.tbIdPhim.ReadOnly = true;
            this.tbIdPhim.Size = new System.Drawing.Size(394, 27);
            this.tbIdPhim.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(675, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Mã Phim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Danh sách rạp";
            // 
            // clbRap
            // 
            this.clbRap.FormattingEnabled = true;
            this.clbRap.Location = new System.Drawing.Point(13, 33);
            this.clbRap.Margin = new System.Windows.Forms.Padding(4);
            this.clbRap.Name = "clbRap";
            this.clbRap.ScrollAlwaysVisible = true;
            this.clbRap.Size = new System.Drawing.Size(640, 202);
            this.clbRap.TabIndex = 45;
            // 
            // frmCapNhatRap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 255);
            this.Controls.Add(this.btCapNhatRap);
            this.Controls.Add(this.tbIdPhim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clbRap);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCapNhatRap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCapNhatRap";
            this.Load += new System.EventHandler(this.frmCapNhatRap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCapNhatRap;
        private System.Windows.Forms.TextBox tbIdPhim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbRap;
    }
}