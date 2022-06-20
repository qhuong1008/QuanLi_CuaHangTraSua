using CuaHangTraSua.DAO;
using CuaHangTraSua.DTO;
using CuaHangTraSua.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangTraSua.GUI
{
    public partial class QuanLiNhanVien : Form
    {
        public QuanLiNhanVien()
        {
            InitializeComponent();

        }
        private void loadDSNhanVien(IEnumerable<NhanVienView> listNhanVien)
        {
            InfoNV_gridview.Columns.Clear();
            InfoNV_gridview.DataSource = listNhanVien;

            InfoNV_gridview.Columns[nameof(NhanVienView.MaNV)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            InfoNV_gridview.Columns[nameof(NhanVienView.HoTen)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            InfoNV_gridview.Columns[nameof(NhanVienView.NgaySinh)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            InfoNV_gridview.Columns[nameof(NhanVienView.QueQuan)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            InfoNV_gridview.Columns[nameof(NhanVienView.Luong)].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            InfoNV_gridview.Columns[nameof(NhanVienView.Luong)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            InfoNV_gridview.AllowUserToResizeColumns = true;
        }


        public void LoadGridView()
        {

            NhanVienDAO dao = new NhanVienDAO();
            List<NhanVienView> nhanVienViews = new List<NhanVienView>();

            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");

            nhanVienViews.AddRange(dao.GetAll().Select(s => new NhanVienView()
            {
                MaNV = s.MaNV,
                NgaySinh = s.NgaySinh.ToString("dd/MM/yyyy"),
                HoTen = s.HoTen,
                QueQuan = s.QueQuan,
                Luong = $"{s.Luong.ToString("#,###", cul.NumberFormat)} VND"
            }).ToList());

            loadDSNhanVien(nhanVienViews);
        }

        private void QuanLiNhanVien_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

            FormBorderStyle = FormBorderStyle.Sizable;
            TopMost = false;
            WindowState = FormWindowState.Normal;


            try
            {
                LoadGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name.ToString())
            {
                case "Them":
                    var themnv = new ThemNhanVienForm();
                    themnv.ShowDialog();
                    LoadGridView();
                    break;

            }
        }

        private void InfoNV_gridview_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new ContextMenuStrip();
                menu.Items.Add("Thêm").Name = "Them";


                int index = InfoNV_gridview.HitTest(e.X, e.Y).RowIndex;
                menu.Show(InfoNV_gridview, new Point(e.X, e.Y));


                //event menu clicked
                menu.ItemClicked += new ToolStripItemClickedEventHandler(menu_ItemClicked);
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            ThemNhanVienForm themNV = new ThemNhanVienForm();
            themNV.InfoNV_gridview = InfoNV_gridview;          
            themNV.ShowDialog();

           
            try
            {
                LoadGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InfoNV_gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                LoadGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InfoNV_gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaNV = InfoNV_gridview.Rows[e.RowIndex].Cells[0].Value.ToString();

            NhanVienInFor nv = new NhanVienInFor();
            nv.MaNV = MaNV;
            nv.ShowDialog();
            LoadGridView();

        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            NhanVienDAO dao = new NhanVienDAO();
            string searchname = search.Text;
            dt = dao.GetAllNhanVien();
            InfoNV_gridview.DataSource = dt;

            dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%' " +
                                                  "OR [{2}] LIKE '%{1}%'" + 
                                                  "OR [{3}] LIKE '%{1}%'","Mã nhân viên", search.Text, "Họ tên","Quê quán");
        }
    }
}
