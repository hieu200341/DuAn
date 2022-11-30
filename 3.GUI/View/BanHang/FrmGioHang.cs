using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.GUI.View.BanHang
{
    public partial class FrmGioHang : Form
    {
        private IQLsanPhamServices _qLsanPhamServices;
        private IQLhoaDonChiTietServices _qLhoaDonChiTietServices;
        private IQLhoaDonServices _qLhoaDonServices;
        private List<hoaDonCT> _listHoaDon;
        public int pID;
        public khachHang c;
        public int oID;
        public FrmGioHang()
        {
            _qLsanPhamServices= new QLsanPhamServices();
            _qLhoaDonChiTietServices = new QLhoaDonChiTietServices();
            _qLhoaDonServices= new QLhoaDonServices();
            _listHoaDon= new List<hoaDonCT>();
            InitializeComponent();
            LoadSanPham();
            LoadGioHang();
        }
        public void LoadSanPham()
        {
            dtgv_sanPham.Rows.Clear();
            foreach (var item in _qLsanPhamServices.getViewSanPham())
            {
                dtgv_sanPham.Rows.Add(item.SanPhams.maSanPham, item.SanPhams.TenSP, item.mauSacs.tenMau, item.sizes.SiZe, item.SanPhams.Giaban, item.hangSXs.tenHangSX, item.SanPhams.Soluong);
            }
        }
        public void LoadGioHang()
        {
            dtgv_gioHang.Rows.Clear();
            foreach (var item in _listHoaDon)
            {
                dtgv_gioHang.Rows.Add(item.maSanPham, item.tenSanPham, item.soLuong, item.donGia);
            }
        }
        public void addCart(int pID)
        {
            var p = _qLsanPhamServices.GetSanPhamFromDB().FirstOrDefault(x => x.maSanPham == pID);
            var data = _listHoaDon.FirstOrDefault(x => x.maSanPham == p.maSanPham);
            if (data == null)
            {
                hoaDonCT hdct = new hoaDonCT()
                {
                    maSanPham = p.maSanPham,
                    tenSanPham = p.TenSP,
                    donGia = p.Giaban,
                    soLuong = 1,
                    //MaSp = p.MaSp
                };
                _listHoaDon.Add(hdct);
            }
            else
            {
                if (data.soLuong == p.Soluong)
                {
                    MessageBox.Show("Sản phẩm trong giỏ hàng đã vượt quá số lượng cho phép");
                }
                else
                {
                    data.soLuong++;
                }
            }
            LoadGioHang();
        }

        private void dtgv_gioHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtgv_gioHang.Rows[e.RowIndex];
                if (int.TryParse(dtgv_gioHang.Rows[r.Index].Cells[2].Value.ToString(), out int x))
                {
                    if (dtgv_gioHang.Rows[r.Index].Cells[2].Value != _listHoaDon[r.Index].soLuong.ToString())
                    {
                        if (Convert.ToInt32(dtgv_gioHang.Rows[r.Index].Cells[2].Value) <= 0)
                        {
                            MessageBox.Show("Nhập sai số lượng");
                            dtgv_gioHang.Rows[r.Index].Cells[2].Value = _listHoaDon[r.Index].soLuong;
                        }
                        else
                        {
                            var p = _qLsanPhamServices.GetSanPhamFromDB().FirstOrDefault(x => x.maSanPham == _listHoaDon[r.Index].maSanPham);
                            if (p.Soluong < Convert.ToInt32(dtgv_gioHang.Rows[r.Index].Cells[2].Value))
                            {
                                MessageBox.Show("Sản phẩm trong giỏ hàng đã vượt quá số lượng cho phép");
                                dtgv_gioHang.Rows[r.Index].Cells[2].Value = _listHoaDon[r.Index].soLuong;
                            }
                            else
                            {
                                _listHoaDon[r.Index].soLuong = Convert.ToInt32(dtgv_gioHang.Rows[r.Index].Cells[2].Value);
                                //totalCart();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nhập sai số lượng");
                    dtgv_gioHang.Rows[r.Index].Cells[2].Value = _listHoaDon[r.Index].soLuong;
                }
            }
        }

        private void dtgv_sanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtgv_gioHang.Rows[e.RowIndex];
                //pID = Convert.ToString(r.Cells[0].Value.ToString());
                pID = _qLsanPhamServices.GetSanPhamFromDB().FirstOrDefault(x => Convert.ToString(x.maSanPham) == r.Cells[0].Value.ToString()).maSanPham;
                addCart(pID);
            }
        }

        private void dtgv_gioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtgv_gioHang.Rows[e.RowIndex];
                //pID = Convert.ToInt32(r.Cells[0].Value.ToString());
                pID = _qLsanPhamServices.GetSanPhamFromDB().FirstOrDefault(x => Convert.ToString(x.maSanPham) == r.Cells[0].Value.ToString()).maSanPham;
            }
        }
    }
}
