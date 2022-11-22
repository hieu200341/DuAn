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
    public partial class FrmDangKy : Form
    {
        public FrmDangKy()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            FRDangNhap fRDangNhap = new FRDangNhap();
            fRDangNhap.ShowDialog();
        }

        private void tb_user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
