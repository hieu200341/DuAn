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
    public partial class FrmMenu : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public FrmMenu()
        {
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
        public void FrmNV()
        {
            btn_nhanvien.Enabled = false;
            btn_thongke.Enabled = false;
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

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View.FrmNV(), sender);
            lb_home.Text = btn_nhanvien.Text;
        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View.FrmThongKe(), sender);
            lb_home.Text = btn_thongke.Text;
        }

       

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btn_closechildform_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("bạn có muốn đăng xuất không?", "Cảnh báo!",MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn đã hủy đăng xuất");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new View.FromSanPham.FrmSanPhamChiTiet(), sender);
            //lb_home.Text = btn_hoadon.Text;
            submenu.Visible = true;
        }

        private void btn_sanpham_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new View.FrmThongKe(), sender);
            lb_home.Text = btn_thongke.Text;
        }

        private void btn_sp_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View.FromSanPham.FrmSanPhamChiTiet(), sender);
            lb_home.Text = btn_sp.Text;
            submenu.Visible = false;
        }

        private void btn_size_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View.FromSanPham.FrmSize(), sender);
            lb_home.Text = btn_size.Text;
            submenu.Visible=false;
        }

        private void btn_nsx_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View.FrmNhaSX(), sender);
            lb_home.Text = btn_nsx.Text;
            submenu.Visible = false;
        }

        private void btn_ms_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View.FromSanPham.FrmMauSac(), sender);
            lb_home.Text = btn_ms.Text;
            submenu.Visible = false;
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View.FrmThongKe(), sender);
            lb_home.Text = btn_ms.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            submenu.Visible = true;
        }

        private void btn_sp_Click_1(object sender, EventArgs e)
        {

            OpenChildForm(new View.FromSanPham.FrmSanPhamChiTiet(), sender);
            lb_home.Text = btn_sp.Text;
            submenu.Visible = false;
        }

        private void submenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_size_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new View.FromSanPham.FrmSize(), sender);
            lb_home.Text = btn_size.Text;
            submenu.Visible = false;
        }

        private void btn_nsx_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new View.FrmNhaSX(), sender);
            lb_home.Text = btn_nsx.Text;
            submenu.Visible = false;
        }

        private void btn_ms_Click_1(object sender, EventArgs e)
        {

            OpenChildForm(new View.FromSanPham.FrmMauSac(), sender);
            lb_home.Text = btn_ms.Text;
            submenu.Visible = false;
        }
    }
}
