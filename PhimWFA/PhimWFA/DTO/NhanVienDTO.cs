using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhimWFA.DTO
{
    class NhanVienDTO
    {
        string id;
        string ten;
        string chucvu;

        public string Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
    }
}
