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
    public partial class SanPhamInfo : Form
    {
        public string masp { get; set; }
        public string tensp { get; set; }
        public string gia { get; set; }
        public string loai { get; set; }
        public DataGridView donhang_gridview { get; set; }

        public SanPhamInfo()
        {
            InitializeComponent();
        }
   

        public SanPhamInfo(string pro_name, string price)
        {
            InitializeComponent();
            
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbSoluong_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void SanPhamInfo_Load(object sender, EventArgs e)
        {
            txtMaSP.Text = masp;
            txtTenSP.Text = tensp;
            txtGia.Text = Convert.ToString(gia);
            cbLoaiSP.Text = getLoaiSPText(loai);
        }

        public string getLoaiSPText(string loai)
        {
            string name;
            if(loai == "L01")
            {
                name = "L01 - Trà sữa";
            }
            else if(loai == "L02")
            {
                name = "L02 - Trà trái cây";
            }
            else if (loai == "L03")
            {
                name = "L03 - Cà phê";
            }
            else
            {
                name = "L04 - Bánh ngọt";
            }

            return name;
        }
        public string getLoaiSP(string loai)
        {
            string name;
            if (loai == "L01 - Trà sữa")
            {
                name = "L01";
            }
            else if (loai == "L02 - Trà trái cây")
            {
                name = "L02";
            }
            else if (loai == "L03 - Cà phê")
            {
                name = "L03";
            }
            else
            {
                name = "L04";
            }

            return name;
        }
        private void BtnXacnhan_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            SanPhamDAO dao = new SanPhamDAO();
            sp.MaSP = masp;
            sp.TenSP = txtTenSP.Text;
            sp.Gia = Convert.ToInt32(txtGia.Text);
            sp.Loai = getLoaiSP(cbLoaiSP.Text);
            dao.UpdateSP(sp);         
            this.Close();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            SanPhamDAO dao = new SanPhamDAO();
            sp.MaSP = masp;
            sp.TenSP = txtTenSP.Text;
            sp.Gia = Convert.ToInt32(txtGia.Text);
            sp.Loai = getLoaiSP(cbLoaiSP.Text);
            dao.UpdateSP(sp);
            MessageBox.Show("Cập nhật thành công!");
            this.Close();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            SanPhamDAO dao = new SanPhamDAO();
            sp.MaSP = masp;
            sp.TenSP = txtTenSP.Text;
            sp.Gia = Convert.ToInt32(txtGia.Text);
            sp.Loai = getLoaiSP(cbLoaiSP.Text);
            
            string message = "Bạn có chắc muốn xóa sản phẩm này?";
            string title = "Message";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                dao.Delete(sp);
                MessageBox.Show("Xoá thành công!");
                this.Close();
            }

        }
    }
}
