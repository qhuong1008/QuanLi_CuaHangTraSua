using CuaHangTraSua.DAO;
using CuaHangTraSua.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangTraSua.GUI
{
    public partial class HoaDonForm : Form
    {
        //Panel panelPrint;
        public string khachtra { get; set; }
        public string tongtien { get; set; }
        public string tienthua { get; set; }
        public string thoigian { get; set; }

        public HoaDonForm()
        {
            InitializeComponent();
        }
        private void loadDSDonHang(DataTable DonHangList)
        {
            donhang_gridview.Columns.Clear();
            donhang_gridview.DataSource = DonHangList;
            donhang_gridview.Columns[0].Visible = false;
            donhang_gridview.Columns[1].Visible = false;
            donhang_gridview.Columns[6].Visible = false;
           
            donhang_gridview.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            donhang_gridview.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            donhang_gridview.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            donhang_gridview.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;      

        }
        private void HoaDonForm_Load(object sender, EventArgs e)
        {
            try
            {
                /*DonHangDAO DonHangdao = new DonHangDAO();

                loadDSDonHang(DonHangdao.GetAllDonHang());*/
                HoaDonDAO dao = new HoaDonDAO();
                loadDSDonHang(dao.GetHoaDon());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            

            tongtientxt.Text = Convert.ToString(tongtien);
            txtKhachTra.Text = Convert.ToString(khachtra);
            txtTienthua.Text = Convert.ToString(tienthua);
            txtThoigian.Text = Convert.ToString(donhang_gridview.Rows[0].Cells[6].Value);
        }
        private void Print(Panel pn)
        {
            PrinterSettings ps = new PrinterSettings();
            getprintarea(pn);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }
        private Bitmap memoryimg;
        private void getprintarea(Panel pn)
        {
            memoryimg = new Bitmap(pn.Width, pn.Height);
            pn.DrawToBitmap(memoryimg, new Rectangle(0, 0, pn.Width, pn.Height));
        } 

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            Print(this.panelPrint);
        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.panelPrint.Width / 2), this.panelPrint.Location.Y);
        }

        private void donhang_gridview_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var height = donhang_gridview.Rows[0].Height;
            foreach (DataGridViewRow dr in donhang_gridview.Rows)
            {
                height += dr.Height;
            }

            donhang_gridview.Height = height;
        }

        private void printerBtn_Click(object sender, EventArgs e)
        {
            Print(this.panelPrint);
        }

        private void txtKhachTra_Click(object sender, EventArgs e)
        {

        }
    }
}
