using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PhimWFA.DTO;
using System.Data;
using System.Data.SqlClient;

namespace PhimWFA.DAL
{
    class NhanVienDAL : dbConnection
    {
        public DataTable HienThiTatCaNhanVien()
        {
            DataTable dtable = new DataTable();
            dtable = null;

            string truyvan = "SELECT * FROM dbo.NhanVien";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = truyvan;

            DataSet ds = base.DocDuLieu(cmd);
            if (dtable == null && ds.Tables.Count > 0)
            {
                dtable = ds.Tables[0];
            }

            return dtable;
        }


        public NhanVienDTO HienThiTTNhanVien(object idNV)
        {
            NhanVienDTO obj = new NhanVienDTO();
            string truyvan = "SELECT * FROM dbo.NhanVien WHERE id = " + idNV;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = truyvan;

            DataSet ds = base.DocDuLieu(cmd);
            DataRow drow = null;

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                drow = ds.Tables[0].Rows[0];
                obj.Ten = drow["Ten NV"].ToString();
                obj.Id = drow["Ma NV"].ToString();
                obj.Chucvu = drow["Chuc vu"].ToString();
            }

            return obj;
        }


        public void ThemNhanVien(NhanVienDTO obj)
        {
            string truyvan = "INSERT INTO[dbo].[NhanVien] ";
            truyvan += "([id]";
            truyvan += ",[ten]";
            truyvan += ",[chucvu] ";
            truyvan += "VALUES ";
            truyvan += "('" + obj.Id;
            truyvan += "','" + obj.Ten;
            truyvan += "','" + obj.Chucvu + "')";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = truyvan;

            base.GhiDuLieu(cmd);
        }


        public void CapNhatTTNhanVien(NhanVienDTO obj, object idNV)
        {
            string truyvan = " UPDATE [dbo].[NhanVien] SET ";
            truyvan += "[id] = '" + obj.Id;
            truyvan += "', [ten] = '" + obj.Ten;
            truyvan += "', [chucvu] = '" + obj.Chucvu;
            truyvan += "WHERE [id] = '" + idNV + "'";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = truyvan;

            base.GhiDuLieu(cmd);
        }

        public void XoaNhanVien(object idNV)
        {
            string truyvan = "DELETE FROM [dbo].[NhanVien] WHERE [id] = '" + idNV + "'";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = truyvan;

            base.GhiDuLieu(cmd);
        }

        public void XoaTatCaNhanVien()
        {
            string truyvan = "DELETE FROM [dbo].[NhanVien]";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = truyvan;

            base.GhiDuLieu(cmd);
        }

    }
}
