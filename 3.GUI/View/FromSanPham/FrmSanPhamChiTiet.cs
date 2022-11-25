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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.GUI.View.FromSanPham
{
    public partial class FrmSanPhamChiTiet : Form
    {
        IQLhangSXServices _QLhangServices;
        IQLmauSacServices _qLmauSacServices;
        IQLsizeServices _qLsizeServices;
        IQLsanPhamServices _qLsanPhamServices;
        public SanPham _sanPham;
        public string Avatar = "";
        public FrmSanPhamChiTiet()
        {
            _qLsizeServices = new QLsizeServices();
            _qLmauSacServices = new QLmauSacServices();
            _QLhangServices = new QLhangSXServices();
            _qLsanPhamServices = new QLsanPhamServices();
            _sanPham = new SanPham();
            InitializeComponent();
            rb_con.Checked = true;
            LoadNhaSanXuat();
            LoadMauSac();
            LoadSize();
            loadDuLieu();
        }
        public void LoadNhaSanXuat()
        {
            var nsx = _QLhangServices.GetHangSXFromDB();
            foreach (var item in nsx)
            {
                cb_NSX.Items.Add(item.maHangSX);
            }
        }
        public void LoadMauSac()
        {
            var mau = _qLmauSacServices.GetMauSacFromDB();
            foreach (var item in mau)
            {
                cb_Mau.Items.Add(item.maMauSac);
            }
        }
        public void LoadSize()
        {
            var size = _qLsizeServices.GetSizeFromDB();
            foreach (var item in size)
            {
                cb_size.Items.Add(item.maSize);
            }
        }
        public void loadDuLieu()
        {
            dtgv_sanPham.Rows.Clear();
            var data = (from a in _qLsanPhamServices.GetSanPhamFromDB()
                        join b in _qLmauSacServices.GetMauSacFromDB() on a.maSanPham equals b.maMauSac
                        join c in _qLsizeServices.GetSizeFromDB() on a.maSanPham equals c.maSize
                        join d in _QLhangServices.GetHangSXFromDB() on a.maSanPham equals d.maHangSX
                        select new SanPham
                        {
                            IdSanPham = a.IdSanPham,
                            maSanPham = a.maSanPham,
                            TenSP = a.TenSP,
                            Gianhap = a.Gianhap,
                            Giaban = a.Giaban,
                            Soluong = a.Soluong,
                            maMauSac = b.tenMau,
                            maSize = c.SiZe,
                            maHangSX = d.tenHangSX,
                            Trangthai = a.Trangthai
                        }).ToList();
            foreach (var item in data)
            {
                dtgv_sanPham.Rows.Add(item.IdSanPham, item.maSanPham, item.TenSP, item.Gianhap, item.Giaban, item.Soluong,item.mauSac, item.size,item.hangSX,
                    item.Trangthai == true ? "Kinh doanh" : "Ngừng kinh doanh");
            }
        }

        private void ptb_linkAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (ptb_linkAnh.Image != null)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn đổi ảnh ko?",
                    "...", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    if (op.ShowDialog() == DialogResult.OK)
                    {
                        Avatar = op.FileName;
                        ptb_linkAnh.Image = Image.FromFile(op.FileName);
                        ptb_linkAnh.SizeMode = PictureBoxSizeMode.StretchImage; // Chọn mode
                        MessageBox.Show(op.FileName);
                    }
                }
            }
            if (ptb_linkAnh.Image == null)
            {
                if (op.ShowDialog() == DialogResult.OK)
                {
                    Avatar = op.FileName;
                    ptb_linkAnh.Image = Image.FromFile(op.FileName);
                    ptb_linkAnh.SizeMode = PictureBoxSizeMode.CenterImage;
                    MessageBox.Show(op.FileName);
                }
            }
        }
        private bool checkValidate()
        {
            if (tbt_ma.Text == "" || tbt_ten.Text == "" || tbt_giaNhap.Text == "" 
                || tbt_giaBan.Text == "" || tbt_soLuong.Text == "" || cb_Mau.Text =="" 
                || cb_size.Text == ""|| cb_NSX.Text =="") return false;
            return true;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            SanPham accsp = _qLsanPhamServices.GetSanPhamFromDB().FirstOrDefault
            (p => p.maSanPham == tbt_ma.Text);
            SanPham tsp = _qLsanPhamServices.GetSanPhamFromDB().FirstOrDefault
            (p => p.TenSP == tbt_ten.Text);
            string number = tbt_giaBan.Text;
            number = tbt_giaNhap.Text;
            number = tbt_soLuong.Text;
            Regex regex = new Regex(@"^[-+]?[0-9]*.?[0-9]+$");
            Match match = regex.Match(number);
            if (!match.Success)
            {
                MessageBox.Show("Số lượng, đơn giá nhập hoặc đơn giá bán không hợp lệ");
            }
            else if (accsp != null)
            {
                MessageBox.Show("Mã hàng đã tồn tại");
                tbt_ma.Text = "";
            }
            else if (tsp != null)
            {
                MessageBox.Show("Tên sản phẩm đã tồn tại");
                tbt_ten.Text = "";
            }
            else if (checkValidate() == false)
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            else if (Convert.ToDecimal(tbt_giaNhap.Text) > Convert.ToDecimal(tbt_giaBan.Text))
            {
                MessageBox.Show("Giá bán phải cao hơn giá nhập");
            }
            else if (Avatar == "")
            {
                MessageBox.Show("Bạn chưa thêm ảnh cho sản phẩm");
            }
            else
            {
                SanPham sp = new SanPham()
                {
                    IdSanPham = Guid.NewGuid(),
                    maSanPham = tbt_ma.Text,
                    TenSP = tbt_ten.Text,
                    Gianhap = Convert.ToDecimal(tbt_giaNhap.Text),
                    Giaban = Convert.ToDecimal(tbt_giaBan.Text),
                    Soluong = Convert.ToInt32(tbt_soLuong.Text),
                    maMauSac = Convert.ToString(cb_Mau.SelectedIndex + 1),
                    maSize = Convert.ToString(cb_size.SelectedIndex + 1),
                    maHangSX = Convert.ToString(cb_NSX.SelectedIndex + 1),
                    Trangthai = rb_con.Checked,
                    linkAnh = Avatar
                };
                _qLsanPhamServices.addsanPham(sp);
                MessageBox.Show("Thêm sản phẩm thành công");
                loadDuLieu();

            }
        }
    }
}
