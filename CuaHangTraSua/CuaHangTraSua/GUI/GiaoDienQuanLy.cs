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
using System.Web;
using System.Windows.Forms;


namespace CuaHangTraSua.GUI
{
    public partial class GiaoDienQuanLy : Form
    {
        public string hoten { get; set; }
        public string username { get; set; }
        public string userid { get; set; }
        public int tongtien { get; set; }


        public GiaoDienQuanLy(bool manageChecked)
        {
            InitializeComponent();
            if (manageChecked == true)
            {
                this.Text = "Giao diện quản lý";
            }
            else
            {

                quảnLýNhânViênToolStripMenuItem.Enabled = false;
            }

        }

        public GiaoDienQuanLy()
        {
            InitializeComponent();
        }

        public void GiaoDienQuanLy_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

            FormBorderStyle = FormBorderStyle.Sizable;
            TopMost = false;
            WindowState = FormWindowState.Normal;

            txtUsername.Text = hoten;
            txtUserID.Text = userid;

            LoadDonHangGridView();
            txtTongTien.Text = tinhTongTien().ToString();

            //Load button Sản phẩm
            SanPhamDAO SelectListSP = new SanPhamDAO();
            List<string> proNameList = SelectListSP.GetAllProductName();
            ItemBtn1.Text = proNameList[0];
            ItemBtn2.Text = proNameList[1];
            ItemBtn3.Text = proNameList[2];
            ItemBtn4.Text = proNameList[3];
            ItemBtn5.Text = proNameList[4];
            ItemBtn6.Text = proNameList[5];
            ItemBtn7.Text = proNameList[6];
            ItemBtn8.Text = proNameList[7];
            ItemBtn9.Text = proNameList[8];
            ItemBtn10.Text = proNameList[9];
            ItemBtn11.Text = proNameList[10];
            ItemBtn12.Text = proNameList[11];
            donhang_gridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            donhang_gridview.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;     
        }

        public void StyleDataGrid()
        {
            for (int i = 0; i < donhang_gridview.Columns.Count; i++)
            {
                donhang_gridview.Columns[i].DefaultCellStyle.BackColor = Color.Aqua;
                for (int j = 0; j < donhang_gridview.Rows.Count; j++)
                {
                    if (j % 2 != 0)
                        donhang_gridview.Rows[j].Cells[0].Style.BackColor = Color.Red;
                }
            }
        }
        private void loadDSDonHang(DataTable DonHangList)
        {
            donhang_gridview.Columns.Clear();
            donhang_gridview.DataSource = DonHangList;
        }
        public void LoadDonHangGridView()
        {
            try
            {
                DonHangDAO DonHangdao = new DonHangDAO();
                loadDSDonHang(DonHangdao.GetAllDonHang());
                donhang_gridview.AutoResizeColumns();

                donhang_gridview.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                donhang_gridview.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                donhang_gridview.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                donhang_gridview.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                donhang_gridview.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                donhang_gridview.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public int tinhTongTien()
        {
            return (from DataGridViewRow row in donhang_gridview.Rows
                                where row.Cells[2].FormattedValue.ToString() != string.Empty
                                select Convert.ToInt32(row.Cells[4].FormattedValue)).Sum();
        }

        private void quảnLýMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new QuanLiMenu();
            form.ShowDialog();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new QuanLiNhanVien();
            form.Show();
        }


        private void biểuĐồDoanhSốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new BieuDoDoanhSo();
            form.Show();
        }

        private void báoCáoBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form1 = new BaoCaoBanHangForm();
            form1.Show();
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cửaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ThongTinCuaHang();
            form.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new DangNhap();
            form.ShowDialog();
            this.Close();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void XemthemBtn_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.userid = userid;
            form.ShowDialog();
            LoadDonHangGridView();
            txtTongTien.Text = tinhTongTien().ToString();
        }

        private void BtnTienThua_Click(object sender, EventArgs e)
        {
            if(txtTongTien.Text == "" || txtKhachTra.Text == "")
            {
                txtTienThua.Text = "0";
            }
            else
            {
                int tongtien = Convert.ToInt32(txtTongTien.Text);
                int khachtra = Convert.ToInt32(txtKhachTra.Text);
                int tienthua = khachtra - tongtien;

                if(tienthua <= 0)
                {
                    txtTienThua.Text = "";
                }
                else
                {
                    txtTienThua.Text = Convert.ToString(tienthua);
                }                
            }
        }

        private void previewHoaDon_Click(object sender, EventArgs e)
        {
            var hoadon = new HoaDonForm();
            hoadon.tongtien = (txtTongTien.Text);
            hoadon.khachtra = (txtKhachTra.Text);
            hoadon.tienthua = (txtTienThua.Text);
            if(txtTongTien.Text == "" || txtKhachTra.Text == "" || txtTienThua.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
            else
            {
                hoadon.Show();
            }
            
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            donhang_gridview.DataSource = null;
            HoaDonDAO hoadon = new HoaDonDAO();
            hoadon.CreateHoaDon(userid);
            txtTongTien.Clear();
            txtKhachTra.Clear();
            txtTienThua.Clear();
        }
        private void txtUsername_Click(object sender, EventArgs e)
        {

        }
        private void SanPhamChoosen(string prod_name)
        {
            try
            {
                string prod_id;
                int price;

                SanPhamDAO prod = new SanPhamDAO();
                prod.SelectInforByName(prod_name, out prod_id, out price);

                ItemInfo itemForm = new ItemInfo(price,prod_name,prod_id);
                itemForm.manv = userid;
                itemForm.ShowDialog();

                LoadDonHangGridView();
                txtTongTien.Text = tinhTongTien().ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ItemBtn1_Click(object sender, EventArgs e)
        {
            SanPhamChoosen(ItemBtn1.Text);
        }
        private void ItemBtn2_Click(object sender, EventArgs e)
        {
            SanPhamChoosen(ItemBtn2.Text);
        }

        private void ItemBtn3_Click(object sender, EventArgs e)
        {
            SanPhamChoosen(ItemBtn3.Text);
        }

        private void ItemBtn4_Click(object sender, EventArgs e)
        {
            SanPhamChoosen(ItemBtn4.Text);
        }

        private void ItemBtn5_Click(object sender, EventArgs e)
        {
            SanPhamChoosen(ItemBtn5.Text);
        }

        private void ItemBtn6_Click(object sender, EventArgs e)
        {
            SanPhamChoosen(ItemBtn6.Text);
        }

        private void ItemBtn7_Click(object sender, EventArgs e)
        {
            SanPhamChoosen(ItemBtn7.Text);
        }

        private void ItemBtn8_Click(object sender, EventArgs e)
        {
            SanPhamChoosen(ItemBtn8.Text);
        }

        private void ItemBtn9_Click(object sender, EventArgs e)
        {
            SanPhamChoosen(ItemBtn9.Text);
        }

        private void ItemBtn10_Click(object sender, EventArgs e)
        {
            SanPhamChoosen(ItemBtn10.Text);
        }

        private void ItemBtn11_Click(object sender, EventArgs e)
        {
            SanPhamChoosen(ItemBtn11.Text);
        }

        private void ItemBtn12_Click(object sender, EventArgs e)
        {
            SanPhamChoosen(ItemBtn12.Text);
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDonDAO bill = new HoaDonDAO();
                int total = tinhTongTien();
                bill.UpDateTotal(total);
                MessageBox.Show("Đã thanh toán!", "Thông báo", MessageBoxButtons.OK);
               
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menu_items_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword form = new ChangePassword(username);
            form.ShowDialog();
            if(form.change == true)
            {
                this.Hide();
                var form2 = new DangNhap();
                form2.ShowDialog();
                this.Close();
            }    
        }

        private void donhang_gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = donhang_gridview.Rows[e.RowIndex];

            if (r != null)
            {
                DialogResult clickResult = MessageBox.Show("Có muốn xóa cột này", "Thông báo", MessageBoxButtons.YesNo);
                if (clickResult == DialogResult.Yes)
                {
                    DonHangDAO dh = new DonHangDAO();
                    dh.RemoveDonHang(Convert.ToInt32(r.Cells[0].Value), r.Cells[1].Value.ToString(),
                    Convert.ToInt32(r.Cells[3].Value),
                    Convert.ToInt32(r.Cells[4].Value), r.Cells[5].Value.ToString());
                    MessageBox.Show("Đã xóa!");
                    LoadDonHangGridView();
                    txtTongTien.Text = tinhTongTien().ToString();
                }
            }
        }

        
    }
    
}


