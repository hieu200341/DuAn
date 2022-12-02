using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModel;
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
    public partial class FrmNV : Form
    {
        private IQLnhanVienServices _IqLnhanVienServices;
        private IQLchucVuServices _IQLchucVuServices;
        public nhanVien _NhanVien;
        private int _maclick;
        private List<ViewHienThi> lstNv;
        public FrmNV()
        {
            _IqLnhanVienServices = new QLnhanVienServices();
            _IQLchucVuServices = new QLchucVuServices();
            InitializeComponent();
            rd_hd.Checked = false;
            loadcbb();
            lstNv = new List<ViewHienThi>();
        }
        public void loadDuLieu()
        {
            dtg_show.Rows.Clear();
            dtg_show.ColumnCount = 8;
            dtg_show.Columns[0].Name = "Mã nhân viên";
            dtg_show.Columns[1].Name = "Tên nhân viên";
            dtg_show.Columns[2].Name = "Địa chỉ";
            dtg_show.Columns[3].Name = "Số điện thoại";
            dtg_show.Columns[4].Name = "Email";
            dtg_show.Columns[5].Name = "Mật khẩu";
            dtg_show.Columns[6].Name = "Tình trạng";
            dtg_show.Columns[7].Name = "Chức vụ";
            if (tb_timkiem.Text != "")
            {
                
            }
            foreach (var item in _IqLnhanVienServices.GetNhanVienFromDB())
            {
                dtg_show.Rows.Add(item.nhanViens.maNhanVien, item.nhanViens.TenNV, item.nhanViens.diaChi, item.nhanViens.SDT, item.nhanViens.email, item.nhanViens.matKhau, item.nhanViens.tinhTrang == true ? "Hoạt động" : "Không hoạt động", item.nhanViens.maChucVu);
            }
            ////foreach (var item in _IqLnhanVienServices.getViewNhanVien())
            //{
            //    dtg_show.Rows.Add(item.nhanViens.maNhanVien, item.nhanViens.TenNV, item.nhanViens.diaChi, item.nhanViens.SDT, item.nhanViens.email, item.nhanViens.matKhau, item.nhanViens.tinhTrang == true ? "Hoạt động" : "Không hoạt động", item.nhanViens.maChucVu);
            //}
            //foreach (var item in _IqLnhanVienServices.GetNhanVienFromDB())
            //{
            //    dtg_show.Rows.Add(item.nhanViens.maChucVu, item.nhanViens.TenNV, item.nhanViens.diaChi, item.nhanViens.SDT, item.nhanViens.email, item.nhanViens.matKhau, item.nhanViens.tinhTrang == true ? "Hoạt động" : "Không hoạt động", item.nhanViens.maChucVu);
            //}
        }
        //public string trangthai1(int manv)
        //{
        //    var m = _IqLnhanVienServices.GetNhanVienFromDB().Find(p => p.nhanViens.maNhanVien == manv).nhanViens.chucVu;
        //    return m;
        //}
        public void loadcbb()
        {
            var cv = _IQLchucVuServices.GetchucVuFromDB();
            foreach (var item in cv)
            {
                cbb_cv.Items.Add(item.tenCV);
            }
            cbb_cv.SelectedIndex = 0;
        }
        private ViewHienThi1 GetData()
        {
            ViewHienThi1 nhan = new ViewHienThi1();
            nhan.nhanViens = new nhanVien();
            {
                nhan.nhanViens.maNhanVien = _maclick;
                nhan.nhanViens.TenNV = tb_ten.Text;
                nhan.nhanViens.SDT = tb_sdt.Text;
                nhan.nhanViens.email = tb_email.Text;
                nhan.nhanViens.maChucVu = _IQLchucVuServices.GetchucVuFromDB()[cbb_cv.SelectedIndex].maChucVu;
                nhan.nhanViens.diaChi = tb_diachi.Text;
                nhan.nhanViens.matKhau = tb_matkhau.Text;
                nhan.nhanViens.tinhTrang = rd_hd.Checked;

            }
            return nhan;
        }
        //private ViewHienThi update()
        //{
        //    ViewHienThi1 nhan = new ViewHienThi1();
        //    nhan.nhanViens = new nhanVien();
        //    {
        //        nhan.nhanViens.maNhanVien = Convert.ToInt32(tb_manv.Text);
        //        nhan.nhanViens.TenNV = tb_ten.Text;
        //        nhan.nhanViens.SDT = tb_sdt.Text;
        //        nhan.nhanViens.email = tb_email.Text;
        //        nhan.nhanViens.maChucVu = _IQLchucVuServices.GetchucVuFromDB()[cbb_cv.SelectedIndex - 1].maChucVu;
        //        nhan.nhanViens.diaChi = tb_diachi.Text;
        //        nhan.nhanViens.matKhau = tb_matkhau.Text;
        //        nhan.nhanViens.tinhTrang = rd_hd.Checked;

        //    }
        //    return nhan;
        //}
        private void button1_Click(object sender, EventArgs e)
        {
            //nhanVien nhanvien = _IqLnhanVienServices.GetNhanVienFromDB().FirstOrDefault(p => p.TenNV == tb_ten.Text);
            double s1;
            bool checksdt = double.TryParse(tb_sdt.Text, out s1);
            DialogResult dialogResult = MessageBox.Show("bạn có muốn thêm không ?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (tb_ten.Text == "" || tb_sdt.Text == "" || tb_email.Text == "" || tb_diachi.Text == "")
            {
                MessageBox.Show("vui lòng nhập đầy đủ thông tin");
            }
            else if (ValidateInput.CheckSDT(tb_sdt.Text) == false)
            {
                MessageBox.Show("Bạn phải nhập đúng số điện thoại");
            }
            else if (_IqLnhanVienServices.GetNhanVienFromDB().Any(p => p.nhanViens.SDT == tb_sdt.Text))
            {
                MessageBox.Show("SĐT này đã bị trùng");
            }

            else if (dialogResult == DialogResult.Yes)
            {

                //nhanVien nhan = new nhanVien();
                //{
                //    nhan.TenNV = tb_ten.Text;
                //    nhan.SDT = tb_sdt.Text;
                //    nhan.email = tb_email.Text;
                //    nhan.maChucVu = _IQLchucVuServices.GetchucVuFromDB()[cbb_cv.SelectedIndex].maChucVu;
                //    nhan.diaChi = tb_diachi.Text;
                //    nhan.matKhau = tb_matkhau.Text;
                //    nhan.tinhTrang = rd_hd.Checked;

                //}
                MessageBox.Show(_IqLnhanVienServices.addNhanVien(GetData()));
                loadDuLieu();
            }
            else
            {
                MessageBox.Show("bạn đã hủy thêm");
            }
        }
        //public void Trangthai()
        //{
        //    if(rd_hd.Checked == true)
        //    {
                
        //    }
        //}
        private void btn_xoahoadon_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("bạn có muốn xóa không ? ", "cảnh báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var x = GetData();
                x.nhanViens.maNhanVien = _maclick;
                MessageBox.Show(_IqLnhanVienServices.RemoveNhanVien(x));
                loadDuLieu();
            }
            else
            {
                MessageBox.Show("bạn đã hủy xóa");
            }
        }

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _maclick = Convert.ToInt32(dtg_show.CurrentRow.Cells[0].Value.ToString());
            //tb_manv.Text = dtg_show.CurrentRow.Cells[0].Value.ToString();
            tb_ten.Text = dtg_show.CurrentRow.Cells[1].Value.ToString();
            tb_diachi.Text = dtg_show.CurrentRow.Cells[2].Value.ToString();
            tb_sdt.Text = dtg_show.CurrentRow.Cells[3].Value.ToString();
            tb_email.Text = dtg_show.CurrentRow.Cells[4].Value.ToString();
            tb_matkhau.Text = dtg_show.CurrentRow.Cells[5].Value.ToString();
            //if(dtg_show.CurrentRow.Cells[6].Value.ToString() == "Hoạt dộng")
            //{
               
            //}
            rd_hd.Checked = dtg_show.CurrentRow.Cells[6].Value.ToString() == "Hoạt động" ? true : false;
            rd_khd.Checked = dtg_show.CurrentRow.Cells[6].Value.ToString() == "Không hoạt động" ? true : false;
            cbb_cv.Text = dtg_show.CurrentRow.Cells[7].Value.ToString();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("bạn có muốn sửa không ? ", "cảnh báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var x = GetData();
                x.nhanViens.maNhanVien = _maclick;
                MessageBox.Show(_IqLnhanVienServices.UpdateNhanVien(x));
                loadDuLieu();
            }
            else
            {
                MessageBox.Show("bạn đã hủy xóa");
            }
                //    nhanVien nhan = new nhanVien();
                //    {
                //        nhan.maChucVu = _manv;
                //        nhan.TenNV = tb_ten.Text;
                //        nhan.SDT = tb_sdt.Text;
                //        nhan.email = tb_email.Text;
                //        nhan.maChucVu = _IQLchucVuServices.GetchucVuFromDB()[cbb_cv.SelectedIndex].maChucVu;
                //        nhan.diaChi = tb_diachi.Text;
                //        nhan.matKhau = tb_matkhau.Text;
                //        nhan.tinhTrang = rd_hd.Checked;

                //    }

                //}
                //if (_NhanVien == null)
                //{
                //    MessageBox.Show("Vui lòng chọn chức vụ");
                //}
                //else
                //{
                //if (_NhanVien.TenNV == tb_ten.Text || (_NhanVien.TenNV != tb_ten.Text && _IqLnhanVienServices.GetNhanVienFromDB().FirstOrDefault(x => x.TenNV == tb_ten.Text) == null))
                //{
                //    _NhanVien.TenNV = tb_ten.Text;
                //    _NhanVien.SDT = tb_sdt.Text;
                //    _NhanVien.email = tb_email.Text;
                //    _NhanVien.diaChi = tb_diachi.Text;
                //    _NhanVien.tinhTrang = rd_hd.Checked;
                //    _NhanVien.maChucVu = Convert.ToInt32(cbb_cv.Text);
                //    _IqLnhanVienServices.UpdateNhanVien(_NhanVien);
                //    MessageBox.Show("Sửa thành công");
                //    loadDuLieu();
                //    tb_ten.Text = "";
                //}
                //else
                //{
                //    MessageBox.Show("sửa thất bại");
                //}

            }

        private void FrmNV_Load(object sender, EventArgs e)
        {
            loadDuLieu();
        }
    }
    }


