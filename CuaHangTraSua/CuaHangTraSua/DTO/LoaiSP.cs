using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTraSua.DTO
{
    public class LoaiSP
    {
        public string MaLoaiSP { get; set; }
        public string TenLoaiSP { get; set; }

        public LoaiSP()
        {

        }

        public LoaiSP(string maLoaiSP, string tenLoaiSP)
        {
            MaLoaiSP = maLoaiSP;
            TenLoaiSP = tenLoaiSP;
        }
    }
}
