using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhimWFA.DTO
{
    class PhimDTO
    {
        string id;
        string ten;
        string theloai;
        string quocgia;
        double diemdanhgia;

        public string Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Theloai { get => theloai; set => theloai = value; }
        public string Quocgia { get => quocgia; set => quocgia = value; }
        public double DiemDanhGia { get => diemdanhgia; set => diemdanhgia = value; }
    }
}
