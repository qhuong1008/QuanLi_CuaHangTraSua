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
    public partial class ItemInfo : Form
    {
        string masp;
        public string manv { get; set; }
        int priceBefore;
        public DataGridView donhang_gridview { get; set; }

        public ItemInfo()
        {
            InitializeComponent();
        }
        public ItemInfo(int price, string name, string masp)
        {
            InitializeComponent();
            txtTenSP.Text = name;
            txtGiaSP.Text = price.ToString();
            this.masp = masp;
            this.priceBefore = price;
        }
        
        private void ItemInfo_Load(object sender, EventArgs e)
        {
                       
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            //tao moi 1 don hang
            string tenSP = txtTenSP.Text;
            int gia = Convert.ToInt32(txtGiaSP.Text);
            int soluong = Convert.ToInt32(cbSoluong.Value);
            string mota = txtMota.Text;
            string maSP = masp;
       
            if (soluong > 0)
            {
                DonHangDAO donhang = new DonHangDAO();
                donhang.CreateDonHang(manv,maSP, soluong, gia, mota);
               
            }
            this.Close();

        }

        private void cbSoluong_ValueChanged(object sender, EventArgs e)
        {
            int soluong = Convert.ToInt32(cbSoluong.Value);    
            int PriceAfter = priceBefore * soluong;
            txtGiaSP.Text = PriceAfter.ToString();

      
        }

        
    }
}
