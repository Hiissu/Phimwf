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
    public partial class frmRapPhim : Form
    {
        public frmRapPhim()
        {
            InitializeComponent();
        }
        RapBLL obj = new RapBLL();
        private void frmRapPhim_Load(object sender, EventArgs e)
        {
            grvRap.DataSource = obj.HienThiTatCaRap();

        }
        private void XoaDuLieuDaNhap()
        {
            tbIdRap.Text = "";
            tbTenRap.Text = "";
            tbDiaChi.Text = "";
        }
        private void btThemRap_Click(object sender, EventArgs e)
        {
            RapDTO r = new RapDTO();

            if (tbIdRap.Text != null)
            {
                try
                {
                    r.Id = tbIdRap.Text;
                    r.Ten = tbTenRap.Text;
                    r.Diachi = tbDiaChi.Text;

                    obj.ThemRap(r);
                    MessageBox.Show("Thêm rạp thành công.");
                    XoaDuLieuDaNhap();
                    grvRap.DataSource = obj.HienThiTatCaRap();

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
                r.Id = tbIdRap.Text;
                r.Ten = tbTenRap.Text;
                r.Diachi = tbDiaChi.Text;

                obj.ThemRap(r);
                MessageBox.Show("Thêm rạp thành công.");

                grvRap.DataSource = obj.HienThiTatCaRap();
                XoaDuLieuDaNhap();
            }
        }

        private void btXoaRap_Click(object sender, EventArgs e)
        {
            if (tbIdRap.Text != null)
            {
                obj.XoaRap(tbIdRap.Text);
                grvRap.DataSource = obj.HienThiTatCaRap();
                XoaDuLieuDaNhap();
            }
            MessageBox.Show("Hãy chọn rạp cần xóa.");

        }

        private void btSuaTTRap_Click(object sender, EventArgs e)
        {
            if (tbIdRap.Text != null)
            {
                RapDTO r = new RapDTO();
                r.Id = tbIdRap.Text;
                r.Ten = tbTenRap.Text;
                r.Diachi = tbDiaChi.Text;

                obj.CapNhatTTRap(r, r.Id);
                MessageBox.Show("Cập nhật thành công.");

                grvRap.DataSource = obj.HienThiTatCaRap();
                XoaDuLieuDaNhap();
            }
            else
            {
                MessageBox.Show("Hãy chọn rạp cần cập nhật.");
            }
        }

        private void grvRap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grvRap.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                grvRap.CurrentRow.Selected = true;
                tbIdRap.Text = grvRap.Rows[e.RowIndex].Cells["IdRap"].FormattedValue.ToString();
                tbTenRap.Text = grvRap.Rows[e.RowIndex].Cells["TenRap"].FormattedValue.ToString();
                tbDiaChi.Text = grvRap.Rows[e.RowIndex].Cells["DiaChi"].FormattedValue.ToString();

            }
        }
    }
}
