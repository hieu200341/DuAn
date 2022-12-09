using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2.BUS.Services;
using _2.BUS.IServices;
using _2.BUS.ViewModel;
using _1.DAL.Models;
using OfficeOpenXml;

namespace _3.GUI.View
{
    public partial class FrmThongKe : Form
    {
        private IQLhoaDonServices _order;
        private IQLhoaDonChiTietServices _orderdetail;
        private IQLkhachHangServices _customer;
        private IQLsanPhamChiTietServices _product;
        public List<hoaDon> _lstOrder;
        public List<hoaDonChiTiet> _lstOrderDetail;
        public List<khachHang> _lstCustomer;
        public List<ViewHienThi1> _lst;

        public FrmThongKe()
        {
            InitializeComponent();
            _order = new QLhoaDonServices();
            _orderdetail = new QLhoaDonChiTietServices();
            _customer = new QLkhachHangServices();
            _product = new QLsanPhamChiTietServices();
            _lstOrder = _order.GetHoaDonFromDB();
            _lstOrderDetail = new List<hoaDonChiTiet>();
            _lstCustomer = new List<khachHang>();
            loadDate();
            loadData();
        }
        public void loadDate()
        {
            for (int i = 1; i < 13; i++)
            {
                cbb_thang.Items.Add(i);
            }
            //var x = Convert.ToInt32(_order.GetHoaDonFromDB().First().ngayBan.ToString("yyyy"));
            //var y = Convert.ToInt32(_order.GetHoaDonFromDB().Last().ngayBan.ToString("yyyy"));
            for (int i = 0; i <= 9999; i++)
            {
                cbb_nam.Items.Add(i);
            }
        }
        public void loadData()
        {
            dtgv_show.ColumnCount = 8;
            dtgv_show.Columns[0].Name = "Mã hóa đơn";
            dtgv_show.Columns[1].Name = "Tên sản phẩm";
            dtgv_show.Columns[2].Name = "Số lượng";
            dtgv_show.Columns[3].Name = "Đơn giá";
            dtgv_show.Columns[4].Name = "Tổng tiền";
            dtgv_show.Columns[5].Name = "Tổng tiền trong hóa đơn";
            dtgv_show.Columns[6].Name = "Ngày bán";
            dtgv_show.Columns[7].Name = "Trạng thái";

            dtgv_show.Rows.Clear();
            var x = (from a in _lstOrder
                     join b in _customer.GetkhachHangFromDB() on a.SDT_KH equals b.SDT_KH
                     join c in _orderdetail.GetHoaDonChiTietFromDB() on a.IDHoaDon equals c.IDHoaDon
                     join d in _product.GetSanPhamCTTFromDB() on c.IDSanPham equals d.IDsanPham
                     where b.SDT_KH.Contains(tb_sdt.Text) && d.TenSP.ToLower().Contains(tb_timkiem.Text.ToLower())
                     select new { a, b, c, d });

            foreach (var i in x)
            {
                dtgv_show.Rows.Add(i.a.IDHoaDon, i.d.TenSP, i.c.Soluong, i.c.donGia, i.c.donGia * i.c.Soluong,i.a.tongTien, i.a.ngayBan, i.a.trangThai == true ? "Đã thanh toán": "Chưa thanh toán" ) ;
            }

            lb_doanhthu.Text = x.Select(x => x.a).Distinct().Sum(x => x.tongTien).ToString();
            lb_tonghd.Text = x.GroupBy(x => x.a).Count().ToString();
            lb_chuathanhtoan.Text = x.Select(x => x.a).Distinct().Where(x => x.trangThai == false).Count().ToString();
            lb_khachhang.Text = x.GroupBy(x => x.b).Count().ToString();
        }
        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void dtp_ngay_ValueChanged(object sender, EventArgs e)
        {
            _lstOrder = _order.GetHoaDonFromDB().Where(x => x.ngayBan.ToString("dd-MM-yyyy") == dtp_ngay.Value.ToString("dd-MM-yyyy")).ToList(); 
            loadData();
        }

        private void cbb_thang_TextChanged(object sender, EventArgs e)
        {
            if (cbb_nam.Text != "")
            {
                _lstOrder = _order.GetHoaDonFromDB().Where(x => (x.ngayBan.Month.ToString() == cbb_thang.Text && x.ngayBan.Year.ToString() == cbb_nam.Text)).ToList();
                loadData();
            }
        }

        private void cbb_nam_TextChanged(object sender, EventArgs e)
        {
            if (cbb_thang.Text != "")
            {
                _lstOrder = _order.GetHoaDonFromDB().Where(x => (x.ngayBan.Month.ToString() == cbb_thang.Text && x.ngayBan.Year.ToString() == cbb_nam.Text)).ToList();
                loadData();
            }
            else
            {
                _lstOrder = _order.GetHoaDonFromDB().Where(x => x.ngayBan.Year.ToString() == cbb_nam.Text).ToList();
                loadData();
            }
        }

        private void tb_sdt_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tb_sdt.Text, out int x) || tb_sdt.Text.Length <= 10)
            {
                loadData();
            }
            else
            {
                dtgv_show.Rows.Clear();
            }
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
                
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {

        }
        private void senderexcel(string path)
        {
            using (ExcelPackage p = new ExcelPackage())
            {
                // đặt tên người tạo file
                p.Workbook.Properties.Author = "";

                // đặt tiêu đề cho file
                p.Workbook.Properties.Title = "Báo cáo thống kê";

                //Tạo một sheet để làm việc trên đó
                p.Workbook.Worksheets.Add("sheet");

                // lấy sheet vừa add ra để thao tác
                ExcelWorksheet ws = p.Workbook.Worksheets[1];

                // đặt tên cho sheet
                ws.Name = "sheet";
                // fontsize mặc định cho cả sheet
                ws.Cells.Style.Font.Size = 11;
                // font family mặc định cho cả sheet
                ws.Cells.Style.Font.Name = "Calibri";

                for (int i = 0; i < dtgv_show.Columns.Count; i++)
                {
                    ws.Cells[1, i + 1].Value = dtgv_show.Columns[i].HeaderText;
                }
                for (int i = 0; i < dtgv_show.Rows.Count; i++)
                {
                    for (int j = 0; j < dtgv_show.Columns.Count; j++)
                    {
                        ws.Cells[i + 2, j + 1].Value = dtgv_show.Rows[i].Cells[j].Value;
                    }
                }
                //Lưu file lại
                Byte[] bin = p.GetAsByteArray();
                File.WriteAllBytes(path, bin);

                /*excel.Application application = new excel.Application();
                application.Application.Workbooks.Add(Type.Missing);
                for (int i = 0; i < dtgv_HDcho.Columns.Count; i++)
                {
                    application.Cells[1, i + 1] = dtgv_HDcho.Columns[i].HeaderText;
                }
                for (int i = 0; i < dtgv_HDcho.Rows.Count; i++)
                {
                    for (int j = 0; j < dtgv_HDcho.Columns.Count; j++)
                    {
                        application.Cells[i + 2, j + 1] = dtgv_HDcho.Rows[i].Cells[j].Value;
                    }
                }
                application.Columns.AutoFit();
                application.ActiveWorkbook.SaveCopyAs(path);
                application.ActiveWorkbook.Saved = true;*/
            };
        }

        private void btn_xuat_Click(object sender, EventArgs e)
        {
            string filePath = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;
                try
                {
                    senderexcel(filePath);
                    MessageBox.Show("Xuất File Excel Thành công");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Xuất File Excel không  Thành công" + ex.Message);
                }
            }
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
