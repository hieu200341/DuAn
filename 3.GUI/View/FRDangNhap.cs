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
    public partial class FRDangNhap : Form
    {
        public FRDangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();
            frm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tb_user_TextChanged(object sender, EventArgs e)
        {
            tb_user.Clear();
        }

        private void FRDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            FrmDangKy frmDangKy = new FrmDangKy();  
            frmDangKy.ShowDialog();
        }
        private void tb_user_Enter(object sender, EventArgs e)
        {
            if (tb_user.Text == "UserName")
            {
                tb_user.Text = "";

            }
        }
        private void tb_user_Leave(object sender, EventArgs e)
        {
            if (tb_user.Text == "")
            {
                tb_user.Text = "UserName";
               
            }
        }

       

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if(tb_pass.Text == "Password")
            {
                tb_pass.Text = "";
               
                tb_pass.UseSystemPasswordChar = true;
            }
        }

        private void FRDangNhap_Leave(object sender, EventArgs e)
        {
            if (tb_pass.Text == "")
            {
                tb_pass.Text = "Password";
                
                tb_pass.UseSystemPasswordChar = false;
            }
        }

        private void tb_user_Enter_1(object sender, EventArgs e)
        {
            if(tb_user.Text== "Username")
            {
                tb_user.Text = "";
            }
        }

        private void tb_user_Leave_1(object sender, EventArgs e)
        {
            if(tb_user.Text == "")
            {
                tb_user.Text = "Username";
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

        private void tb_pass_Leave(object sender, EventArgs e)
        {
            if(tb_pass.Text == "")
            {
                tb_pass.Text="Password";
            }
        }
    }
}
