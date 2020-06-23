using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PhimWFA.DAL;
using PhimWFA.DTO;
using System.Data;

namespace PhimWFA.BLL
{
    class PhimBLL
    {
        PhimDAL obj_phim;
        public PhimBLL()
        {
            obj_phim = new PhimDAL();
        }

        public DataTable HienThiTatCaPhim()
        {
            return obj_phim.HienThiTatCaPhim();
        }

        public DataTable HienThiTTNhanVien(string idPhim)
        {
            return obj_phim.HienThiTTNhanVien(idPhim);
        }
        public DataTable HienThiTTRap(string idPhim)
        {
            return obj_phim.HienThiTTRap(idPhim);
        }

        public void ThemPhim(PhimDTO obj)
        {
            obj_phim.ThemPhim(obj);
        }

        public void CapNhatTTPhim(PhimDTO obj, object idPhim)
        {
            obj_phim.CapNhatTTPhim(obj, idPhim);
        }

        public void XoaPhim(object idPhim)
        {
            obj_phim.XoaPhim(idPhim);
        }

        public void XoaTatCaPhim()
        {
            obj_phim.XoaTatCaPhim();
        }

        public void XoaNhanVien(string idPhim)
        {
            obj_phim.XoaNhanVien(idPhim);
        }
        public void CapNhatNhanVien(string idPhim, string idNhanVien)
        {
            obj_phim.CapNhatNhanVien(idPhim, idNhanVien);
        }

        public void XoaRap(string idPhim)
        {
            obj_phim.XoaRap(idPhim);
        }
        public void CapNhatRap(string idPhim, string idRap)
        {
            obj_phim.CapNhatRap(idPhim, idRap);
        }
    }
}
