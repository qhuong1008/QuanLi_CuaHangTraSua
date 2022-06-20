using CuaHangTraSua.DTO;
using CuaHangTraSua.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTraSua.DAO
{
    class HoaDonDAO
    {
        public HoaDonDAO()
        {

        }

        public void CreateHoaDon(string manv)
        {
            var conn = DBUtils.DBConnection.getInstance();
            var command = conn.CreateCommand();

            command.CommandText = "INSERT INTO HoaDon(MaNV,ThanhTien) VALUES (@MaNV, 0);";

            command.Parameters.Add(new SqlParameter("@MaNV", manv));
            command.ExecuteNonQuery();
        }
        public void UpDateTotal(int total)
        {
            SqlConnection conn = DBUtils.DBConnection.getInstance();
            SqlCommand command = conn.CreateCommand();

            command.CommandText = "update HoaDon set ThanhTien = @total where MaHoaDon = (SELECT MAX(MaHoaDon) as Max FROM HoaDon)";

            command.Parameters.Add(new SqlParameter("@total", total));
            command.ExecuteNonQuery();
        }
        public DataTable GetHoaDon()
        {
            var conn = DBUtils.DBConnection.getInstance();
            var command = conn.CreateCommand();

            command.CommandText = "select MaDH as 'Mã đơn hàng', " +
                                  "       SanPham.MaSP as 'Mã SP', " +
                                  "       TenSP as 'Tên SP', " +
                                  "       DonHang.SoLuong as 'Số lượng', " +
                                  "       DonHang.Gia as 'Giá', " +
                                  "       GhiChu as 'Ghi chú', " +
                                  "       HoaDon.NgayLapDon as 'Ngày lập đơn' " +
                                  "from DonHang inner join SanPham " +
                                  "on DonHang.MASP = SanPham.MaSP and DonHang.MaDH = (SELECT MAX(MaHoaDon) as Max FROM HoaDon) " +
                                  "inner join HoaDon on DonHang.MaDH = HoaDon.MaHoaDon;";

            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public DataTable GetBaoCaoBanHang()
        {
            var conn = DBUtils.DBConnection.getInstance();
            var command = conn.CreateCommand();

            command.CommandText = "select MaHoaDon as 'Mã hóa đơn', NhanVien.MaNV as 'Mã nhân viên', NhanVien.HoTen as 'Tên nhân viên'," +
                    "ThanhTien as 'Thành tiền', NgayLapDon as 'Ngày lập đơn' from HoaDon inner join NhanVien on HoaDon.MaNV = NhanVien.MaNV";

            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }


}
