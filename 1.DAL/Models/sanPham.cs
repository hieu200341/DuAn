using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class SanPham
    {
        public Guid IdSanPham { get; set; }
        public string maSanPham { get; set; }
        public string maMauSac { get; set; }
        public string maSize { get; set; }
        public string maHangSX { get; set; }
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
