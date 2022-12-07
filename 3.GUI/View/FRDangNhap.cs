using System;
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
namespace _3.GUI.View
{
    public partial class FRDangNhap : Form
    {
        IQLnhanVienServices _sv;
        public FRDangNhap()
        {
            _sv = new QLnhanVienServices();
            InitializeComponent();
        }

        public void Check()
        {
            var Acc = _sv.GetNhanVienFromDB().ToList();

            if (tb_user.Text == "" || tb_pass.Text == "")
            {
                MessageBox.Show("Vui lòng điền tài khoản mật khẩu");
            }
            else
            {
                for (int i = 0; i < Acc.Count; i++)
                {
                    if (tb_user.Text == Acc[i].nhanViens.email && tb_pass.Text == Acc[i].nhanViens.matKhau && Acc[i].nhanViens.IDChucVu == 1)
                    {
                        MessageBox.Show("Đăng nhập với tư cách quản lí");
                        
                        FrmMenu f = new FrmMenu();
                        f.ShowDialog();                        
                        return;
                    }
                    else if(tb_user.Text == Acc[i].nhanViens.email && tb_pass.Text == Acc[i].nhanViens.matKhau && Acc[i].nhanViens.IDChucVu == 2)
                    {
                        MessageBox.Show("Đăng nhập với tư cách nhân viên");
                        Menu1 f1 = new Menu1();                       
                        f1.ShowDialog();
                        return;
                    }                                                               
                }
                MessageBox.Show("Tài khoản hoặc mật khẩu chưa chính xác");
            }                        
        }
        private void button1_Click(object sender, EventArgs e)
        {            
            Check();            
        }

        private void label1_Click(object sender, EventArgs e)
        {           
            
        }
        private void FRDangNhap_Load(object sender, EventArgs e)
        {
            tb_user.Text = Properties.Settings.Default.tk;
            tb_pass.Text = Properties.Settings.Default.mk;
            if(Properties.Settings.Default.tk != "")
            {
                checkBox1.Checked = true;
            }           
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            FrmQuenMk frmQuenMk = new FrmQuenMk();
            frmQuenMk.ShowDialog();            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (tb_user.Text != "" || tb_pass.Text != "")
            {
                if(checkBox1.Checked == true)
                {
                    string user = tb_user.Text;
                    string pass = tb_pass.Text;
                    Properties.Settings.Default.tk = user;
                    Properties.Settings.Default.mk = pass;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Reset();
                }
            }
        }
    }
}
