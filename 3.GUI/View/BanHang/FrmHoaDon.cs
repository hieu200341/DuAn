using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModel;
using _1.DAL.Models;


namespace _3.GUI.View.BanHang
{
    public partial class FrmHoaDon : Form
    {
        IQLhoaDonServices _HDservices;
        IQLnhanVienServices _NHanVienServices;
        IQLkhachHangServices _KHSer;
        List<hoaDon> _lstOrder;
        List<ViewHoaDonCT> _lstHDCT;
        IQLhoaDonChiTietServices _HDCTser;
        int _idHD;
        public FrmHoaDon()
        {
            InitializeComponent();
            _HDservices = new QLhoaDonServices();
            _NHanVienServices = new QLnhanVienServices();
            _KHSer = new QLkhachHangServices();
            _HDCTser = new QLhoaDonChiTietServices();
            _lstOrder = _HDservices.GetHoaDonFromDB();
            _lstHDCT = new List<ViewHoaDonCT>();
            LoadHD();
        }
        private void LoadHD()
        {

            dtg_hoadon.Rows.Clear();
            foreach (var i in _lstOrder)
            {
                dtg_hoadon.Rows.Add(i.IDHoaDon, i.IDNhanVien, i.SDT_KH, i.tongTien, i.ngayBan, i.ghiChu, i.trangThai == true ? "Đã thanh toán" : "Chưa thanh toán");
            }
        }
        private void LoadHDCT(int maHoaDon)
        {
            _idHD = maHoaDon;
            dtg_hoadonchitiet.Rows.Clear();
            foreach (var i in _HDCTser.getViewHoaDonChiTiet(maHoaDon))
            {
                dtg_hoadonchitiet.Rows.Add(i.ID, i.maSanPham, i.tenSanPham, i.soLuong, i.donGia);
            }
        }

        private void dtg_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_hoadon.Rows[e.RowIndex];
                LoadHDCT(Convert.ToInt32(r.Cells[0].Value));
            }
            //if (e.RowIndex >= 0 && e.RowIndex <= dtg_hoadon.RowCount - 1)
            //{
            //    _idHD = Convert.ToInt32(dtg_hoadon.Rows[e.RowIndex].Cells[1].Value.ToString());
            //    _lstHDCT = _HDCTser.getViewHoaDonChiTiet(_HDservices.GetHoaDonFromDB());
            //    foreach (var x in lstHdct)
            //    {
            //        dgrid_ctHoadon.Rows.Add(stt++, x.Ma, x.TenDt, x.DonGia, x.SoLuong, x.ThanhTien, x.TrangThai);
            //    }
            //}
            //else return;
        }

        private void btn_timk_Click(object sender, EventArgs e)
        {
            dtg_hoadon.Rows.Clear();
            dtg_hoadonchitiet.Rows.Clear();
            int value;
            if (tbt_timk.Text != " ")
            {
                if (int.TryParse(tbt_timk.Text, out value))
                {
                    var items = _lstOrder.Where(x => x.IDHoaDon.ToString().Contains(value.ToString()));
                    if (items.Any())
                    {
                        foreach (var i in items)
                        {
                            dtg_hoadon.Rows.Add(i.IDHoaDon, i.IDNhanVien, i.SDT_KH, i.tongTien, i.ngayBan, i.ghiChu, i.trangThai == true ? "Đã thanh toán" : "Chưa thanh toán");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã hóa đơn tương ứng");
                        LoadHD();
                    }
                }
                    else
                {
                    MessageBox.Show("Yêu cầu kiểm tra lại thông tin cần tìm");
                    LoadHD();
                } 
            }
        }
    }
}
