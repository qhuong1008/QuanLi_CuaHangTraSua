using CuaHangTraSua.DAO;
using CuaHangTraSua.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangTraSua.GUI
{
    public partial class QuanLiMenu : Form
    {
        public QuanLiMenu()
        {
            InitializeComponent();
        }
        private void LoadGridView()
        {
            try
            {
                LoaiSPDAO LoaiSPdao = new LoaiSPDAO();
                List<LoaiSPView> LoaiSPViews = new List<LoaiSPView>();
                SanPhamDAO SanPhamdao = new SanPhamDAO();
                List<SanPhamView> SanPhamViews = new List<SanPhamView>();

                LoaiSPViews.AddRange(LoaiSPdao.GetAllLoaiSanPham().Select(s => new LoaiSPView()
                {
                    MaLoaiSP = s.MaLoaiSP,
                    TenLoaiSP = s.TenLoaiSP
                }).ToList());

                SanPhamdao.SapXepTable();

                DataTable SanPham_dt = SanPhamdao.GetAllSanPham();
                SP_gridview.DataSource = SanPham_dt;

                SP_gridview.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                SP_gridview.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                SP_gridview.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                SP_gridview.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void loadDSSP(IEnumerable<SanPhamView> listSP)
        {
            //SP_gridview.Columns.Clear();
            //SP_gridview.DataSource = listSP;

            SP_gridview.Columns[nameof(SanPhamView.MaSP)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SP_gridview.Columns[nameof(SanPhamView.TenSP)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SP_gridview.Columns[nameof(SanPhamView.Loai)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SP_gridview.Columns[nameof(SanPhamView.Gia)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }


        private void QuanLiMenu_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

            FormBorderStyle = FormBorderStyle.Sizable;
            TopMost = false;
            WindowState = FormWindowState.Normal;


            LoadGridView();
            SP_gridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void InfoSP_gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaSP = SP_gridview.Rows[e.RowIndex].Cells[0].Value.ToString();
            string tenSP = SP_gridview.Rows[e.RowIndex].Cells[1].Value.ToString();
            string Loai = SP_gridview.Rows[e.RowIndex].Cells[2].Value.ToString();
            string Gia = SP_gridview.Rows[e.RowIndex].Cells[3].Value.ToString();

            SanPhamInfo sp = new SanPhamInfo();
            sp.masp = MaSP;
            sp.tensp = tenSP;
            sp.loai = Loai;
            sp.gia = Gia;
            sp.ShowDialog();

            SanPhamDAO SanPhamdao = new SanPhamDAO();
            DataTable SanPham_dt = SanPhamdao.GetAllSanPham();
            SP_gridview.DataSource = SanPham_dt;
        }

        private void InfoSP_gridview_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new ContextMenuStrip();
                menu.Items.Add("Thêm").Name = "Them";

                int index = SP_gridview.HitTest(e.X, e.Y).RowIndex;
                menu.Show(SP_gridview, new Point(e.X, e.Y));


                //event menu clicked
                menu.ItemClicked += new ToolStripItemClickedEventHandler(menu_ItemClicked);
            }
        }

        void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name.ToString())
            {
                case "Them":
                    ThemSPForm form = new ThemSPForm();
                    form.ShowDialog();
                    LoadGridView();
                    break;

            }
        }

        private void SP_gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaSP = SP_gridview.Rows[e.RowIndex].Cells[0].Value.ToString();
            string tenSP = SP_gridview.Rows[e.RowIndex].Cells[1].Value.ToString();
            string Loai = SP_gridview.Rows[e.RowIndex].Cells[2].Value.ToString();
            string Gia = SP_gridview.Rows[e.RowIndex].Cells[3].Value.ToString();

            SanPhamInfo sp = new SanPhamInfo();
            sp.masp = MaSP;
            sp.tensp = tenSP;
            sp.loai = Loai;
            sp.gia = Gia;
            sp.ShowDialog();
        }
        
        private void BtnThemSP_Click(object sender, EventArgs e)
        {
            ThemSPForm form = new ThemSPForm();
            form.ShowDialog();
            LoadGridView();

        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SanPhamDAO dao = new SanPhamDAO();
            string searchname = search.Text;
            dt = dao.GetAllSanPham();
            SP_gridview.DataSource = dt;

            dt.DefaultView.RowFilter = string.Format("[{1}] LIKE '%{0}%'" +
                                                  "OR [{2}] LIKE '%{0}%'"+
                                                  "OR [{3}] LIKE '%{0}%'", search.Text,"Tên sản phẩm","Mã sản phẩm","Loại");
            
        }
    }
}
