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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.GUI.View
{
    public partial class FrmNhaSX : Form
    {
        private IQLhangSXServices _QLhangSXServices;
        private hangSX _hangSX;
        public FrmNhaSX()
        {
            _QLhangSXServices = new QLhangSXServices();
            _hangSX= new hangSX();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
