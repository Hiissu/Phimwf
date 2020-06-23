namespace PhimWFA
{
    partial class frmRapPhim
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
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIdRap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btXoaRap = new System.Windows.Forms.Button();
            this.btThemRap = new System.Windows.Forms.Button();
            this.btSuaTTRap = new System.Windows.Forms.Button();
            this.tbTenRap = new System.Windows.Forms.TextBox();
            this.grvRap = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grvRap)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(239, 63);
            this.tbDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(369, 22);
            this.tbDiaChi.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 70;
            this.label3.Text = "Địa Chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 69;
            this.label2.Text = "Mã Rạp Phim";
            // 
            // tbIdRap
            // 
            this.tbIdRap.Location = new System.Drawing.Point(239, 11);
            this.tbIdRap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbIdRap.Name = "tbIdRap";
            this.tbIdRap.Size = new System.Drawing.Size(369, 22);
            this.tbIdRap.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 67;
            this.label1.Text = "Tên Rạp Phim";
            // 
            // btXoaRap
            // 
            this.btXoaRap.Location = new System.Drawing.Point(604, 94);
            this.btXoaRap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btXoaRap.Name = "btXoaRap";
            this.btXoaRap.Size = new System.Drawing.Size(92, 37);
            this.btXoaRap.TabIndex = 66;
            this.btXoaRap.Text = "Xóa";
            this.btXoaRap.UseVisualStyleBackColor = true;
            this.btXoaRap.Click += new System.EventHandler(this.btXoaRap_Click);
            // 
            // btThemRap
            // 
            this.btThemRap.Location = new System.Drawing.Point(506, 94);
            this.btThemRap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btThemRap.Name = "btThemRap";
            this.btThemRap.Size = new System.Drawing.Size(92, 37);
            this.btThemRap.TabIndex = 64;
            this.btThemRap.Text = "Thêm";
            this.btThemRap.UseVisualStyleBackColor = true;
            this.btThemRap.Click += new System.EventHandler(this.btThemRap_Click);
            // 
            // btSuaTTRap
            // 
            this.btSuaTTRap.Location = new System.Drawing.Point(701, 94);
            this.btSuaTTRap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSuaTTRap.Name = "btSuaTTRap";
            this.btSuaTTRap.Size = new System.Drawing.Size(92, 37);
            this.btSuaTTRap.TabIndex = 63;
            this.btSuaTTRap.Text = "Cập nhật";
            this.btSuaTTRap.UseVisualStyleBackColor = true;
            this.btSuaTTRap.Click += new System.EventHandler(this.btSuaTTRap_Click);
            // 
            // tbTenRap
            // 
            this.tbTenRap.Location = new System.Drawing.Point(239, 37);
            this.tbTenRap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTenRap.Name = "tbTenRap";
            this.tbTenRap.Size = new System.Drawing.Size(369, 22);
            this.tbTenRap.TabIndex = 62;
            // 
            // grvRap
            // 
            this.grvRap.AllowUserToOrderColumns = true;
            this.grvRap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvRap.Location = new System.Drawing.Point(15, 135);
            this.grvRap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grvRap.Name = "grvRap";
            this.grvRap.RowHeadersWidth = 51;
            this.grvRap.RowTemplate.Height = 24;
            this.grvRap.Size = new System.Drawing.Size(778, 330);
            this.grvRap.TabIndex = 61;
            this.grvRap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvRap_CellClick);
            // 
            // frmRapPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 478);
            this.Controls.Add(this.tbDiaChi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbIdRap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btXoaRap);
            this.Controls.Add(this.btThemRap);
            this.Controls.Add(this.btSuaTTRap);
            this.Controls.Add(this.tbTenRap);
            this.Controls.Add(this.grvRap);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRapPhim";
            this.Text = "RapPhim";
            this.Load += new System.EventHandler(this.frmRapPhim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvRap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIdRap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btXoaRap;
        private System.Windows.Forms.Button btThemRap;
        private System.Windows.Forms.Button btSuaTTRap;
        private System.Windows.Forms.TextBox tbTenRap;
        private System.Windows.Forms.DataGridView grvRap;
    }
}