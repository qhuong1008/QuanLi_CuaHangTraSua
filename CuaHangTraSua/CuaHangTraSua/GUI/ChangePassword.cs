using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuaHangTraSua.DAO;
using CuaHangTraSua.DTO;
using CuaHangTraSua.Services;

namespace CuaHangTraSua.GUI
{
    public partial class ChangePassword : Form
    {
        string username;
        public bool change { get; set; }
        public ChangePassword()
        {
            InitializeComponent();
        }
        public ChangePassword(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            UserServices checkPass = new UserServices();
            NhanVien nhanVien = checkPass.Authenticate(username, txtOldPass.Text);
            if(nhanVien == null)
            {
                MessageBox.Show("Mật khẩu không chính xác");
            }
            else
            {
                if (txtNewPass.Text == "")
                {
                    MessageBox.Show("Mật khẩu không được để trống!");
                }
                else
                {
                    if (String.Compare(txtNewPass.Text, txtConfirmPass.Text, false) == 0)
                    {

                        MessageBox.Show("Đã đổi mật khẩu cho tài khoản!");
                        NhanVienDAO changeNV = new NhanVienDAO();
                        changeNV.UpdatePassWord(username, txtNewPass.Text);
                        change = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới không trùng khớp");
                    }
                }    
            }    
        }
    }
}
