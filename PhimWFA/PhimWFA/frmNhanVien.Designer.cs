namespace PhimWFA
{
    partial class frmNhanVien
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
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIdNhanVien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btXoaNhanVien = new System.Windows.Forms.Button();
            this.btThemNhanVien = new System.Windows.Forms.Button();
            this.btSuaTTNhanVien = new System.Windows.Forms.Button();
            this.tbTenNhanVien = new System.Windows.Forms.TextBox();
            this.grvNhanVien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // cbChucVu
            // 
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Location = new System.Drawing.Point(306, 65);
            this.cbChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(269, 24);
            this.cbChucVu.TabIndex = 59;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(235, 69);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 54;
            this.label10.Text = "Chức vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // tbIdNhanVien
            // 
            this.tbIdNhanVien.Location = new System.Drawing.Point(306, 11);
            this.tbIdNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbIdNhanVien.Name = "tbIdNhanVien";
            this.tbIdNhanVien.Size = new System.Drawing.Size(269, 22);
            this.tbIdNhanVien.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Tên Nhân Viên";
            // 
            // btXoaNhanVien
            // 
            this.btXoaNhanVien.Location = new System.Drawing.Point(600, 99);
            this.btXoaNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btXoaNhanVien.Name = "btXoaNhanVien";
            this.btXoaNhanVien.Size = new System.Drawing.Size(92, 37);
            this.btXoaNhanVien.TabIndex = 40;
            this.btXoaNhanVien.Text = "Xóa";
            this.btXoaNhanVien.UseVisualStyleBackColor = true;
            this.btXoaNhanVien.Click += new System.EventHandler(this.btXoaNhanVien_Click);
            // 
            // btThemNhanVien
            // 
            this.btThemNhanVien.Location = new System.Drawing.Point(502, 99);
            this.btThemNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btThemNhanVien.Name = "btThemNhanVien";
            this.btThemNhanVien.Size = new System.Drawing.Size(92, 37);
            this.btThemNhanVien.TabIndex = 38;
            this.btThemNhanVien.Text = "Thêm";
            this.btThemNhanVien.UseVisualStyleBackColor = true;
            this.btThemNhanVien.Click += new System.EventHandler(this.btThemNhanVien_Click);
            // 
            // btSuaTTNhanVien
            // 
            this.btSuaTTNhanVien.Location = new System.Drawing.Point(698, 99);
            this.btSuaTTNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSuaTTNhanVien.Name = "btSuaTTNhanVien";
            this.btSuaTTNhanVien.Size = new System.Drawing.Size(92, 37);
            this.btSuaTTNhanVien.TabIndex = 37;
            this.btSuaTTNhanVien.Text = "Cập nhật";
            this.btSuaTTNhanVien.UseVisualStyleBackColor = true;
            this.btSuaTTNhanVien.Click += new System.EventHandler(this.btSuaTTNhanVien_Click);
            // 
            // tbTenNhanVien
            // 
            this.tbTenNhanVien.Location = new System.Drawing.Point(306, 37);
            this.tbTenNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTenNhanVien.Name = "tbTenNhanVien";
            this.tbTenNhanVien.Size = new System.Drawing.Size(269, 22);
            this.tbTenNhanVien.TabIndex = 36;
            // 
            // grvNhanVien
            // 
            this.grvNhanVien.AllowUserToOrderColumns = true;
            this.grvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvNhanVien.Location = new System.Drawing.Point(12, 140);
            this.grvNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grvNhanVien.Name = "grvNhanVien";
            this.grvNhanVien.RowHeadersWidth = 51;
            this.grvNhanVien.RowTemplate.Height = 24;
            this.grvNhanVien.Size = new System.Drawing.Size(778, 331);
            this.grvNhanVien.TabIndex = 35;
            this.grvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvNhanVien_CellClick);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 480);
            this.Controls.Add(this.cbChucVu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbIdNhanVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btXoaNhanVien);
            this.Controls.Add(this.btThemNhanVien);
            this.Controls.Add(this.btSuaTTNhanVien);
            this.Controls.Add(this.tbTenNhanVien);
            this.Controls.Add(this.grvNhanVien);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhanVien";
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIdNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btXoaNhanVien;
        private System.Windows.Forms.Button btThemNhanVien;
        private System.Windows.Forms.Button btSuaTTNhanVien;
        private System.Windows.Forms.TextBox tbTenNhanVien;
        private System.Windows.Forms.DataGridView grvNhanVien;
    }
}