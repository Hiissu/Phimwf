using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PhimWFA.BLL;
using PhimWFA.DTO;

namespace PhimWFA
{
    public partial class frmPhim : Form
    {
        public frmPhim()
        {
            InitializeComponent();
        }

        PhimBLL obj = new PhimBLL();
        private void frmMain_Load(object sender, EventArgs e)
        {
            grvPhim.DataSource = obj.HienThiTatCaPhim();
        }

        
        private void XoaDuLieuDaNhap()
        {
            tbIdPhim.Text = "";
            tbTenPhim.Text = "";
            cbTheLoai.Items.Clear();
            cbQuocGia.Items.Clear();
            cbNhanVien.Items.Clear();
            cbRapChieu.Items.Clear();
            tbDiemDanhGia.Text = "";
        }

        private void btnThemPhim_Click(object sender, EventArgs e)
        {
            PhimDTO p = new PhimDTO();

            if (tbIdPhim.Text.Length != 0)
            {
                try
                {
                    p.Id = tbIdPhim.Text;
                    p.Ten = tbTenPhim.Text;
                    p.Theloai = cbTheLoai.Text;
                    p.Quocgia = cbQuocGia.Text;
                    p.DiemDanhGia = Convert.ToDouble(tbDiemDanhGia.Text);

                    obj.ThemPhim(p);
                    MessageBox.Show("Thêm phim thành công.");
                    XoaDuLieuDaNhap();

                    grvPhim.DataSource = obj.HienThiTatCaPhim();

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
                p.Id = tbIdPhim.Text;
                p.Ten = tbTenPhim.Text;
                p.Theloai = cbTheLoai.Text;
                p.Quocgia = cbQuocGia.Text;
                p.DiemDanhGia = Convert.ToDouble(tbDiemDanhGia.Text);

                obj.ThemPhim(p);
                MessageBox.Show("Thêm phim thành công.");

                grvPhim.DataSource = obj.HienThiTatCaPhim();
                XoaDuLieuDaNhap();

            }
        }
        private void btXoaPhim_Click(object sender, EventArgs e)
        {
            if (tbIdPhim.Text != null)
            {
                obj.XoaPhim(tbIdPhim.Text);
                grvPhim.DataSource = obj.HienThiTatCaPhim();
                XoaDuLieuDaNhap();

            }
            else
            {
                MessageBox.Show("Hãy chọn phim cần xóa.");
            }
        }

       
        private void btSuaTTPhim_Click(object sender, EventArgs e)
        {
            if (tbIdPhim.Text != null)
            {
                PhimDTO p = new PhimDTO();
                p.Id = tbIdPhim.Text;
                p.Ten = tbTenPhim.Text;
                p.Theloai = cbTheLoai.Text;
                p.Quocgia = cbQuocGia.Text;
                p.DiemDanhGia = Convert.ToDouble(tbDiemDanhGia.Text);

                obj.CapNhatTTPhim(p, p.Id);
                MessageBox.Show("Cập nhật thành công.");

                grvPhim.DataSource = obj.HienThiTatCaPhim();
                XoaDuLieuDaNhap();
            }
            else
            {
                MessageBox.Show("Hãy chọn phim cần cập nhật.");
            }
        }
        private void grvPhim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grvPhim.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                grvPhim.CurrentRow.Selected = true;
                tbIdPhim.Text = grvPhim.Rows[e.RowIndex].Cells["IdPhim"].FormattedValue.ToString();
                tbTenPhim.Text = grvPhim.Rows[e.RowIndex].Cells["TenPhim"].FormattedValue.ToString();

                cbTheLoai.Items.Clear();
                cbQuocGia.Items.Clear();

                cbTheLoai.Items.Add(grvPhim.Rows[e.RowIndex].Cells["TheLoai"].FormattedValue.ToString());
                cbTheLoai.SelectedItem = cbTheLoai.Items[0];

                cbQuocGia.Items.Add(grvPhim.Rows[e.RowIndex].Cells["QuocGia"].FormattedValue.ToString());
                cbQuocGia.SelectedItem = cbQuocGia.Items[0];

                tbDiemDanhGia.Text = grvPhim.Rows[e.RowIndex].Cells["DiemDanhGia"].FormattedValue.ToString();

                cbNhanVien.Items.Clear();
                cbRapChieu.Items.Clear();

                DataTable dtnv = obj.HienThiTTNhanVien(tbIdPhim.Text);
                foreach (DataRow row in dtnv.Rows)
                {
                    cbNhanVien.Items.Add($"{row["TenNV"].ToString()} \t {row["ChucVu"].ToString()}");
                }

                DataTable dtr = obj.HienThiTTRap(tbIdPhim.Text);
                foreach (DataRow row in dtr.Rows)
                {
                    cbRapChieu.Items.Add($"{row["TenRap"].ToString()} \t {row["DiaChi"].ToString()}");
                }
            }
        }

        private void btCapNhatNV_Click(object sender, EventArgs e)
        {
            string idPhim = tbIdPhim.Text;
            frmCapNhatNV frmCapNhatNV = new frmCapNhatNV(idPhim);
            frmCapNhatNV.Show();
        }

        private void btCapNhatRap_Click(object sender, EventArgs e)
        {
            string idPhim = tbIdPhim.Text;
            frmCapNhatRap frmCapNhatRap = new frmCapNhatRap(idPhim);
            frmCapNhatRap.Show();
        }
    }
}
