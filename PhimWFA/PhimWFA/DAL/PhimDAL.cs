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
            string truyvan = $"INSERT INTO " +
                $"[dbo].[Phim]([id], [ten], [theloai], [quocgia], [diemdanhgia]) " +
                $"VALUES ('{obj.Id}', '{obj.Ten}', '{obj.Theloai}', '{obj.Quocgia}', '{obj.DiemDanhGia}')";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = truyvan;

            base.GhiDuLieu(cmd);
        }


        public void CapNhatTTPhim(PhimDTO obj, object idPhim)
        {
            string truyvan = $"UPDATE [dbo].[Phim] " +
                $"SET [id] = '{obj.Id}', [ten] = '{obj.Ten}', [theloai] = '{obj.Theloai}', " +
                    $"[quocgia] = '{obj.Quocgia}', [diemdanhgia] = '{obj.DiemDanhGia}' " +
                $"WHERE [id] = '{idPhim}'";
                             
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = truyvan;

            base.GhiDuLieu(cmd);
        }

        public void XoaPhim(object idPhim)
        {
            string truyvan = $"DELETE FROM [dbo].[TTPhim] WHERE [id_phim] = '{idPhim}' " +
                $"DELETE FROM [dbo].[Phim] WHERE [id] = '{idPhim}'";

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

        public void XoaNhanVien(string idPhim)
        {
            string truyvan = $"DELETE FROM [dbo].[TTPhim] WHERE id_phim = '{idPhim}'";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = truyvan;

            base.GhiDuLieu(cmd);
        }

        public void CapNhatNhanVien(string idPhim, string idNV)
        {
            string truyvan = $"INSERT INTO [dbo].[TTPhim] VALUES ('{idPhim}', '{idNV}') ";
            

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = truyvan;

            base.GhiDuLieu(cmd);
        }

        public void XoaRap(string idPhim)
        {
            string truyvan = $"DELETE FROM [dbo].[TTRap] WHERE id_phim = '{idPhim}'";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = truyvan;

            base.GhiDuLieu(cmd);
        }

        public void CapNhatRap(string idPhim, string idRap)
        {
            string truyvan = $"INSERT INTO [dbo].[TTRap] VALUES ('{idPhim}', '{idRap}') ";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = truyvan;

            base.GhiDuLieu(cmd);
        }

    }
}
