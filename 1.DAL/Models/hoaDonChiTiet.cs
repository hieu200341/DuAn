using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class hoaDonChiTiet
    {
        public string maHoaDon { get; set; }
        public string maSanPhamChiTiet { get; set; }
        public int Soluong { get; set; }
        public float donGia { get; set; }
        public bool Trangthai { get; set; }
        public sanPhamChiTiet sanPhamChiTiet { get; set; }
        public hoaDon hoaDon { get; set; }
    }
}
