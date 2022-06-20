using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CuaHangTraSua.DTO;

namespace CuaHangTraSua.DAO
{
    class DonHangDAO
    {
        public DonHangDAO()
        {

        }
        public void CreateDonHang(string manv,string masp, int soluong, int gia, string ghichu)
        {
            var conn = DBUtils.DBConnection.getInstance();
            var command = conn.CreateCommand();

            /*command.CommandText = "insert into DonHang(MaDH,MaSP,SoLuong,Gia,GhiChu) " +
                                  "values((select MAX(MaHoaDon) as Max FROM HoaDon),@MaSP, @SoLuong," +
                                  "(select Gia from SanPham where SanPham.MaSP = @MaSP)*(@SoLuong),@GhiChu)";*/

            command.CommandText = "if not exists(select * from HoaDon where HoaDon.MaHoaDon = 1)"+
                                  "     insert into HoaDon(MaNV, ThanhTien) VALUES(@MaNV, 0)"+
                                  "\ninsert into DonHang(MaDH, MaSP, SoLuong, Gia, GhiChu)"+
                                  "\nvalues((select MAX(MaHoaDon) as Max FROM HoaDon),@MaSP, @SoLuong," +
                                  "(select Gia from SanPham where SanPham.MaSP = @MaSP)*(@SoLuong),@GhiChu)";
            command.Parameters.Add(new SqlParameter("@MaNV", manv));
            command.Parameters.Add(new SqlParameter("@MaSP", masp));
            command.Parameters.Add(new SqlParameter("@SoLuong", soluong));
            command.Parameters.Add(new SqlParameter("@Gia", gia));
            command.Parameters.Add(new SqlParameter("@GhiChu", ghichu)); 
            command.ExecuteNonQuery();
        }



        public DataTable GetAllDonHang()
        {
            var conn = DBUtils.DBConnection.getInstance();
            var command = conn.CreateCommand();

            command.CommandText = "select MaDH as 'Mã đơn hàng',SanPham.MaSP as 'Mã SP'," +
                "TenSP as 'Tên SP', DonHang.SoLuong as 'Số lượng',DonHang.Gia as 'Giá',GhiChu as 'Ghi chú' from DonHang inner join SanPham" +
                " on DonHang.MASP = SanPham.MaSP and DonHang.MaDH = (SELECT MAX(MaHoaDon) as Max FROM HoaDon)";

            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public void RemoveDonHang(int madh, string masp, int soluong, int gia, string ghichu)
        {
            var conn = DBUtils.DBConnection.getInstance();
            var command = conn.CreateCommand();

            command.CommandText = "delete top(1) from DonHang WHERE MaSP = @MaSP and " +
                                  "MaDH=@MaDH and MaSP=@MaSP and SoLuong=@SoLuong and Gia=@Gia and GhiChu=@GhiChu";


            command.Parameters.Add(new SqlParameter("@MaDH", madh));
            command.Parameters.Add(new SqlParameter("@MaSP", masp));
            command.Parameters.Add(new SqlParameter("@SoLuong", soluong));
            command.Parameters.Add(new SqlParameter("@Gia", gia));
            command.Parameters.Add(new SqlParameter("@GhiChu", ghichu));
            command.ExecuteNonQuery();
        }
    }
}
