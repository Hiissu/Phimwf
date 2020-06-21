using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PhimWFA.DTO;
namespace PhimWFA.DAL
{
    class PhimDAL : dbConnection
    {
        public DataTable HienThiTatCaPhim()
        {
            DataTable dtable = new DataTable();
            dtable = null;

            string truyvan = "SELECT id as IdPhim, ten as TenPhim, " +
                "theloai as TheLoai, quocgia as QuocGia, diemdanhgia as DiemDanhGia FROM dbo.Phim ";

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


        public void ThemPhim(PhimDTO obj)
        {
            string truyvan = "INSERT INTO [dbo].[Phim] ";
            truyvan += "([id]";
            truyvan += ",[ten]";
            truyvan += ",[theloai]";
            truyvan += ",[quocgia]";
            truyvan += ",[diemdanhgia]) ";
            truyvan += "VALUES ";
            truyvan += "('" + obj.Id;
            truyvan += "','" + obj.Ten;
            truyvan += "','" + obj.Theloai;
            truyvan += "','" + obj.Quocgia;
            truyvan += "','" + obj.DiemDanhGia + "')";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = truyvan;

            base.GhiDuLieu(cmd);
        }


        public void CapNhatTTPhim(PhimDTO obj, object idPhim)
        {
            string truyvan = " UPDATE [dbo].[Phim] SET ";
            truyvan += "[id] = '" + obj.Id;
            truyvan += "', [ten] = '" + obj.Ten;
            truyvan += "', [theloai] = '" + obj.Theloai;
            truyvan += "', [quocgia] = '" + obj.Quocgia;
            truyvan += "', [diemdanhgia] = '" + obj.DiemDanhGia;
            truyvan += "WHERE [id] = '" + idPhim + "'";
                             
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = truyvan;

            base.GhiDuLieu(cmd);
        }

        public void XoaPhim(object idPhim)
        {
            string truyvan = "DELETE FROM [dbo].[Phim] WHERE [id] = '" + idPhim + "'";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = truyvan;

            base.GhiDuLieu(cmd);
        }

        public void XoaTatCaPhim()
        {
            string truyvan = "DELETE FROM [dbo].[Phim]";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = truyvan;

            base.GhiDuLieu(cmd);
        }

        public DataTable HienThiTTNhanVien(string idPhim)
        {
            DataTable dtable = new DataTable();
            dtable = null;

            string truyvan = @"SELECT dbo.Nhanvien.ten as TenNV, dbo.Nhanvien.chucvu as ChucVu
                   FROM dbo.NhanVien INNER JOIN dbo.TTPhim ON dbo.NhanVien.id = dbo.TTPhim.id_nhanvien
                                    INNER JOIN dbo.Phim ON dbo.TTPhim.id_phim = dbo.Phim.id
                    WHERE dbo.Phim.id = '" + idPhim + "'";

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

        public DataTable HienThiTTRap(string idPhim)
        {
            DataTable dtable = new DataTable();
            dtable = null;

            string truyvan = @"SELECT dbo.Rap.ten as TenRap, dbo.Rap.diachi as DiaChi
                   FROM dbo.Rap INNER JOIN dbo.TTRap ON dbo.Rap.id = dbo.TTRap.id_rap
                                INNER JOIN dbo.Phim ON dbo.TTRap.id_phim = dbo.Phim.id
                    WHERE dbo.Phim.id = '" + idPhim + "'";

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

    }
}
