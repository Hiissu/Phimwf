using PhimWFA.BLL;
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
    public partial class frmCapNhatNV : Form
    {
        public frmCapNhatNV(string idPhim)
        {
            InitializeComponent();
            tbIdPhim.Text = idPhim;
        }
        PhimBLL o = new PhimBLL();
        NhanVienBLL obj = new NhanVienBLL();
        private void frmCapNhatNV_Load(object sender, EventArgs e)
        {
            DataTable dtnv = obj.HienThiTatCaNhanVien();
            foreach (DataRow row in dtnv.Rows)
            {
                clbNhanVien.Items.Add($"{row["IdNhanVien"].ToString()} : {row["TenNhanVien"].ToString()} \t {row["ChucVu"].ToString()}");
            }
        }

        private void btCapNhatNV_Click(object sender, EventArgs e)
        {
            o.XoaNhanVien(tbIdPhim.Text);
            foreach (var item in clbNhanVien.CheckedItems)
            {
                o.CapNhatNhanVien(tbIdPhim.Text, item.ToString().Split(':')[0].Trim());
            }
            MessageBox.Show("Cập nhật thành công.");

        }
    }
}
