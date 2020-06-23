namespace PhimWFA
{
    partial class frmPhim
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
            this.grvPhim = new System.Windows.Forms.DataGridView();
            this.tbTenPhim = new System.Windows.Forms.TextBox();
            this.btSuaTTPhim = new System.Windows.Forms.Button();
            this.btThemPhim = new System.Windows.Forms.Button();
            this.btXoaPhim = new System.Windows.Forms.Button();
            this.cbNhanVien = new System.Windows.Forms.ComboBox();
            this.tbIdPhim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDiemDanhGia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbTheLoai = new System.Windows.Forms.ComboBox();
            this.cbQuocGia = new System.Windows.Forms.ComboBox();
            this.cbRapChieu = new System.Windows.Forms.ComboBox();
            this.btCapNhatNV = new System.Windows.Forms.Button();
            this.btCapNhatRap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvPhim)).BeginInit();
            this.SuspendLayout();
            // 
            // grvPhim
            // 
            this.grvPhim.AllowUserToOrderColumns = true;
            this.grvPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvPhim.Location = new System.Drawing.Point(13, 176);
            this.grvPhim.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grvPhim.Name = "grvPhim";
            this.grvPhim.RowHeadersWidth = 51;
            this.grvPhim.RowTemplate.Height = 24;
            this.grvPhim.Size = new System.Drawing.Size(1108, 405);
            this.grvPhim.TabIndex = 1;
            this.grvPhim.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvPhim_CellClick);
            // 
            // tbTenPhim
            // 
            this.tbTenPhim.Location = new System.Drawing.Point(111, 51);
            this.tbTenPhim.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbTenPhim.Name = "tbTenPhim";
            this.tbTenPhim.Size = new System.Drawing.Size(410, 27);
            this.tbTenPhim.TabIndex = 4;
            // 
            // btSuaTTPhim
            // 
            this.btSuaTTPhim.Location = new System.Drawing.Point(1129, 226);
            this.btSuaTTPhim.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btSuaTTPhim.Name = "btSuaTTPhim";
            this.btSuaTTPhim.Size = new System.Drawing.Size(171, 46);
            this.btSuaTTPhim.TabIndex = 7;
            this.btSuaTTPhim.Text = "Cập Nhật Phim";
            this.btSuaTTPhim.UseVisualStyleBackColor = true;
            this.btSuaTTPhim.Click += new System.EventHandler(this.btSuaTTPhim_Click);
            // 
            // btThemPhim
            // 
            this.btThemPhim.Location = new System.Drawing.Point(1129, 176);
            this.btThemPhim.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btThemPhim.Name = "btThemPhim";
            this.btThemPhim.Size = new System.Drawing.Size(171, 46);
            this.btThemPhim.TabIndex = 8;
            this.btThemPhim.Text = "Thêm Phim";
            this.btThemPhim.UseVisualStyleBackColor = true;
            this.btThemPhim.Click += new System.EventHandler(this.btnThemPhim_Click);
            // 
            // btXoaPhim
            // 
            this.btXoaPhim.Location = new System.Drawing.Point(1131, 276);
            this.btXoaPhim.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btXoaPhim.Name = "btXoaPhim";
            this.btXoaPhim.Size = new System.Drawing.Size(169, 46);
            this.btXoaPhim.TabIndex = 10;
            this.btXoaPhim.Text = "Xóa Phim";
            this.btXoaPhim.UseVisualStyleBackColor = true;
            this.btXoaPhim.Click += new System.EventHandler(this.btXoaPhim_Click);
            // 
            // cbNhanVien
            // 
            this.cbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNhanVien.FormattingEnabled = true;
            this.cbNhanVien.Location = new System.Drawing.Point(702, 54);
            this.cbNhanVien.Margin = new System.Windows.Forms.Padding(5);
            this.cbNhanVien.Name = "cbNhanVien";
            this.cbNhanVien.Size = new System.Drawing.Size(410, 28);
            this.cbNhanVien.TabIndex = 35;
            // 
            // tbIdPhim
            // 
            this.tbIdPhim.Location = new System.Drawing.Point(111, 19);
            this.tbIdPhim.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbIdPhim.Name = "tbIdPhim";
            this.tbIdPhim.Size = new System.Drawing.Size(410, 27);
            this.tbIdPhim.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã Phim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Thể loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Quốc gia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tên Phim";
            // 
            // tbDiemDanhGia
            // 
            this.tbDiemDanhGia.Location = new System.Drawing.Point(702, 19);
            this.tbDiemDanhGia.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbDiemDanhGia.Name = "tbDiemDanhGia";
            this.tbDiemDanhGia.Size = new System.Drawing.Size(410, 27);
            this.tbDiemDanhGia.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(576, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Điểm đánh giá";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(606, 57);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Nhân Viên";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(565, 116);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "Rạp chiếu Phim";
            // 
            // cbTheLoai
            // 
            this.cbTheLoai.FormattingEnabled = true;
            this.cbTheLoai.Location = new System.Drawing.Point(111, 86);
            this.cbTheLoai.Margin = new System.Windows.Forms.Padding(5);
            this.cbTheLoai.Name = "cbTheLoai";
            this.cbTheLoai.Size = new System.Drawing.Size(410, 28);
            this.cbTheLoai.TabIndex = 31;
            // 
            // cbQuocGia
            // 
            this.cbQuocGia.FormattingEnabled = true;
            this.cbQuocGia.Location = new System.Drawing.Point(111, 121);
            this.cbQuocGia.Margin = new System.Windows.Forms.Padding(5);
            this.cbQuocGia.Name = "cbQuocGia";
            this.cbQuocGia.Size = new System.Drawing.Size(410, 28);
            this.cbQuocGia.TabIndex = 32;
            // 
            // cbRapChieu
            // 
            this.cbRapChieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRapChieu.FormattingEnabled = true;
            this.cbRapChieu.Location = new System.Drawing.Point(702, 113);
            this.cbRapChieu.Margin = new System.Windows.Forms.Padding(5);
            this.cbRapChieu.Name = "cbRapChieu";
            this.cbRapChieu.Size = new System.Drawing.Size(410, 28);
            this.cbRapChieu.TabIndex = 34;
            // 
            // btCapNhatNV
            // 
            this.btCapNhatNV.Location = new System.Drawing.Point(1131, 44);
            this.btCapNhatNV.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btCapNhatNV.Name = "btCapNhatNV";
            this.btCapNhatNV.Size = new System.Drawing.Size(169, 46);
            this.btCapNhatNV.TabIndex = 38;
            this.btCapNhatNV.Text = "Cập Nhật TT NV";
            this.btCapNhatNV.UseVisualStyleBackColor = true;
            this.btCapNhatNV.Click += new System.EventHandler(this.btCapNhatNV_Click);
            // 
            // btCapNhatRap
            // 
            this.btCapNhatRap.Location = new System.Drawing.Point(1131, 103);
            this.btCapNhatRap.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btCapNhatRap.Name = "btCapNhatRap";
            this.btCapNhatRap.Size = new System.Drawing.Size(169, 46);
            this.btCapNhatRap.TabIndex = 36;
            this.btCapNhatRap.Text = "Cập Nhật TT Rạp";
            this.btCapNhatRap.UseVisualStyleBackColor = true;
            this.btCapNhatRap.Click += new System.EventHandler(this.btCapNhatRap_Click);
            // 
            // frmPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 594);
            this.Controls.Add(this.btCapNhatNV);
            this.Controls.Add(this.btCapNhatRap);
            this.Controls.Add(this.cbNhanVien);
            this.Controls.Add(this.cbRapChieu);
            this.Controls.Add(this.cbQuocGia);
            this.Controls.Add(this.cbTheLoai);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbDiemDanhGia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbIdPhim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btXoaPhim);
            this.Controls.Add(this.btThemPhim);
            this.Controls.Add(this.btSuaTTPhim);
            this.Controls.Add(this.tbTenPhim);
            this.Controls.Add(this.grvPhim);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmPhim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phim";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvPhim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grvPhim;
        private System.Windows.Forms.TextBox tbTenPhim;
        private System.Windows.Forms.Button btSuaTTPhim;
        private System.Windows.Forms.Button btThemPhim;
        private System.Windows.Forms.Button btXoaPhim;
        private System.Windows.Forms.ComboBox cbNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDiemDanhGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbTheLoai;
        private System.Windows.Forms.ComboBox cbQuocGia;
        private System.Windows.Forms.ComboBox cbRapChieu;
        private System.Windows.Forms.Button btCapNhatNV;
        private System.Windows.Forms.Button btCapNhatRap;
        private System.Windows.Forms.TextBox tbIdPhim;
    }
}

