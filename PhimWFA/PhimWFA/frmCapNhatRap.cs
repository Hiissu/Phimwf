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
    public partial class frmCapNhatRap : Form
    {
        public frmCapNhatRap(string idPhim)
        {
            InitializeComponent();
            tbIdPhim.Text = idPhim;
        }
        PhimBLL o = new PhimBLL();
        RapBLL obj = new RapBLL();
        private void frmCapNhatRap_Load(object sender, EventArgs e)
        {
            DataTable dtr = obj.HienThiTatCaRap();
            foreach (DataRow row in dtr.Rows)
            {
                clbRap.Items.Add($"{row["IdRap"].ToString()} : {row["TenRap"].ToString()} \t {row["DiaChi"].ToString()}");
            }
        }
        private void btCapNhatRap_Click(object sender, EventArgs e)
        {
            o.XoaRap(tbIdPhim.Text);
            foreach (var item in clbRap.CheckedItems)
            {
                o.CapNhatRap(tbIdPhim.Text, item.ToString().Split(':')[0].Trim());
            }
            MessageBox.Show("Cập nhật thành công.");

        }
    }
}
