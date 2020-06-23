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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btQlyPhim_Click(object sender, EventArgs e)
        {
            frmPhim frmPhim = new frmPhim();
            frmPhim.Show();
        }

        private void btQlyNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frmNhanVien = new frmNhanVien();
            frmNhanVien.Show();
        }

        private void btQlyRap_Click(object sender, EventArgs e)
        {
            frmRapPhim frmRapPhim = new frmRapPhim();
            frmRapPhim.Show();
        }
    }
}
