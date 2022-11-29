using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class SanPham
    {
        public int maSanPham { get; set; }
        public int maMauSac { get; set; }
        public int maSize { get; set; }
        public int maHangSX { get; set; }
        public string TenSP { get; set; }
        public decimal Gianhap { get; set; }
        public decimal Giaban { get; set; }
        public int Soluong { get; set; }
        public bool Trangthai { get; set; }
        public string linkAnh { get; set; }
        public mauSac mauSac { get; set; }
        public size size { get; set; }
        public hangSX hangSX { get; set; }
        public List<hoaDonChiTiet> hoaDonChiTiet { get; set; }
    }
}
