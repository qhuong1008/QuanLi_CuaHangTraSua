using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTraSua.View
{
    public class LoaiSPView
    {
        public string MaLoaiSP { get; set; }
        public string TenLoaiSP { get; set; }

        public LoaiSPView()
        {

        }

        public LoaiSPView(string maLoaiSP, string tenLoaiSP)
        {
            MaLoaiSP = maLoaiSP;
            TenLoaiSP = tenLoaiSP;
        }
    }
}
