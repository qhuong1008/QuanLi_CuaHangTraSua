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
namespace CuaHangTraSua.GUI
{
    public partial class Menu : Form
    {
        public string userid { get; set; }
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            SanPhamDAO selectProd = new SanPhamDAO();
            DataTable listProd = selectProd.GetAllSanPham();
            dtgListProd.DataSource = listProd;
            dtgListProd.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgListProd.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgListProd.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgListProd.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgListProd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dtgListProd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dtgListProd.Rows[e.RowIndex];
            if (r != null)
            {
                string pro_id = r.Cells[0].Value.ToString();
                string pro_name = r.Cells[1].Value.ToString();
                int price = Convert.ToInt32(r.Cells[3].Value.ToString());
                ItemInfo form = new ItemInfo(price,pro_name,pro_id);
                form.manv = userid;
                form.ShowDialog();
            }

        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SanPhamDAO dao = new SanPhamDAO();
            string searchname = search.Text;
            dt = dao.GetAllSanPham();
            dtgListProd.DataSource = dt;

            dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'"+
                                                  "OR [{2}] LIKE '%{1}%'", "Tên sản phẩm", search.Text, "Mã sản phẩm");
        }
    }
}
