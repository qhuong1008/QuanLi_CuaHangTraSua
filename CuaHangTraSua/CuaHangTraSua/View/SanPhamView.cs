using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTraSua.View
{
    public class SanPhamView
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string Loai { get; set; }
        public int Gia { get; set; }

        public SanPhamView()
        {

        }

        public SanPhamView(string maSP, string tenSP, string loai, int gia)
        {
            MaSP = maSP;
            TenSP = tenSP;
            Loai = loai;
            Gia = gia;
        }
    }
}
