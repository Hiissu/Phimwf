namespace PhimWFA
{
    partial class frmCapNhatNV
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
            this.clbNhanVien = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIdPhim = new System.Windows.Forms.TextBox();
            this.btCapNhatNV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbNhanVien
            // 
            this.clbNhanVien.FormattingEnabled = true;
            this.clbNhanVien.Location = new System.Drawing.Point(13, 33);
            this.clbNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.clbNhanVien.Name = "clbNhanVien";
            this.clbNhanVien.ScrollAlwaysVisible = true;
            this.clbNhanVien.Size = new System.Drawing.Size(640, 202);
            this.clbNhanVien.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(672, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Phim";
            // 
            // tbIdPhim
            // 
            this.tbIdPhim.Location = new System.Drawing.Point(676, 31);
            this.tbIdPhim.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbIdPhim.Name = "tbIdPhim";
            this.tbIdPhim.ReadOnly = true;
            this.tbIdPhim.Size = new System.Drawing.Size(394, 27);
            this.tbIdPhim.TabIndex = 43;
            // 
            // btCapNhatNV
            // 
            this.btCapNhatNV.Location = new System.Drawing.Point(910, 62);
            this.btCapNhatNV.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btCapNhatNV.Name = "btCapNhatNV";
            this.btCapNhatNV.Size = new System.Drawing.Size(160, 46);
            this.btCapNhatNV.TabIndex = 44;
            this.btCapNhatNV.Text = "Cập nhật";
            this.btCapNhatNV.UseVisualStyleBackColor = true;
            this.btCapNhatNV.Click += new System.EventHandler(this.btCapNhatNV_Click);
            // 
            // frmCapNhatNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 255);
            this.Controls.Add(this.btCapNhatNV);
            this.Controls.Add(this.tbIdPhim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clbNhanVien);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCapNhatNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCapNhatNV";
            this.Load += new System.EventHandler(this.frmCapNhatNV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIdPhim;
        private System.Windows.Forms.Button btCapNhatNV;
    }
}