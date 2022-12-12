using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.Services;
using _3.GUI.Utilities;
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
    public partial class FrmKH : Form
    {
        private IQLkhachHangServices _QLkhachHangServices;
        private khachHang _khachHang;
        string sdt = "";
        public FrmKH()
        {
            _QLkhachHangServices = new QLkhachHangServices();
            _khachHang = new khachHang();
            InitializeComponent();
            loaddata();
        }
        private void loaddata()
        {
            dtgv_KH.ColumnCount = 5;
            dtgv_KH.Columns[0].Name = "Số Điện Thoại";
            dtgv_KH.Columns[1].Name = "Tên Khách Hàng";
            dtgv_KH.Columns[2].Name = "Giới Tính";
            dtgv_KH.Columns[3].Name = "Địa Chỉ";
            dtgv_KH.Columns[4].Name = "Điểm tích lũy";
            dtgv_KH.Rows.Clear();
            foreach (var item in _QLkhachHangServices.GetkhachHangFromDB())
            {
                dtgv_KH.Rows.Add(item.SDT_KH, item.TenKH, item.gioiTinh == true ? "Nam" : "Nữ", item.diaChi, item.diem);
            }
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            khachHang accKH = _QLkhachHangServices.GetkhachHangFromDB().FirstOrDefault
              (p => p.SDT_KH == tbt_SDT.Text);
            if (tbt_SDT.Text.Trim() == "" || tbt_TenKH.Text.Trim() == "" || tbt_SDT.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            else if (accKH != null)
            {
                MessageBox.Show("Số điện thoại khách hàng đã tồn tại");
                tbt_SDT.Text = "";
            }
            else if (ValidateInput.CheckSDT(tbt_SDT.Text) == false)
            {
                MessageBox.Show("Bạn phải nhập đúng SĐT");
            }
            else
            {
                khachHang addKH = new khachHang()
                {
                    SDT_KH = tbt_SDT.Text,
                    TenKH = tbt_TenKH.Text,
                    diaChi = tbt_DiaChi.Text,
                    gioiTinh = rb_nam.Checked == true ? true : false,
                    diem = 0,
                };
                _QLkhachHangServices.addkhachHang(addKH);
                MessageBox.Show("Thêm khách hàng thành công");
                loaddata();
            }
        }

        private void dtgv_KH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            tbt_TenKH.Clear();
            rb_nam.Checked = true;
            tbt_SDT.Clear();
            tbt_DiaChi.Clear();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var update = _QLkhachHangServices.GetkhachHangFromDB().FirstOrDefault(p => p.SDT_KH == tbt_SDT.Text);
            if (tbt_SDT.Text.Trim() == "" || tbt_TenKH.Text.Trim() == "" || tbt_SDT.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            else if (update == null)
            {
                MessageBox.Show("Số điện thoại khách hàng không tồn tại");
                tbt_SDT.Text = "";
            }
            else
            {
                update.TenKH = tbt_TenKH.Text;
                update.SDT_KH = tbt_SDT.Text;
                update.diaChi = tbt_DiaChi.Text;
                update.gioiTinh = rb_nam.Checked == true ? true : false;
                _QLkhachHangServices.UpdateKhachHang(update);
                MessageBox.Show("sửa thành công");
                loaddata();
            }
        }

        private void tbt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            dtgv_KH.ColumnCount = 5;
            dtgv_KH.Columns[0].Name = "Số Điện Thoại";
            dtgv_KH.Columns[1].Name = "Tên Khách Hàng";
            dtgv_KH.Columns[2].Name = "Giới Tính";
            dtgv_KH.Columns[3].Name = "Địa Chỉ";
            dtgv_KH.Columns[4].Name = "Điểm tích lũy";
            dtgv_KH.Rows.Clear();
            foreach (var item in _QLkhachHangServices.GetkhachHangFromDB().Where(x => x.TenKH.ToLower().Contains(tbt_TimKiem.Text.ToLower()) || x.SDT_KH.Contains(tbt_TimKiem.Text)))
            {
                dtgv_KH.Rows.Add(item.SDT_KH, item.TenKH, item.gioiTinh == true ? "Nam" : "Nữ", item.diaChi, item.diem);
            }
        }

        private void dtgv_KH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtgv_KH.Rows[e.RowIndex];
            tbt_SDT.Text = row.Cells[0].Value.ToString();
            tbt_TenKH.Text = row.Cells[1].Value.ToString();
            rb_nam.Checked = row.Cells[2].Value.ToString() == "Nam" ? true : false;
            rb_Nu.Checked = row.Cells[2].Value.ToString() == "Nữ" ? true : false;
            tbt_DiaChi.Text = row.Cells[3].Value.ToString();
        }
    }
}
