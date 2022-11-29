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

namespace _3.GUI.View.BanHang
{
    public partial class FrmGioHang : Form
    {
        private IQLsanPhamServices _qLsanPhamServices;
        public FrmGioHang()
        {
            _qLsanPhamServices= new QLsanPhamServices();
            InitializeComponent();
            LoadSanPham();
        }
        public void LoadSanPham()
        {
            dtgv_sanPham.Rows.Clear();
            foreach (var item in _qLsanPhamServices.getViewSanPham())
            {
                dtgv_sanPham.Rows.Add(item.SanPhams.maSanPham, item.SanPhams.TenSP, item.mauSacs.tenMau, item.sizes.SiZe, item.SanPhams.Giaban, item.hangSXs.tenHangSX, item.SanPhams.Soluong);
            }
        }
    }
}
