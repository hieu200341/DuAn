using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.GUI.View.FromSanPham
{
    public partial class FrmMauSac : Form
    {
        private IQLmauSacServices _QLmauSacServices;
        public mauSac _mauSac;
        public FrmMauSac()
        {
            _QLmauSacServices = new QLmauSacServices();
            _mauSac = new mauSac();
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            dtgv_Mau.Rows.Clear();
            foreach (var item in _QLmauSacServices.GetMauSacFromDB())
            {
                dtgv_Mau.Rows.Add( item.IDMauSac, item.tenMau,
                    item.trangThai == true ? "Còn hàng" : "Hết hàng");
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            mauSac accMau = _QLmauSacServices.GetMauSacFromDB().FirstOrDefault
              (p => p.tenMau == tbt_TenMau.Text);
            if (tbt_TenMau.Text == "")
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            else if (accMau != null)
            {
                MessageBox.Show("Tên màu đã tồn tại");
                tbt_TenMau.Text = "";
            }
            else
            {
                mauSac addMau = new mauSac()
                {
                    tenMau = tbt_TenMau.Text,
                    trangThai = rb_HoatDong.Checked,
                };
                _QLmauSacServices.addMauSac(addMau);
                MessageBox.Show("Thêm màu sắc thành công");
                loadData();
            }
        }

        private void btb_CapNhat_Click(object sender, EventArgs e)
        {
            //var update = _QLmauSacServices.GetMauSacFromDB().FirstOrDefault(p => p.tenMau == tbt_maMau.Text);
            //if (update != null)
            //{
            //    update.tenMau = tbt_TenMau.Text;
            //    update.trangThai = rb_HoatDong.Checked;
            //    _QLmauSacServices.UpdateMauSac(update);
            //    MessageBox.Show("Cập nhật màu sắc thành công");
            //    loadData();
            //}
            //else
            //{
            //    MessageBox.Show("Bạn nhập sai mã màu sắc");
            //}
            if (_mauSac == null)
            {
                MessageBox.Show("Vui lòng chọn màu sắc");
            }
            else
            {
                if (_mauSac.tenMau == tbt_TenMau.Text || (_mauSac.tenMau != tbt_TenMau.Text && _QLmauSacServices.GetMauSacFromDB().FirstOrDefault(x => x.tenMau == tbt_TenMau.Text) == null))
                {
                    _mauSac.tenMau = tbt_TenMau.Text;
                    _mauSac.trangThai = rb_HoatDong.Checked;
                    _QLmauSacServices.UpdateMauSac(_mauSac);
                    MessageBox.Show("Cập nhật thành công");
                    loadData();
                    tbt_TenMau.Text = "";
                }
                else
                {
                    MessageBox.Show("Tên màu sắc đã tồn tại");
                }
            }
        }

        private void dtgv_Mau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv_Mau.Rows[e.RowIndex];
                _mauSac = _QLmauSacServices.GetMauSacFromDB().FirstOrDefault(x => x.IDMauSac == Convert.ToInt32(row.Cells[0].Value));
                tbt_TenMau.Text = row.Cells[1].Value.ToString();
                rb_HoatDong.Checked = row.Cells[2].Value.ToString() == "Còn hàng" ? true : false;
                rb_KHD.Checked = row.Cells[2].Value.ToString() == "Hết hàng" ? true : false;
            }
        }
    }
}
