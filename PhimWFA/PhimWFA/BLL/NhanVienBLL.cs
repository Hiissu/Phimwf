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
    class NhanVienBLL
    {
        NhanVienDAL obj_nv;
        public NhanVienBLL()
        {
            obj_nv = new NhanVienDAL();
        }

        public DataTable HienThiTatCaNhanVien()
        {
            return obj_nv.HienThiTatCaNhanVien();
        }

        public void ThemNhanVien(NhanVienDTO obj)
        {
            obj_nv.ThemNhanVien(obj);
        }

        public void CapNhatTTNhanVien(NhanVienDTO obj, object idNV)
        {
            obj_nv.CapNhatTTNhanVien(obj, idNV);
        }

        public void XoaNhanVien(object idNV)
        {
            obj_nv.XoaNhanVien(idNV);
        }

        public void XoaTatCaNhanVien()
        {
            obj_nv.XoaTatCaNhanVien();
        }
    }
}
