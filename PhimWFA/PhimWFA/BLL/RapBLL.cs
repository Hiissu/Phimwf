using PhimWFA.DAL;
using PhimWFA.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhimWFA.BLL
{
    class RapBLL
    {
        RapDAL obj_rap;
        public RapBLL()
        {
            obj_rap = new RapDAL();
        }

        public DataTable HienThiTatCaRap()
        {
            return obj_rap.HienThiTatCaRap();
        }

        public RapDTO HienThiTTRap(object idRap)
        {
            return obj_rap.HienThiTTRap(idRap);
        }

        public void ThemRap(RapDTO obj)
        {
            obj_rap.ThemRap(obj);
        }

        public void CapNhatTTRap(RapDTO obj, object idRap)
        {
            obj_rap.CapNhatTTRap(obj, idRap);
        }

        public void XoaRap(object idRap)
        {
            obj_rap.XoaRap(idRap);
        }

        public void XoaTatCaRap()
        {
            obj_rap.XoaTatCaRap();
        }
    }
}
