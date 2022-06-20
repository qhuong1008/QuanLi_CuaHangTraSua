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
    public partial class ThemNhanVienForm : Form
    {
        public string MaNV { get; set; }
        public string Hoten { get; set; }
        public DateTime ngaysinh { get; set; }
        public string quequan { get; set; }
        public string luong { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public DataGridView InfoNV_gridview { get; set; }
        public ThemNhanVienForm()
        {
            InitializeComponent();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.HoTen = txtHoten.Text;
            nv.Username = txtUsername.Text;
            nv.NgaySinh = dateTimePicker1.Value;
            nv.QueQuan = txtQuequan.Text;
            nv.Luong = Convert.ToInt32(txtLuong.Text);
            nv.Password = txtPassword.Text;

            NhanVienDAO NVdao = new NhanVienDAO();
            NVdao.Create(nv);
            MessageBox.Show("Thêm thành công!");
            this.Close();
        }


        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThemNhanVienForm_Load(object sender, EventArgs e)
        {

        }
    }
}
