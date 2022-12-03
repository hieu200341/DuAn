using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class sanPhamChiTiet
    {
        public int IDSanPhamChiTiet { get; set; }
        public int IDMauSac { get; set; }
        public int IDSize { get; set; }
        public int IDHangSX { get; set; }
        public int IDsanPham { get; set; }
        public string? TenSP { get; set; }
        public string? maSP { get; set; }
        public float Gianhap { get; set; }
        public float Giaban { get; set; }
        public int Soluong { get; set; }
        public bool Trangthai { get; set; }
        public string? linkAnh { get; set; }
        public mauSac mauSac { get; set; }
        public size size { get; set; }
        public hangSX hangSX { get; set; }
        public sanPham1 sanPham1 { get; set; }
        public List<hoaDonChiTiet> hoaDonChiTiet { get; set; }
    }
}
