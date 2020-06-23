namespace PhimWFA
{
    partial class frmHome
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
            this.btQlyPhim = new System.Windows.Forms.Button();
            this.btQlyNhanVien = new System.Windows.Forms.Button();
            this.btQlyRap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btQlyPhim
            // 
            this.btQlyPhim.Location = new System.Drawing.Point(34, 114);
            this.btQlyPhim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btQlyPhim.Name = "btQlyPhim";
            this.btQlyPhim.Size = new System.Drawing.Size(250, 94);
            this.btQlyPhim.TabIndex = 0;
            this.btQlyPhim.Text = "Quản lý Phim";
            this.btQlyPhim.UseVisualStyleBackColor = true;
            this.btQlyPhim.Click += new System.EventHandler(this.btQlyPhim_Click);
            // 
            // btQlyNhanVien
            // 
            this.btQlyNhanVien.Location = new System.Drawing.Point(375, 114);
            this.btQlyNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btQlyNhanVien.Name = "btQlyNhanVien";
            this.btQlyNhanVien.Size = new System.Drawing.Size(250, 94);
            this.btQlyNhanVien.TabIndex = 1;
            this.btQlyNhanVien.Text = "Quản lý Nhân viên";
            this.btQlyNhanVien.UseVisualStyleBackColor = true;
            this.btQlyNhanVien.Click += new System.EventHandler(this.btQlyNhanVien_Click);
            // 
            // btQlyRap
            // 
            this.btQlyRap.Location = new System.Drawing.Point(719, 114);
            this.btQlyRap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btQlyRap.Name = "btQlyRap";
            this.btQlyRap.Size = new System.Drawing.Size(250, 94);
            this.btQlyRap.TabIndex = 2;
            this.btQlyRap.Text = "Quản lý Rạp phim";
            this.btQlyRap.UseVisualStyleBackColor = true;
            this.btQlyRap.Click += new System.EventHandler(this.btQlyRap_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 336);
            this.Controls.Add(this.btQlyRap);
            this.Controls.Add(this.btQlyNhanVien);
            this.Controls.Add(this.btQlyPhim);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btQlyPhim;
        private System.Windows.Forms.Button btQlyNhanVien;
        private System.Windows.Forms.Button btQlyRap;
    }
}