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
using _2.BUS.ViewModel;
using _1.DAL.Models;

namespace _3.GUI.View.BanHang
{
    public partial class FrmHoaDon : Form
    {
        IQLhoaDonServices _HDservices;
        IQLnhanVienServices _NVservices;
        IQLkhachHangServices _KHservices;
        int _maHD;
        public FrmHoaDon()
        {
            InitializeComponent();
            _HDservices = new QLhoaDonServices();
            _NVservices = new QLnhanVienServices();
            _KHservices = new QLkhachHangServices();
        }
       
    }
}
