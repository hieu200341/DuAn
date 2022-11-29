using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModel;
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
    public partial class FrmNV : Form
    {
        private IQLnhanVienServices _IqLnhanVienServices;
        private IQLchucVuServices _IQLchucVuServices;
        public FrmNV()
        {
            _IqLnhanVienServices = new QLnhanVienServices();
            _IQLchucVuServices = new QLchucVuServices();
            InitializeComponent();
            rd_hd.Checked = false;
            loadcbb();
            loadDuLieu();
        }
        public void loadDuLieu()
        {
            dtg_show.Rows.Clear();
            foreach (var item in _IqLnhanVienServices.getViewNhanVien())
            {
                dtg_show.Rows.Add(item.nhanViens.maNhanVien, item.nhanViens.TenNV, item.nhanViens.diaChi, item.nhanViens.SDT, item.nhanViens.email, item.nhanViens.matKhau, item.nhanViens.tinhTrang == true ? "Hoạt động" : "Không hoạt động", item.nhanViens.maChucVu);
            }
            //foreach (var item in _IqLnhanVienServices.GetNhanVienFromDB())
            //{
            //    dtg_show.Rows.Add(item.maNhanVien, item.TenNV, item.diaChi, item.SDT, item.email, item.matKhau, item.tinhTrang == true ? "Hoạt động" : "Không hoạt động", item.maChucVu);
            //}
        }
        public void loadcbb()
        {
            var cv = _IQLchucVuServices.GetchucVuFromDB();
            foreach (var item in cv)
            {
                cbb_cv.Items.Add(item.tenCV);
            }
            cbb_cv.SelectedIndex = 0;
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            //nhanVien nhanvien = _IqLnhanVienServices.GetNhanVienFromDB().FirstOrDefault(p => p.TenNV == tb_ten.Text);
            DialogResult dialogResult = MessageBox.Show("bạn có muốn thêm không ?", "Cảnh báo", MessageBoxButtons.YesNo);
            if ( tb_ten.Text == "" || tb_sdt.Text == "" || tb_email.Text == "" || tb_diachi.Text == "")
            {
                MessageBox.Show("vui lòng nhập đầy đủ thông tin");
            }
            //else if (nhanvien != null)
            //{   
            //    MessageBox.Show("Mã nhân viên đã tồn tại");
            //    tb_manv.Text = "";
            //}
            else if (dialogResult == DialogResult.Yes)
            {

                nhanVien nhan = new nhanVien();
                {
                    nhan.TenNV = tb_ten.Text;
                    nhan.SDT = tb_sdt.Text;
                    nhan.email = tb_email.Text;
                    nhan.maChucVu = _IQLchucVuServices.GetchucVuFromDB()[cbb_cv.SelectedIndex].maChucVu;
                    nhan.diaChi = tb_diachi.Text;
                    nhan.matKhau = tb_matkhau.Text;
                    nhan.tinhTrang = rd_hd.Checked;

                }
                _IqLnhanVienServices.addNhanVien(nhan);
                MessageBox.Show("Thêm thành công");
                loadDuLieu();
            }
            else
            {
                MessageBox.Show("bạn đã hủy thêm");
            }
        }
    }
}
