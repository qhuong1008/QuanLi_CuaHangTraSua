using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTraSua.DTO
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string QueQuan { get; set; }
        public int Luong { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Manager { get; set; }

        public NhanVien()
        {

        }

        public NhanVien(string maNV, string hoTen, DateTime ngaySinh, string queQuan, int luong, string username, string password, bool manager)
        {
            MaNV = maNV;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            QueQuan = queQuan;
            Luong = luong;
            Username = username;
            Password = password;
            Manager = manager;
        }
    }
}
