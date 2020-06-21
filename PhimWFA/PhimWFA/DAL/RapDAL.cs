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

            string truyvan = "SELECT * FROM dbo.Rap";

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


        public RapDTO HienThiTTRap(object maRap)
        {
            RapDTO obj = new RapDTO();
            string truyvan = "SELECT * FROM dbo.Rap WHERE id = " + maRap;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = truyvan;

            DataSet ds = base.DocDuLieu(cmd);
            DataRow drow = null;

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                drow = ds.Tables[0].Rows[0];
                obj.Ten = drow["Ten NSX"].ToString();
                obj.Id = drow["Ma NSX"].ToString();
                obj.Diachi = drow["Dia Diem"].ToString();
            }

            return obj;
        }


        public void ThemRap(RapDTO obj)
        {
            string truyvan = "INSERT INTO[dbo].[Rap] ";
            truyvan += "(id";
            truyvan += ",[ten]";
            truyvan += ",[diachi]";
            truyvan += "VALUES ";
            truyvan += "('" + obj.Id;
            truyvan += "','" + obj.Ten;
            truyvan += "('" + obj.Diachi + "')";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = truyvan;

            base.GhiDuLieu(cmd);
        }


        public void CapNhatTTRap(RapDTO obj, object idRap)
        {
            string truyvan = " UPDATE [dbo].[Rap] SET ";
            truyvan += "[id] = '" + obj.Id;
            truyvan += "', [ten] = '" + obj.Ten;
            truyvan += "', [diachi] = '" + obj.Diachi;
            truyvan += "WHERE [id] = '" + idRap + "'";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = truyvan;

            base.GhiDuLieu(cmd);
        }

        public void XoaRap(object idRap)
        {
            string truyvan = "DELETE FROM [dbo].[Rap] WHERE [id] = '" + idRap + "'";

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
