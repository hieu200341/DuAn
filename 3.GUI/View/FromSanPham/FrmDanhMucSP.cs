using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.GUI.View.FromSanPham
{
    public partial class FrmDanhMucSP : Form
    {
        private IQLsanPhamServices _QLsanPhamServices;
        public sanPham1 _sanPham;
        public FrmDanhMucSP()
        {
            _QLsanPhamServices = new QLsanPhamServices();
            _sanPham = new sanPham1();
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            dtgv_danhMucSp.Rows.Clear();
            foreach (var item in _QLsanPhamServices.GetsanPhamFromDB())
            {
                dtgv_danhMucSp.Rows.Add(item.IDsanPham, item.tenLoaiHang,
                    item.trangThai == true ? "Còn hàng" : "Hết hàng");
            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            sanPham1 accSP = _QLsanPhamServices.GetsanPhamFromDB().FirstOrDefault
              (p => p.tenLoaiHang == tbt_tenDanhMuc.Text);
            if (tbt_tenDanhMuc.Text == "")
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            else if (accSP != null)
            {
                MessageBox.Show("Tên màu đã tồn tại");
                tbt_tenDanhMuc.Text = "";
            }
            else
            {
                sanPham1 addSP = new sanPham1()
                {
                    tenLoaiHang = tbt_tenDanhMuc.Text,
                    trangThai = rb_HoatDong.Checked,
                };
                _QLsanPhamServices.addsanPham(addSP);
                MessageBox.Show("Thêm danh mục sản phẩm thành công");
                loadData();
            }
        }

        private void btb_CapNhat_Click(object sender, EventArgs e)
        {
            if (_sanPham == null)
            {
                MessageBox.Show("Vui lòng chọn màu sắc");
            }
            else
            {
                if (_sanPham.tenLoaiHang == tbt_tenDanhMuc.Text || (_sanPham.tenLoaiHang != tbt_tenDanhMuc.Text && _QLsanPhamServices.GetsanPhamFromDB().FirstOrDefault(x => x.tenLoaiHang == tbt_tenDanhMuc.Text) == null))
                {
                    _sanPham.tenLoaiHang = tbt_tenDanhMuc.Text;
                    _sanPham.trangThai = rb_HoatDong.Checked;
                    _QLsanPhamServices.UpdatesanPham(_sanPham);
                    MessageBox.Show("Cập nhật thành công");
                    loadData();
                    tbt_tenDanhMuc.Text = "";
                }
                else
                {
                    MessageBox.Show("Tên màu sắc đã tồn tại");
                }
            }
        }

        private void dtgv_danhMucSp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv_danhMucSp.Rows[e.RowIndex];
                _sanPham = _QLsanPhamServices.GetsanPhamFromDB().FirstOrDefault(x => x.IDsanPham == Convert.ToInt32(row.Cells[0].Value));
                tbt_tenDanhMuc.Text = row.Cells[1].Value.ToString();
                rb_HoatDong.Checked = row.Cells[2].Value.ToString() == "Còn hàng" ? true : false;
                rb_KHD.Checked = row.Cells[2].Value.ToString() == "Hết hàng" ? true : false;
            }
        }
    }
}
