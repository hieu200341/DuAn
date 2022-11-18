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
    }
}
