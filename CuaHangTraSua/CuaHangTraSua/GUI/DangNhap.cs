using CuaHangTraSua.Services;
using CuaHangTraSua.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace CuaHangTraSua.GUI
{
    public partial class DangNhap : Form
    {
        private UserServices userServices;
       

        public DangNhap()
        {
            InitializeComponent();

            this.userServices = new UserServices();
        }


        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void XuLiLogin()
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;


            //xu li login
            if (username.Length == 0)
            {
                MessageBox.Show("Tên đăng nhập không được trống",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            var nhanVien = userServices.Authenticate(username, password);

            if (nhanVien == null)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            //Truyen bien qua giao dien nhan vien 
            //GiaoDienNhanVien formNV = new GiaoDienNhanVien(nhanVien.Manager);
            GiaoDienNhanVien formNV = new GiaoDienNhanVien();
            GiaoDienQuanLy formQL = new GiaoDienQuanLy();
            NhanVienDAO nv = new NhanVienDAO();

            string id = nv.getUserID(username);
            string hoten = nv.getHoten(id);

            formNV.username = username;
            formNV.hoten = hoten;
            formNV.userid = id;

            /*this.Hide();
            formNV.ShowDialog();
            this.Close();*/
            formQL.username = username;
            formQL.hoten = hoten;
            formQL.userid = id;

            if (nhanVien.Manager)
            {
                this.Hide();
                //var form = new GiaoDienQuanLy();
                formQL.ShowDialog();
            }
            else
            {
                this.Hide();
                //var form = new GiaoDienNhanVien();
                formNV.ShowDialog();
            }

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            XuLiLogin();            
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs kea)
        {
            if (kea.KeyCode.Equals(Keys.Return))
            {
                XuLiLogin();
            }      
        }
        public string getUserID()
        {
            string username = txtUsername.Text;
            NhanVienDAO nv = new NhanVienDAO();
            string id = nv.getUserID(username);
            return id;
        }

    }
}
