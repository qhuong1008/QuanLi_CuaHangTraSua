using System.Data.SqlClient;

namespace CuaHangTraSua.DBUtils
{
    public class DBConnection
    {
        private static SqlConnection instance = null;

        public static SqlConnection getInstance()
        {
            if (instance == null)
            {
                //string sqlConnectionString = @"Data Source=KHANH-PC\SQLEXPRESS;Initial Catalog=QLCUAHANGTRASUA;Integrated Security=True"; 
                string sqlConnectionString = @"Data Source=LAPTOP-AU2P2PHD;Initial Catalog=QLCUAHANGTRASUA;Integrated Security=True"; ;
                //string sqlConnectionString = $"Server={DBUtils.SERVER};Database={DBUtils.DATABASE};User={DBUtils.USERNAME};Password={DBUtils.PASSWORD};";

                instance = new SqlConnection(sqlConnectionString);
                instance.Open();
            }

            return instance;
        }
    }
}
