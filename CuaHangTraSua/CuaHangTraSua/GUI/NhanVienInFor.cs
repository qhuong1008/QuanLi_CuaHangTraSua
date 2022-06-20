using CuaHangTraSua.DAO;
using CuaHangTraSua.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangTraSua.GUI
{
    public partial class NhanVienInFor : Form
    {

        public string MaNV { get; set; }

        public NhanVienInFor()
        {
            InitializeComponent();
        }

        private void bt_Sua(object sender, EventArgs e)
        {
            NhanVienDAO nhanvienDAO = new NhanVienDAO();
            NhanVien nhanvien = new NhanVien();
            nhanvien.MaNV = txtMaNV.Text;
            nhanvien.HoTen = txtHoTen.Text;
            nhanvien.NgaySinh = dtNgaySinh.Value;
            nhanvien.QueQuan = txtQueQuan.Text;
            nhanvien.Luong = Convert.ToInt32(txtLuong.Text);
            nhanvien.Username = txtUserName.Text;
            nhanvien.Password = txtPassword.Text;
            if (rdQuanLy.Checked == true)
                nhanvien.Manager = true;
            nhanvienDAO.Update(nhanvien);
            MessageBox.Show("Cập nhật thành công!");
            this.Close();

        }

        private void bt_Xoa(object sender, EventArgs e)
        {
            NhanVienDAO nhanvienDAO = new NhanVienDAO();
            NhanVien nhanvien = new NhanVien();
            nhanvien.MaNV = txtMaNV.Text;
            if (rdQuanLy.Checked == true)
                nhanvien.Manager = true;

            string message = "Bạn có chắc muốn xóa nhân viên này?";
            string title = "Message";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                nhanvienDAO.Delete(nhanvien);
                MessageBox.Show("Xoá thành công!");
                this.Close();
            }
        }

        private void bt_XacNhan(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NhanVienInfor_Load(object sender, EventArgs e)
        {
            NhanVienDAO nhanvienDAO = new NhanVienDAO();
            NhanVien nhanvien = nhanvienDAO.GetNhanVien(MaNV);

            txtMaNV.Text = nhanvien.MaNV.ToString();
            txtHoTen.Text = nhanvien.HoTen.ToString();
            dtNgaySinh.Text = nhanvien.NgaySinh.ToString();
            txtQueQuan.Text = nhanvien.QueQuan.ToString();
            txtLuong.Text = nhanvien.Luong.ToString();
            txtUserName.Text = nhanvien.Username.ToString();
            txtPassword.Text = nhanvien.Password.ToString();
            if (nhanvien.Manager)
                rdQuanLy.Checked = true;
            else
                rdNhanVien.Checked = true;

        }

    }
}
