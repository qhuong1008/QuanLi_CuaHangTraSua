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
    public partial class ThemSPForm : Form
    {
        public ThemSPForm()
        {
            InitializeComponent();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.TenSP = txtTenSP.Text;
            sp.Loai = getLoaiSP(cbLoai.Text);
            sp.Gia = Convert.ToInt32(txtGia.Text);

            SanPhamDAO dao = new SanPhamDAO();
            dao.CreateSP(sp);
            this.Close();
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
    }
}
