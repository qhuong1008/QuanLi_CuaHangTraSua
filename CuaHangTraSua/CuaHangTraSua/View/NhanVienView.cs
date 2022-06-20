using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTraSua.View
{
    public class NhanVienView
    {
        [DisplayName("Mã nhân viên")]
        public string MaNV { get; set; }
        [DisplayName("Họ tên")]
        public string HoTen { get; set; }
        [DisplayName("Ngày sinh")]
        public string NgaySinh { get; set; }
        [DisplayName("Quê quán")]
        public string QueQuan { get; set; }
        [DisplayName("Lương")]
        public string Luong { get; set; }

        public NhanVienView()
        {

        }

        public NhanVienView(string maNV, string hoTen, string ngaySinh, string queQuan, string luong)
        {
            MaNV = maNV;
            this.HoTen = hoTen;
            NgaySinh = ngaySinh;
            QueQuan = queQuan;
            Luong = luong;
        }
    }
}
