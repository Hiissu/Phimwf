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

            string truyvan = "SELECT id as IdNhanVien, ten as TenNhanVien, chucvu as ChucVu" +
                " FROM dbo.NhanVien";

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

        public void ThemNhanVien(NhanVienDTO obj)
        {
            string truyvan = $"INSERT INTO [dbo].[Nhanvien] VALUES " +
                $"('{obj.Id}', '{obj.Ten}', '{obj.Chucvu}')";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = truyvan;

            base.GhiDuLieu(cmd);
        }


        public void CapNhatTTNhanVien(NhanVienDTO obj, object idNV)
        {
            string truyvan = $" UPDATE [dbo].[NhanVien] SET [id] = '{obj.Id}', " +
                $" [ten] = '{obj.Ten}', [chucvu] = '{obj.Chucvu}'" +
                $" WHERE [id] = '{idNV}'";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = truyvan;

            base.GhiDuLieu(cmd);
        }

        public void XoaNhanVien(object idNV)
        {
            string truyvan = $"DELETE FROM [dbo].[TTPhim] WHERE [id_nhanvien] = '{idNV}' " +
                $"DELETE FROM [dbo].[NhanVien] WHERE [id] = '{idNV}'";

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
