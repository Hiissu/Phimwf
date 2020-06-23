using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhimWFA.DAL;
using System.Data;
using System.Data.SqlClient;

using PhimWFA.DTO;
namespace PhimWFA.DAL 
{
    class RapDAL : dbConnection
    {
        public DataTable HienThiTatCaRap()
        {
            DataTable dtable = new DataTable();
            dtable = null;

            string truyvan = "SELECT id as IdRap, ten as TenRap, diachi as DiaChi FROM dbo.Rap "; 

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

        public void ThemRap(RapDTO obj)
        {
            string truyvan = $"INSERT INTO [dbo].[Rap] VALUES " +
                $"('{obj.Id}', '{obj.Ten}', '{obj.Diachi}')";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = truyvan;

            base.GhiDuLieu(cmd);
        }


        public void CapNhatTTRap(RapDTO obj, object idRap)
        {
            string truyvan = $"UPDATE [dbo].[Rap] SET " +
                $"[id] = '{obj.Id}', [ten] = '{obj.Ten}', [diachi] = '{obj.Diachi}' " +
                $"WHERE [id] = '{idRap}'";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = truyvan;

            base.GhiDuLieu(cmd);
        }

        public void XoaRap(object idRap)
        {
            string truyvan = $"DELETE FROM [dbo].[TTRap] WHERE [id_rap] = '{idRap}' " +
                $"DELETE FROM [dbo].[Rap] WHERE [id] = '{idRap}'";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = truyvan;

            base.GhiDuLieu(cmd);
        }

        public void XoaTatCaRap()
        {
            string truyvan = "DELETE FROM [dbo].[Rap]";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = truyvan;

            base.GhiDuLieu(cmd);
        }
    }
}
