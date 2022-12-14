﻿using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModel;
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace _3.GUI.View.BanHang
{
    public partial class FrmHoaDonn : Form
    {
        IQLhoaDonServices _HDservices;
        IQLnhanVienServices _NHanVienServices;
        IQLkhachHangServices _KHSer;
        List<hoaDon> _lstOrder;
        List<ViewHoaDonCT> _lstHDCT;
        IQLhoaDonChiTietServices _HDCTser;
       private hoaDon _HD;
        private IQLsanPhamChiTietServices _qLsanPhamChiTiet;
        int _idHD;
        public FrmHoaDonn()
        {
            InitializeComponent();
            _HDservices = new QLhoaDonServices();
            _NHanVienServices = new QLnhanVienServices();
            _KHSer = new QLkhachHangServices();
            _HDCTser = new QLhoaDonChiTietServices();
            _lstOrder = _HDservices.GetHoaDonFromDB();
            _lstHDCT = new List<ViewHoaDonCT>();
            _HD = new hoaDon();
            _qLsanPhamChiTiet = new QLsanPhamChiTietServices();
            //tbt_ghiChu.Visible= false;
            //tbt_MaHD.Visible= false;
            //tbt_maNV.Visible= false;
            //tbt_SDT.Visible= false;
            //tbt_tongTien.Visible= false;
            //dtp_ngay.Visible= false;
            LoadHD();
        }
        public void LoadHD()
        {
            dtgv_hoaDon.Rows.Clear();
            foreach (var i in _HDservices.GetHoaDonFromDB())
            {
                dtgv_hoaDon.Rows.Add(i.IDHoaDon, i.IDNhanVien, i.SDT_KH, i.tongTien, i.ngayBan, i.ghiChu, i.trangThai == true ? "Đã thanh toán" : "Chưa thanh toán");
            }
        }
        public void LoadHDCT(int maHoaDon)
        {
            _idHD = maHoaDon;
            dtgv_CTHD.Rows.Clear();
            foreach (var i in _HDCTser.getViewHoaDonChiTiet(maHoaDon))
            {
                dtgv_CTHD.Rows.Add(i.ID, i.maSanPham, i.tenSanPham, i.soLuong, i.donGia);
            }
        }

        private void dtgv_hoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtgv_hoaDon.Rows[e.RowIndex];
                LoadHDCT(Convert.ToInt32(r.Cells[0].Value));
                tbt_MaHD.Text = r.Cells[0].Value.ToString();
                tbt_maNV.Text = r.Cells[1].Value.ToString();
                tbt_SDT.Text = r.Cells[2].Value.ToString();
                tbt_tongTien.Text = r.Cells[3].Value.ToString();
                dtp_ngay.Text = r.Cells[4].Value.ToString();
                tbt_ghiChu.Text = r.Cells[5].Value.ToString();
                rb_ChuaThanhToan.Checked = r.Cells[6].Value.ToString() == "Chưa thanh toán" ? true : false;
                rb_daThanhToan.Checked = r.Cells[6].Value.ToString() == "Đã thanh toán" ? true : false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var updateHD = _HDservices.GetHoaDonFromDB().FirstOrDefault(p => Convert.ToString( p.IDHoaDon) == tbt_MaHD.Text);
            //var HDD = _HDservices.GetHoaDonFromDB().FirstOrDefault(p=>p.trangThai == rb_daThanhToan.Checked);
            if(updateHD == null){
                MessageBox.Show("Vui lòng chọn hóa đơn");
            }
            else if(tbt_SDT.Text == "0123456789")
            {
                if (updateHD.trangThai == true)
                {
                    if (rb_daThanhToan.Checked == true)
                    {
                        MessageBox.Show("Hóa đơn đã thanh toán");
                    }
                    else
                    {
                        updateHD.trangThai = rb_daThanhToan.Checked;
                        _HDservices.UpdateHoaDon(updateHD);
                        MessageBox.Show("Cập nhật hóa đơn thành công");
                        LoadHD();
                    }

                }
                else
                {
                    if (rb_ChuaThanhToan.Checked == false)
                    {
                        updateHD.trangThai = rb_daThanhToan.Checked;
                        _HDservices.UpdateHoaDon(updateHD);
                        MessageBox.Show("Cập nhật hóa đơn thành công");
                        LoadHD();
                    }
                    else
                    {
                        MessageBox.Show("Hóa đơn chưa thanh toán");
                    }

                }
            }
            else
            {
                if (updateHD.trangThai == true)
                {
                    if (rb_daThanhToan.Checked == true)
                    {
                        MessageBox.Show("Hóa đơn đã thanh toán");
                    }
                    else
                    {
                        updateHD.trangThai = rb_daThanhToan.Checked;
                        _HDservices.UpdateHoaDon(updateHD);
                        var updateKH = _KHSer.GetkhachHangFromDB().FirstOrDefault(p => p.SDT_KH == tbt_SDT.Text);
                        updateKH.diem = updateKH.diem -= Convert.ToInt32((updateHD.tongTien * 10) / 100);
                        _KHSer.UpdateKhachHang(updateKH);
                        MessageBox.Show("Cập nhật hóa đơn thành công");
                        LoadHD();
                    }
                    
                }
                else{
                    if (rb_ChuaThanhToan.Checked == false)
                    {
                        updateHD.trangThai = rb_daThanhToan.Checked;
                        _HDservices.UpdateHoaDon(updateHD);
                        var updateKH = _KHSer.GetkhachHangFromDB().FirstOrDefault(p => p.SDT_KH == tbt_SDT.Text);
                        updateKH.diem = updateKH.diem += Convert.ToInt32((updateHD.tongTien * 10) / 100);
                        _KHSer.UpdateKhachHang(updateKH);
                        MessageBox.Show("Cập nhật hóa đơn thành công");
                        LoadHD();
                    }
                    else
                    {
                        MessageBox.Show("Hóa đơn chưa thanh toán");
                    }

                }
              
            }
                
               
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_timk_Click(object sender, EventArgs e)
        {
            dtgv_hoaDon.Rows.Clear();
            dtgv_CTHD.Rows.Clear();
            int value;
            if (textBox1.Text != " ")
            {
                if (int.TryParse(textBox1.Text, out value))
                {
                    var items = _lstOrder.Where(x => x.IDHoaDon.ToString().Contains(value.ToString()));
                    if (items.Any())
                    {
                        foreach (var i in items)
                        {
                            dtgv_hoaDon.Rows.Add(i.IDHoaDon, i.IDNhanVien, i.SDT_KH, i.tongTien, i.ngayBan, i.ghiChu, i.trangThai == true ? "Đã thanh toán" : "Chưa thanh toán");
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

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var accHD = _HDservices.GetHoaDonFromDB().FirstOrDefault(p => Convert.ToString(p.IDHoaDon) == tbt_MaHD.Text);
            //var HDD = _HDservices.GetHoaDonFromDB().FirstOrDefault(p=>p.trangThai == rb_daThanhToan.Checked);
            var HDCT = _HDCTser.GetHoaDonChiTietFromDB().FirstOrDefault(p=> Convert.ToString(p.IDHoaDon) == tbt_MaHD.Text);
            if (accHD == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn");
            }else if(tbt_SDT.Text == "0123456789")
            {
                _HDservices.RemoveHoaDon(accHD);
                var updateSP = _qLsanPhamChiTiet.GetSanPhamCTTFromDB().FirstOrDefault(p => p.IDsanPham == HDCT.IDSanPham);
                updateSP.Soluong = updateSP.Soluong += HDCT.Soluong;
                _qLsanPhamChiTiet.UpdateSanPham(updateSP);
                MessageBox.Show("Xóa hóa đơn thành công");
                LoadHD();
            }
            else
            {
                _HDservices.RemoveHoaDon(accHD);
                var updateKH = _KHSer.GetkhachHangFromDB().FirstOrDefault(p => p.SDT_KH == tbt_SDT.Text);
                updateKH.diem = updateKH.diem -= Convert.ToInt32((accHD.tongTien * 10) / 100);
                _KHSer.UpdateKhachHang(updateKH);
                var updateSP = _qLsanPhamChiTiet.GetSanPhamCTTFromDB().FirstOrDefault(p=>p.IDsanPham == HDCT.IDSanPham);
                updateSP.Soluong = updateSP.Soluong += HDCT.Soluong;
                _qLsanPhamChiTiet.UpdateSanPham(updateSP);
                MessageBox.Show("Xóa hóa đơn thành công");
                LoadHD();
            }
        }
    }
}
