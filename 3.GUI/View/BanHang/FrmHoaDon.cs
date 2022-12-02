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
        IQLnhanVienServices _NVservices;
        IQLkhachHangServices _KHservices;
        int _maHD;
        public FrmHoaDon()
        {
            InitializeComponent();
            _HDservices = new QLhoaDonServices();
            _NVservices = new QLnhanVienServices();
            _KHservices = new QLkhachHangServices();
            LoadNV();
            LoaKH();
            LoadDgrid();
        }
        public void LoadNV()
        {
            foreach(var c in _NVservices.GetNhanVienFromDB())
            {
                cmb_TenNV.Items.Add(c.nhanViens.TenNV);
            }
        }
        public void LoaKH()
        {
           foreach(var c in _KHservices.GetkhachHangFromDB())
            {
                cmb_TenKH.Items.Add(c.TenKH);
            }
        }
        public void LoadDgrid()
        {
            dgrid_hoadon.Rows.Clear();
            dgrid_hoadon.ColumnCount = 6;
            dgrid_hoadon.Columns[0].Name = "Mã hóa đơn";
            dgrid_hoadon.Columns[1].Name = "Tên nhân viên";
            dgrid_hoadon.Columns[2].Name = "Tên Khách Hàng";
            dgrid_hoadon.Columns[3].Name = "Ngày bán";
            dgrid_hoadon.Columns[4].Name = "Ngày thanh toán";
            dgrid_hoadon.Columns[5].Name = "Tình trạng";
            if (txt_timkiem.Text != "")
            {

            }
            foreach (var item in _HDservices.GetHoaDonFromDB())
            {
                dgrid_hoadon.Rows.Add(item.hoaDons.maHoaDon, item.nhanViens.TenNV, item.khachHangs.TenKH, item.hoaDons.ngayBan, item.hoaDons.ngayTT, item.hoaDons.trangThai == true ? "Đã thanh toán" : "Chưa thanh toán");
            }
        }
        private ViewHienThi1 GetDBfrGUI()
        {
            ViewHienThi1 HDd = new ViewHienThi1();
            HDd.hoaDons = new hoaDon()
            {
                maHoaDon = _maHD,
                maNhanVien = _NVservices.GetNhanVienFromDB()[cmb_TenNV.SelectedIndex].nhanViens.maNhanVien,
                SDT_KH = _KHservices.GetkhachHangFromDB()[cmb_TenKH.SelectedIndex].SDT_KH,
                ngayBan = Convert.ToDateTime(dtp_nb.Text),
                ngayTT = Convert.ToDateTime(dtp_nb.Text),
                trangThai = rbtn_dathanhtoan.Checked == true ? true:false,
            };
            return HDd;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_HDservices.addHoaDon(GetDBfrGUI()));
            LoadDgrid();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_HDservices.RemoveHoaDon(GetDBfrGUI()));
            LoadDgrid();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_HDservices.UpdateHoaDon(GetDBfrGUI()));
            LoadDgrid();
        }

        private void dgrid_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = e.RowIndex;
            if (a == _HDservices.GetHoaDonFromDB().Count()) return;
            _maHD = Convert.ToInt32(dgrid_hoadon.CurrentRow.Cells[0].Value.ToString()); ;
            var obj = _HDservices.GetHoaDonFromDB().FirstOrDefault(c => c.hoaDons.maHoaDon == _maHD);
            txt_MaHD.Text = _maHD.ToString();
            cmb_TenKH.SelectedItem = obj.khachHangs.TenKH;
            cmb_TenNV.SelectedItem = obj.nhanViens.TenNV;
            dtp_nb.Text = Convert.ToString(obj.hoaDons.ngayBan);
            dtp_ntt.Text = Convert.ToString(obj.hoaDons.ngayTT);
            rbtn_dathanhtoan.Checked = dgrid_hoadon.CurrentRow.Cells[5].Value.ToString() == "Đã thanh toán" ? true : false;
            rbtn_Chuatt.Checked = dgrid_hoadon.CurrentRow.Cells[5].Value.ToString() == "Chưa thanh toán" ? true : false;
        }
    }
}
