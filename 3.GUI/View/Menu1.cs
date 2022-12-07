﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModel;
namespace _3.GUI.View
{
    public partial class Menu1 : Form
    {
        ViewHienThi1 v1 = new ViewHienThi1();
        IQLnhanVienServices _services;
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public Menu1()
        {
            _services = new QLnhanVienServices();
            InitializeComponent();
            random = new Random();
            btn_closechildform.Visible = false;
            this.Text = string.Empty;
            //this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelHome.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //ThemeColor.PrimaryColor = color;
                    //ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btn_closechildform.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelmanchinh.Controls.Add(childForm);
            this.panelmanchinh.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lb_home.Text = childForm.Text;
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View.BanHang.FrmGioHang(), sender);
            lb_home.Text = btn_buy.Text;
        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BanHang.FrmHoaDon(), sender);
            lb_home.Text = btn_hoadon.Text;
        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View.FrmKH(), sender);
            lb_home.Text = btn_khachhang.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View.FromSanPham.FrmSanPhamChiTiet(), sender);
            lb_home.Text = btn_sanpham.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("bạn có muốn đăng xuất không?", "Cảnh báo!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn đã hủy đăng xuất");
            }

        }
        private void Reset()
        {
            DisableButton();
            lb_home.Text = "HOME";
            panelHome.BackColor = Color.FromArgb(0, 0, 192);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btn_closechildform.Visible = false;
        }

        private void btn_closechildform_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void panelmanchinh_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu1_Load(object sender, EventArgs e)
        {
            //var layEmail = Properties.Settings.Default.TKdaLogin;
            //var nhanvien = _nhanVienService.GetNhanVienFromDB().FirstOrDefault(p => p.Gmail == layEmail);

            //lb_MaNv.Text = nhanvien.MaNhanVien;
            //lb_TenNv.Text = nhanvien.TenNhanVien;
            //lb_Email.Text = nhanvien.Gmail;
            //lb_DiaChi.Text = nhanvien.DiaChi;
            //lb_Sdt.Text = nhanvien.SDT;
            //lb_GioiTinh.Text = nhanvien.GioiTinh == 1 ? "Nam" : "Nữ";

            //var role = _chucVuService.GetChucVuFromDB().FirstOrDefault(x => x.IdChucVu == nhanvien.IdChucVu);
            //lb_TenDn.Text = nhanvien.TenNhanVien;
            //lb_ChucVu.Text = role.TenCV;
            //pictureBox1.Image = Image.FromFile(nhanvien.LinkAnh);
        }
        private void btn_DoiMk_Click(object sender, EventArgs e)
        {
            var taikhoan = _services.GetNhanVienFromDB().FirstOrDefault(c => c.nhanViens.email == tbt_email.Text);
            var newpass = tbt_MkMoi.Text;
            var repass = tbt_XacNhanMK.Text;

            if (tbt_Mk.Text ==""|| tbt_MkMoi.Text==""|| tbt_XacNhanMK.Text == ""||tbt_email.Text=="")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }
            else
            {
                if (taikhoan != null && tbt_Mk.Text == taikhoan.nhanViens.matKhau && newpass == repass)
                {
                    taikhoan.nhanViens.matKhau = newpass;
                    _services.UpdateNhanVien(taikhoan);
                    MessageBox.Show("Đổi mật khẩu thành công, vui lòng đăng nhập lại");
                    Application.Restart();
                    Environment.Exit(0);
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin nhập");
                    
                }
                
            }
        }
    }
}
