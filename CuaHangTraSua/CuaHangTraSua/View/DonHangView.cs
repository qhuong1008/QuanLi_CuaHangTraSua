using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTraSua.View
{
    class DonHangView
    {
        public string MaSP { get; set; }
        public int Soluong { get; set; }
        public int Gia { get; set; }
        public string GhiChu { get; set; }
        
        public DonHangView(string masp, int soluong, int gia, string ghichu)
        {
            masp = MaSP;
            soluong = Soluong;
            gia = Gia;
            ghichu = GhiChu;

        }
    }
}
