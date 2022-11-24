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
    public partial class FrmSize : Form
    {
        private IQLsizeServices _QLsizeServices;
        private size _size;
        public FrmSize()
        {
            _QLsizeServices = new QLsizeServices();
            _size = new size();
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            dtgv_Size.Rows.Clear();
            foreach (var item in _QLsizeServices.GetSizeFromDB())
            {
                dtgv_Size.Rows.Add(item.IdSize, item.maSize, item.SiZe,
                    item.trangThai == true ? "Còn hàng" : "Hết hàng");
            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {

            size accSize = _QLsizeServices.GetSizeFromDB().FirstOrDefault
              (p => p.maSize == tbt_maSize.Text);
            if (tbt_maSize.Text == "" || tbt_TenSize.Text == "")
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            else if (accSize != null)
            {
                MessageBox.Show("Mã Size đã tồn tại");
                tbt_maSize.Text = "";
            }
            else
            {
                size addsize = new size()
                {
                    IdSize = Guid.NewGuid(),
                    maSize = tbt_maSize.Text,
                    SiZe = tbt_TenSize.Text,
                    trangThai = rb_HoatDong.Checked,
                };
                _QLsizeServices.addsize(addsize);
                MessageBox.Show("Thêm Size thành công");
                loadData();
            }
        }

        private void btb_CapNhat_Click(object sender, EventArgs e)
        {
            var updateSize = _QLsizeServices.GetSizeFromDB().FirstOrDefault(p => p.maSize == tbt_maSize.Text);
            if (updateSize != null)
            {
                updateSize.SiZe = tbt_TenSize.Text;
                updateSize.trangThai = rb_HoatDong.Checked;
                _QLsizeServices.UpdateSize(updateSize);
                MessageBox.Show("Cập nhật Size thành công");
                loadData();
            }
            else
            {
                MessageBox.Show("Bạn nhập sai mã ");
            }
        }

        private void dtgv_Size_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtgv_Size.Rows[e.RowIndex];
            tbt_maSize.Text = row.Cells[1].Value.ToString();
            tbt_TenSize.Text = row.Cells[2].Value.ToString();
            rb_HoatDong.Checked = row.Cells[3].Value.ToString() == "Còn hàng" ? true : false;
            rb_KHD.Checked = row.Cells[3].Value.ToString() == "Hết hàng" ? true : false;
        }
    }
}
