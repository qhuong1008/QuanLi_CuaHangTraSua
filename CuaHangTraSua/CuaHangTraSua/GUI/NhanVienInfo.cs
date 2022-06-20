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
    public partial class NhanVienInfo : Form
    {
        public string MaNV { get; set; }
        public string Hoten { get; set; }
        public string ngaysinh { get; set; }
        public string quequan { get; set; }
        public string luong { get; set; }
        public NhanVienInfo()
        {
            InitializeComponent();
        }

        private void NhanVienInfo_Load(object sender, EventArgs e)
        {
            txtMaNV.Text = MaNV;
            txtHoten.Text = Hoten;
            dtNgaySinhInfor.Text = ngaysinh;
            txtQuequan.Text = quequan;
            txtLuong.Text = luong;
        }

        private void bt_Sua(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            NhanVienDAO dao = new NhanVienDAO();
            nv.MaNV = txtMaNV.Text;
            nv.HoTen = txtHoten.Text;
            nv.NgaySinh = dtNgaySinhInfor.Value;
            nv.QueQuan = txtQuequan.Text;
            nv.Luong = Convert.ToInt32(txtLuong.Text);
            dao.Update(nv);
            MessageBox.Show("Cập nhật thành công!");
            this.Close();

        }

        private void bt_Xoa(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            NhanVienDAO dao = new NhanVienDAO();
            nv.MaNV = txtMaNV.Text;
            nv.HoTen = txtHoten.Text;
            nv.NgaySinh = dtNgaySinhInfor.Value;
            nv.QueQuan = txtQuequan.Text;
            nv.Luong = Convert.ToInt32(txtLuong.Text);

            string message = "Bạn có chắc muốn xóa nhân viên này?";
            string title = "Message";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                dao.Delete(nv);
                MessageBox.Show("Xoá thành công!");
                this.Close();
            }

        }

        private void bt_XacNhan(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
