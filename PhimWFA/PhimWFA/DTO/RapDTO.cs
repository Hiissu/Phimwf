using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhimWFA.DTO
{
    class RapDTO
    {
        string id;
        string ten;
        string diachi;

        public string Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Diachi { get => diachi; set => diachi = value; }
    }
}
