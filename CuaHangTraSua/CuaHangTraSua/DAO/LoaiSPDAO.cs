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
    public class LoaiSPDAO
    {
        public LoaiSPDAO()
        { 

        }

        public IEnumerable<LoaiSP> GetAllLoaiSanPham()
        {
            var conn = DBUtils.DBConnection.getInstance();
            var command = conn.CreateCommand();

            //command.CommandText = "SELECT MaLoaiSP, TenLoaiSP FROM LoaiSP;";
            command.CommandText = "SELECT * FROM LoaiSP;";
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt.AsEnumerable().Select(row => new LoaiSP()
                {
                    MaLoaiSP = Convert.ToString(row["MaLoaiSP"]),
                    TenLoaiSP = Convert.ToString(row["TenLoaiSP"])

                });
            }
        }
    }
}
