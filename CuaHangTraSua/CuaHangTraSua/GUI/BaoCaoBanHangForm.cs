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

namespace CuaHangTraSua.GUI
{
    public partial class BaoCaoBanHangForm : Form
    {
        public BaoCaoBanHangForm()
        {
            InitializeComponent();
        }

        private void BaoCaoBanHangForm_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

            FormBorderStyle = FormBorderStyle.Sizable;
            TopMost = false;
            WindowState = FormWindowState.Normal;

            HoaDonDAO don = new HoaDonDAO();
            DataTable dt = don.GetBaoCaoBanHang();
            doanhso_gridview.DataSource = dt;
            doanhso_gridview.AutoResizeColumns();
            doanhso_gridview.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            doanhso_gridview.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            doanhso_gridview.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            doanhso_gridview.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            doanhso_gridview.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill ;


        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            HoaDonDAO dao = new HoaDonDAO();
            string searchname = search.Text;
            dt = dao.GetBaoCaoBanHang();
            doanhso_gridview.DataSource = dt;

            dt.DefaultView.RowFilter = string.Format("[{1}] LIKE '%{0}%'" +
                                                  "OR [{2}] LIKE '%{0}%'",search.Text, "Mã nhân viên","Tên nhân viên");
        }
    }
}
