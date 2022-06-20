using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTraSua.DTO
{
    class DonHang
    {
        public string MaDH { get; set; }
        public string MaSP { get; set; }
        public string Soluong { get; set; }
        public string Gia { get; set; }
        public string GhiChu { get; set; }
        public DonHang() { }
        public DonHang(string madh, string masp, string soluong, string gia, string ghichu)
        {
            madh = MaDH;
            masp = MaSP;
            soluong = Soluong;
            gia = Gia;
            ghichu = GhiChu;
        }

    }
}
