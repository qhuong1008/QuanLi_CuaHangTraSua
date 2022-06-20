using CuaHangTraSua.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CuaHangTraSua.DAO
{
    public class NhanVienDAO
    {
        public NhanVienDAO()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nhanVien"></param>
        public void Create(NhanVien nhanVien)
        {
            var conn = DBUtils.DBConnection.getInstance();
            var command = conn.CreateCommand();

            //command.CommandText = "insert into NhanVien values (@maNV, @hoTen, @ngaySinh, @queQuan, @luong, @userName, @password, 0);";
            command.CommandText = "insert into NhanVien(MaNV,HoTen,NgaySinh,QueQuan,Luong,Username,Pass_word,Manager) " +
                                  "values((select concat('NV', (select(select Max(NhanVien.Stt)) + 1 from NhanVien))), " +
                                  "@hoTen, @ngaySinh, @queQuan, @luong, @userName, @password, 0)";

            command.Parameters.Add(new SqlParameter("@hoTen", nhanVien.HoTen));
            command.Parameters.Add(new SqlParameter("@ngaySinh", nhanVien.NgaySinh));
            command.Parameters.Add(new SqlParameter("@queQuan", nhanVien.QueQuan));
            command.Parameters.Add(new SqlParameter("@luong", nhanVien.Luong));
            command.Parameters.Add(new SqlParameter("@userName", nhanVien.Username));
            command.Parameters.Add(new SqlParameter("@password", nhanVien.Password));
            command.ExecuteNonQuery();
        }

        public void Update(NhanVien nhanVien)
        {
            var conn = DBUtils.DBConnection.getInstance();
            var command = conn.CreateCommand();

            command.CommandText = @"UPDATE NhanVien
                                   SET
                                       HoTen = @hoTen,
                                       NgaySinh = @ngaySinh,
                                       QueQuan = @queQuan,
                                       Luong = @luong,
                                       Username = @username,
                                       Pass_word = @password,
                                       Manager = @manager
                                   WHERE MaNV = @MaNV;";

            command.Parameters.Add(new SqlParameter("@MaNV", nhanVien.MaNV));
            command.Parameters.Add(new SqlParameter("@hoTen", nhanVien.HoTen));
            command.Parameters.Add(new SqlParameter("@ngaySinh", nhanVien.NgaySinh));
            command.Parameters.Add(new SqlParameter("@queQuan", nhanVien.QueQuan));
            command.Parameters.Add(new SqlParameter("@luong", nhanVien.Luong));
            command.Parameters.Add(new SqlParameter("@username", nhanVien.Username));
            command.Parameters.Add(new SqlParameter("@password", nhanVien.Password));
            command.Parameters.Add(new SqlParameter("@manager", nhanVien.Manager));

            command.ExecuteNonQuery();
        }

        public void UpdatePassWord(string username, string password)
        {
            var conn = DBUtils.DBConnection.getInstance();
            var command = conn.CreateCommand();

            command.CommandText = @"UPDATE NhanVien SET Pass_word = @password WHERE Username = @username;";

            command.Parameters.Add(new SqlParameter("@username", username));
            command.Parameters.Add(new SqlParameter("@password", password));

            command.ExecuteNonQuery();
        }

        public void Delete(NhanVien nhanVien)
        {

            var conn = DBUtils.DBConnection.getInstance();
            var command = conn.CreateCommand();
            command.CommandText = @"DELETE FROM NhanVien
                                   WHERE MaNV = @MaNV;";

            command.Parameters.Add(new SqlParameter("@MaNV", nhanVien.MaNV));

            command.ExecuteNonQuery();
        }

 
        public NhanVien Get(string username, string password)
        {
            var conn = DBUtils.DBConnection.getInstance();
            var command = conn.CreateCommand();

            command.CommandText = "SELECT MaNV, HoTen, NgaySinh, QueQuan, Luong, Username, Pass_word, Manager FROM NhanVien WHERE Username=@username AND Pass_word=@password;";
            command.Parameters.Add(new SqlParameter("@Username", username));
            command.Parameters.Add(new SqlParameter("@Password", password));

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (!reader.Read())
                    return null; //Không có dòng nào hết

                return new NhanVien()
                {
                    MaNV = Convert.ToString(reader["MaNV"]),
                    HoTen = Convert.ToString(reader["HoTen"]),
                    NgaySinh = Convert.ToDateTime(reader["NgaySinh"]),
                    QueQuan = Convert.ToString(reader["QueQuan"]),
                    Luong = Convert.ToInt32(reader["Luong"]),
                    Username = Convert.ToString(reader["Username"]),
                    Password = Convert.ToString(reader["Pass_word"]),
                    Manager = Convert.ToBoolean(reader["Manager"])
                };
            }
        }
        public NhanVien GetNhanVien(string maNhanVien)
        {
            var conn = DBUtils.DBConnection.getInstance();
            var command = conn.CreateCommand();


            command.CommandText = "SELECT MaNV, HoTen, NgaySinh, QueQuan, Luong, Username, Pass_word, Manager FROM NhanVien WHERE MaNV = @MaNV;";
            command.Parameters.Add(new SqlParameter("@MaNV", maNhanVien));

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (!reader.Read())
                    return null; //Không có dòng nào hết

                return new NhanVien()
                {
                    MaNV = Convert.ToString(reader["MaNV"]),
                    HoTen = Convert.ToString(reader["HoTen"]),
                    NgaySinh = Convert.ToDateTime(reader["NgaySinh"]),
                    QueQuan = Convert.ToString(reader["QueQuan"]),
                    Luong = Convert.ToInt32(reader["Luong"]),
                    Username = Convert.ToString(reader["Username"]),
                    Password = Convert.ToString(reader["Pass_word"]),
                    Manager = Convert.ToBoolean(reader["Manager"])
                };
            }
        }

            public string getUserID(string username)
        {
            var conn = DBUtils.DBConnection.getInstance();
            var command = conn.CreateCommand();

            //select NhanVien.MaNV from NhanVien where NhanVien.Username = 'quynhhuong'
            command.CommandText = "SELECT MaNV FROM NhanVien WHERE Username=@username;";
            command.Parameters.Add(new SqlParameter("@Username", username));


            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (!reader.Read())
                    return null; //Không có dòng nào hết
                string id = Convert.ToString(reader["MaNV"]);
                return id;
            }
        }

        public string getHoten(string id)
        {
            var conn = DBUtils.DBConnection.getInstance();
            var command = conn.CreateCommand();


            command.CommandText = "select HoTen from NhanVien where MaNV = @manv;";
            command.Parameters.Add(new SqlParameter("@manv", id));


            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (!reader.Read())
                    return null; //Không có dòng nào hết
                string hoten = Convert.ToString(reader["HoTen"]);
                return hoten;
            }
        }

        public IEnumerable<NhanVien> GetAll()
        {
            var conn = DBUtils.DBConnection.getInstance();
            var command = conn.CreateCommand();

            command.CommandText = "SELECT MaNV as 'Mã nhân viên', HoTen as 'Họ tên', NgaySinh as 'Ngày sinh',"+
                                  "QueQuan as 'Quê quán', Luong as 'Lương' FROM NhanVien;";
            //command.CommandText = "Select * from NhanVien";

            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt.AsEnumerable().Select(row => new NhanVien()
                {
                    MaNV = Convert.ToString(row["Mã nhân viên"]),
                    HoTen = Convert.ToString(row["Họ tên"]),
                    NgaySinh = Convert.ToDateTime(row["Ngày sinh"]),
                    QueQuan = Convert.ToString(row["Quê quán"]),
                    Luong = Convert.ToInt32(row["Lương"]),
                   // Username = Convert.ToString(row["Username"]),
                   // Manager = Convert.ToBoolean(row["Manager"])
                });
            }
        }
        public DataTable GetAllNhanVien()
        {
            var conn = DBUtils.DBConnection.getInstance();
            var command = conn.CreateCommand();

            command.CommandText = "SELECT MaNV as 'Mã nhân viên', HoTen as 'Họ tên', NgaySinh as 'Ngày sinh'," +
                                  "QueQuan as 'Quê quán', Luong as 'Lương' FROM NhanVien;";
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }


        public IEnumerable<NhanVien> GetDanhSachQuanLy()
        {
            var conn = DBUtils.DBConnection.getInstance();
            var command = conn.CreateCommand();

            command.CommandText = "SELECT MaNV as 'Mã nhân viên', HoTen as 'Họ tên', NgaySinh as 'Ngày sinh'," +
                "QueQuan as 'Quê quán', Luong as 'Lương', Username, Pass_word, Manager FROM NhanVien WHERE Manager=1;";

            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt.AsEnumerable().Select(row => new NhanVien()
                {
                    MaNV = Convert.ToString(row["MaNV"]),
                    HoTen = Convert.ToString(row["HoTen"]),
                    NgaySinh = Convert.ToDateTime(row["NgaySinh"]),
                    QueQuan = Convert.ToString(row["QueQuan"]),
                    Luong = Convert.ToInt32(row["Luong"]),
                    Username = Convert.ToString(row["Username"]),
                    Password = Convert.ToString(row["Pass_word"]),
                    Manager = Convert.ToBoolean(row["Manager"])
                });
            }
        }
    }
}
