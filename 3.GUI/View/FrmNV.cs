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
            InitializeComponent();
            _IqLnhanVienServices = new QLnhanVienServices();
            _IQLchucVuServices = new QLchucVuServices();
            rd_hd.Checked = false;
            loadcbb();
        }
        public void load()
        {
            dtg_show.Rows.Clear();
            var data = (from a in _IqLnhanVienServices.GetNhanVienFromDB()
                        join b in _IQLchucVuServices.GetchucVuFromDB() on a.maNhanVien equals b.maChucVu
                        select new nhanVien
                        {
                            maNhanVien = a.maChucVu,
                            maChucVu = b.maChucVu,
                        }).ToList();
            //dtg_show.Rows.Clear();
            //dtg_show.ColumnCount = 7;
            //dtg_show.Columns[0].Name = "Mã nhân viên";
            //dtg_show.Columns[1].Name = "Tên nhân viên";
            //dtg_show.Columns[2].Name = "Địa chỉ";
            //dtg_show.Columns[3].Name = "SĐT";
            //dtg_show.Columns[4].Name = "Email";
            //dtg_show.Columns[5].Name = "Mật khẩu";
            //dtg_show.Columns[6].Name = "Trạng thái";
            //dtg_show.Columns[7].Name = "Chức vụ";
            foreach (var item in data)
            {
                dtg_show.Rows.Add(item.maNhanVien, item.TenNV, item.diaChi, item.SDT, item.email,item.matKhau, item.tinhTrang== true? "Hoạt động" : "Không hoạt động" , item.chucVu);
            }
        }
        public void loadcbb()
        {
            cbb_cv.Items.Clear();
            cbb_cv.Items.Add("");
            var cv = _IQLchucVuServices.GetchucVuFromDB();
            foreach (var item in cv)
            {
                cbb_cv.Items.Add(item.tenCV);
            }
            cbb_cv.SelectedIndex = 0;
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            nhanVien nhanvien = _IqLnhanVienServices.GetNhanVienFromDB().FirstOrDefault(p => p.maNhanVien == tb_manv.Text);
            DialogResult dialogResult = MessageBox.Show("bạn có muốn thêm không ?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (tb_manv.Text == "" || tb_ten.Text == "" || tb_sdt.Text == "" || tb_email.Text == "" || tb_diachi.Text == "")
            {
                MessageBox.Show("vui lòng nhập đầy đủ thông tin");
            }
            else if (nhanvien != null)
            {   
                MessageBox.Show("Mã nhân viên đã tồn tại");
                tb_manv.Text = "";
            }
            else if (dialogResult == DialogResult.Yes)
            {

                nhanVien nhan = new nhanVien();
                {
                    nhan.maNhanVien = tb_manv.Text;
                    nhan.TenNV = tb_ten.Text;
                    nhan.SDT = tb_sdt.Text;
                    nhan.email = tb_email.Text;
                    nhan.maChucVu = _IQLchucVuServices.GetchucVuFromDB()[cbb_cv.SelectedIndex - 1].maChucVu;
                    nhan.diaChi = tb_diachi.Text;
                    nhan.matKhau = tb_matkhau.Text;
                    nhan.tinhTrang = rd_hd.Checked;

                }
                _IqLnhanVienServices.addNhanVien(nhan);
                MessageBox.Show("Thêm thành công");
                load();
            }
            else
            {
                MessageBox.Show("bạn đã hủy thêm");
            }
        }
    }
}
