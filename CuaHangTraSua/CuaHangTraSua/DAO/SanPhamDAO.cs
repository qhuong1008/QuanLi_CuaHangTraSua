using CuaHangTraSua.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CuaHangTraSua.DAO
{
    public class SanPhamDAO
    {
        public SanPhamDAO()
        {

        }

        public DataTable GetAllSanPham()
        {
            var conn = DBUtils.DBConnection.getInstance();
            var command = conn.CreateCommand();

            command.CommandText = "SELECT MaSP as 'Mã sản phẩm', TenSP as 'Tên sản phẩm', TenLoaiSP as 'Loại', Gia as 'Giá' FROM SanPham inner join LoaiSP on SanPham.Loai = LoaiSP.MaLoaiSP --order by Stt;";
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public void SelectInforByName(string pro_name, out string prod_id, out int price)
        {
            var conn = DBUtils.DBConnection.getInstance();
            var command = conn.CreateCommand();
            command.CommandText = "SELECT MaSP, Gia FROM SanPham WHERE TenSP = @name;";
            command.Parameters.Add(new SqlParameter("@name", pro_name));
            string prod_id_temp = " ";
            int price_temp = 0;
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    prod_id_temp = reader.GetString(0);
                    price_temp = reader.GetInt32(1);
                }
            }
            prod_id = prod_id_temp;
            price = price_temp;
        }
        public List<string> GetAllProductName()
        {
            var conn = DBUtils.DBConnection.getInstance();
            var command = conn.CreateCommand();
            command.CommandText = "SELECT TenSP From SanPham;";
            List<string> prodNameList = new List<string>();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    prodNameList.Add(reader.GetString(0));
                }
            }
            return prodNameList;
        }
        public void CreateSP(SanPham sp)
        {
            var conn = DBUtils.DBConnection.getInstance();
            var command = conn.CreateCommand();
            command.CommandText = "insert into SanPham(MaSP,TenSP,Loai,Gia) " +
                "values ((select concat('SP',(select(select Max(SanPham.Stt))+1 from SanPham))), @TenSP, @Loai, @Gia)";

            command.Parameters.Add(new SqlParameter("@TenSP", sp.TenSP));
            command.Parameters.Add(new SqlParameter("@Loai", sp.Loai));
            command.Parameters.Add(new SqlParameter("@Gia", sp.Gia));
            command.ExecuteNonQuery();
        }
        public void UpdateSP(SanPham sp)
        {
            var conn = DBUtils.DBConnection.getInstance();
            var command = conn.CreateCommand();
            command.CommandText = "update SanPham " +
                                  "set TenSP = @TenSP, Loai = @Loai, Gia = @Gia " +
                                  "where SanPham.MaSP = @MaSP";
            command.Parameters.Add(new SqlParameter("@MaSP", sp.MaSP));
            command.Parameters.Add(new SqlParameter("@TenSP", sp.TenSP));
            command.Parameters.Add(new SqlParameter("@Loai", sp.Loai));
            command.Parameters.Add(new SqlParameter("@Gia", sp.Gia));
            command.ExecuteNonQuery();

            SapXepTable();
        }
        public void SapXepTable()
        {
            var conn = DBUtils.DBConnection.getInstance();
            var command = conn.CreateCommand();
            command.CommandText = "select * from SanPham ORDER BY Stt";
            command.ExecuteNonQuery();
        }
        public void Delete(SanPham sanPham)
        {

            var conn = DBUtils.DBConnection.getInstance();
            var command = conn.CreateCommand();
            command.CommandText = "DELETE FROM SanPham WHERE MaSP = @MaSP;";
            //command.CommandText = "if exists (select DonHang.MaSP from DonHang where DonHang.MaSP = @MaSP)" +
                                 // "\ndelete from SanPham WHERE MaSP = @MaSP";

            command.Parameters.Add(new SqlParameter("@MaSP", sanPham.MaSP));
            command.ExecuteNonQuery();
        }

        public void SelectInforByID(string prod_id, out string prod_name, out string price)
        {
            var conn = DBUtils.DBConnection.getInstance();
            var command = conn.CreateCommand();
            command.CommandText = "SELECT TenSP as 'Tên sản phẩm', Gia as 'Giá' FROM SanPham WHERE MaSP = @id;";
            //command.CommandText = "SELECT TenSP, Gia FROM SanPham WHERE MaSP = @id;";
            command.Parameters.Add(new SqlParameter("@id", prod_id));
            string prod_name_temp = " ", price_temp = " ";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    prod_name_temp = reader["Tên sản phẩm"].ToString();
                    price_temp = reader["Giá"].ToString();
                }
            }
            prod_name = prod_name_temp;
            price = price_temp;
        }

        public string GetSPName_byID(string id)
        {
            var conn = DBUtils.DBConnection.getInstance();
            var command = conn.CreateCommand();
            command.CommandText = "select TenSP as 'Tên sản phẩm' from SanPham where SanPham.MaSP = @MaSP;";
            command.Parameters.Add(new SqlParameter("@MaSP", id));

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    string name = reader["Tên sản phẩm"].ToString();
                    return name;
                }
                else
                {
                    return "false";
                }
            }
        }

        public int GetSPPrice_byID(string id)
        {
            var conn = DBUtils.DBConnection.getInstance();
            var command = conn.CreateCommand();
            command.CommandText = "select Gia as 'Giá' from SanPham where SanPham.MaSP = @MaSP;";
            command.Parameters.Add(new SqlParameter("@MaSP", id));

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    int price = Convert.ToInt32(reader["Giá"]);
                    return price;
                }
                else
                {
                    return 0;
                }

            }
        }

        public DataTable SearchSanPham(string search)
        {
            var conn = DBUtils.DBConnection.getInstance();
            var command = conn.CreateCommand();

            if(search == "")
            {
                command.CommandText = "SELECT MaSP as 'Mã sản phẩm', TenSP as 'Tên sản phẩm', Loai as 'Loại', Gia as 'Giá' FROM SanPham order by Stt;";
            }
            else
            {
                command.CommandText = "select * from SanPham where SanPham.TenSP like '%@search%';";
            }         
            command.Parameters.Add(new SqlParameter("@search", search));
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }   
        }
    }
}
