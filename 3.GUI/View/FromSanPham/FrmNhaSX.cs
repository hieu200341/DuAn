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

namespace _3.GUI.View
{
    public partial class FrmNhaSX : Form
    {
        private IQLhangSXServices _QLhangSXServices;
        private hangSX _hangSX;
        public FrmNhaSX()
        {
            _QLhangSXServices = new QLhangSXServices();
            _hangSX= new hangSX();
            InitializeComponent();
            loadDuLieu();
        }

        public void loadDuLieu()
        {
            dtgv_NSX.Rows.Clear();
            foreach (var item in _QLhangSXServices.GetHangSXFromDB())
            {
                dtgv_NSX.Rows.Add(item.maHangSX, item.tenHangSX,
                    item.trangThai == true ? "Hoạt động" : "KHĐ");
            }
            //lblThongKe.Text = "Tổng số nhà cung cấp: " + dtgv_NCC.Rows.Count;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            hangSX accNCC = _QLhangSXServices.GetHangSXFromDB().FirstOrDefault
              (p => p.maHangSX == tbt_maNSX.Text);
            if (tbt_maNSX.Text == "" || tbt_TenNSX.Text == "")
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            else if (accNCC != null)
            {
                MessageBox.Show("Mã nhà sản xuất đã tồn tại");
                tbt_maNSX.Text = "";
            }
            else
            {
                hangSX ncc = new hangSX()
                {
                    maHangSX = tbt_maNSX.Text,
                    tenHangSX = tbt_TenNSX.Text,
                    trangThai = rb_HoatDong.Checked,
                };
                _QLhangSXServices.addHangSX(ncc);
                MessageBox.Show("Thêm nhà cung cấp thành công");
                loadDuLieu();
            }
        }

        private void btb_CapNhat_Click(object sender, EventArgs e)
        {
            var update = _QLhangSXServices.GetHangSXFromDB().FirstOrDefault(p => p.maHangSX == tbt_maNSX.Text);
            if (update != null)
            {
                update.tenHangSX = tbt_TenNSX.Text;
                update.trangThai = rb_HoatDong.Checked;
                _QLhangSXServices.UpdateHangSX(update);
                MessageBox.Show("sửa thành công");
                loadDuLieu();
            }
            else
            {
                MessageBox.Show("Bạn nhập sai mã nhà cung cấp");
            }
        }

        private void dtgv_NSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtgv_NSX.Rows[e.RowIndex];
            tbt_maNSX.Text = row.Cells[0].Value.ToString();
            tbt_TenNSX.Text = row.Cells[1].Value.ToString();
            rb_HoatDong.Checked = row.Cells[2].Value.ToString() == "Hoạt động" ? true : false;
            rb_KHD.Checked = row.Cells[2].Value.ToString() == "KHĐ" ? true : false;
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            tbt_maNSX.Clear();
            tbt_TenNSX.Clear();
            rb_HoatDong.Checked = true;
        }
    }
}
