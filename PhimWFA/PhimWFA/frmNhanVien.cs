using PhimWFA.BLL;
using PhimWFA.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhimWFA
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        NhanVienBLL obj = new NhanVienBLL();
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            grvNhanVien.DataSource = obj.HienThiTatCaNhanVien();
        }
        private void XoaDuLieuDaNhap()
        {
            tbIdNhanVien.Text = "";
            tbTenNhanVien.Text = "";
            cbChucVu.Items.Clear();
            cbChucVu.Text = "";
        }
        private void btThemNhanVien_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO();

            if (tbIdNhanVien.Text != null)
            {
                try
                {
                    nv.Id = tbIdNhanVien.Text;
                    nv.Ten = tbTenNhanVien.Text;
                    nv.Chucvu = cbChucVu.Text;

                    obj.ThemNhanVien(nv);
                    MessageBox.Show("Thêm nhân viên thành công.");

                    grvNhanVien.DataSource = obj.HienThiTatCaNhanVien();
                    XoaDuLieuDaNhap();

                }
                catch (Exception)
                {
                    MessageBox.Show("Dữ liệu đã tồn tại hoặc không hợp lệ.");
                    return;
                    throw;
                }
            }
            else
            {
                nv.Id = tbIdNhanVien.Text;
                nv.Ten = tbTenNhanVien.Text;
                nv.Chucvu = cbChucVu.Text;

                obj.ThemNhanVien(nv);
                MessageBox.Show("Thêm nhân viên thành công.");

                grvNhanVien.DataSource = obj.HienThiTatCaNhanVien();
                XoaDuLieuDaNhap();

            }
        }

        private void btXoaNhanVien_Click(object sender, EventArgs e)
        {
            if (tbIdNhanVien.Text != null)
            {
                obj.XoaNhanVien(tbIdNhanVien.Text);
                grvNhanVien.DataSource = obj.HienThiTatCaNhanVien();
                XoaDuLieuDaNhap();
            }
            else
            {
                MessageBox.Show("Hãy chọn nhân viên cần xóa thông tin.");
            }
        }

        private void btSuaTTNhanVien_Click(object sender, EventArgs e)
        {
            if (tbIdNhanVien.Text != null)
            {
                NhanVienDTO nv = new NhanVienDTO();
                nv.Id = tbIdNhanVien.Text;
                nv.Ten = tbTenNhanVien.Text;
                nv.Chucvu = cbChucVu.Text;

                obj.CapNhatTTNhanVien(nv, nv.Id);
                MessageBox.Show("Cập nhật thành công.");

                grvNhanVien.DataSource = obj.HienThiTatCaNhanVien();
                XoaDuLieuDaNhap();
            }
            else
            {
                MessageBox.Show("Hãy chọn nhân viên cần cập nhật.");
            }
        }

        private void grvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grvNhanVien.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                grvNhanVien.CurrentRow.Selected = true;
                tbIdNhanVien.Text = grvNhanVien.Rows[e.RowIndex].Cells["IdNhanVien"].FormattedValue.ToString();
                tbTenNhanVien.Text = grvNhanVien.Rows[e.RowIndex].Cells["TenNhanVien"].FormattedValue.ToString();
                cbChucVu.Items.Clear();
                cbChucVu.Items.Add(grvNhanVien.Rows[e.RowIndex].Cells["ChucVu"].FormattedValue.ToString());
                cbChucVu.SelectedItem = cbChucVu.Items[0];

            }
        }
    }
}
