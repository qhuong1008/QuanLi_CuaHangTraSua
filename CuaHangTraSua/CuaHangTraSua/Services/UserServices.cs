using CuaHangTraSua.DAO;
using CuaHangTraSua.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTraSua.Services
{
    public class UserServices
    {
        public UserServices()
        {

        }

        public NhanVien Authenticate(string username, string password)
        {
            var dao = new NhanVienDAO();
            return dao.Get(username, password);
        }
    }
}
