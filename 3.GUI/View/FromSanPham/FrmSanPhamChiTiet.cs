using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.Services;
using AForge.Video.DirectShow;
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
            //loadDuLieu();
            //loadDate();
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
                cb_NSX.Items.Add(item.tenHangSX);
            }
            cb_NSX.SelectedIndex = 0;
        }
        public void LoadMauSac()
        {
            var mau = _qLmauSacServices.GetMauSacFromDB();
            foreach (var item in mau)
            {
                cb_Mau.Items.Add(item.tenMau);
            }
            cb_Mau.SelectedIndex = 0;
        }
        public void LoadSize()
        {
            //cb_size.Items.Clear();
            //cb_size.Items.Add("..");
            var size = _qLsizeServices.GetSizeFromDB();
            foreach (var item in size)
            {
                cb_size.Items.Add(item.SiZe);
            }
            cb_size.SelectedIndex = 0;
        }
        public void loadDuLieu()
        {
            dtgv_sanPham.Rows.Clear();
            foreach (var item in _qLsanPhamServices.getViewSanPham())
            {
                dtgv_sanPham.Rows.Add(item.SanPhams.IDSanPham,item.SanPhams.maSP, item.SanPhams.TenSP, item.SanPhams.Gianhap, item.SanPhams.Giaban, item.SanPhams.Soluong,item.mauSacs.tenMau, item.sizes.SiZe,item.hangSXs.tenHangSX,
                    item.SanPhams.Trangthai == true ? "Còn hàng" : "Hết hàng");
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
            if ( tbt_ten.Text == "" || tbt_giaNhap.Text == "" 
                || tbt_giaBan.Text == "" || tbt_soLuong.Text == "" || cb_Mau.Text =="" 
                || cb_size.Text == ""|| cb_NSX.Text =="") return false;
            return true;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
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
                    maSP = tbt_maSP.Text,
                    TenSP = tbt_ten.Text,
                    Gianhap = float.Parse(tbt_giaNhap.Text),
                    Giaban = float.Parse(tbt_giaBan.Text),
                    Soluong = Convert.ToInt32(tbt_soLuong.Text),
                    IDMauSac = _qLmauSacServices.GetMauSacFromDB()[cb_Mau.SelectedIndex].IDMauSac,
                    IDSize = _qLsizeServices.GetSizeFromDB()[cb_size.SelectedIndex].IDSize,
                    IDHangSX = _QLhangServices.GetHangSXFromDB()[cb_NSX.SelectedIndex].IDHangSX,
                    Trangthai = rb_con.Checked,
                    linkAnh = Avatar
                };
                
                _qLsanPhamServices.addsanPham(sp);
                MessageBox.Show("Thêm sản phẩm thành công");
                //loadDate();
                loadDuLieu();

            }
        }

        private void dtgv_sanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
