using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class SanPham
    {
<<<<<<< HEAD
        public int IDSanPham { get; set; }
        public int IDMauSac { get; set; }
        public int IDSize { get; set; }
        public int IDHangSX { get; set; }
        public string? TenSP { get; set; }
        public string? maSP { get; set; }
        public float Gianhap { get; set; }
        public float Giaban { get; set; }
=======
        public int maSanPham { get; set; }
        public int maMauSac { get; set; }
        public int maSize { get; set; }
        public int maHangSX { get; set; }
        public string TenSP { get; set; }
        public decimal Gianhap { get; set; }
        public decimal Giaban { get; set; }
>>>>>>> 1710443d32302164027f53c3117c1f3cc70e67a3
        public int Soluong { get; set; }
        public bool Trangthai { get; set; }
        public string linkAnh { get; set; }
        public mauSac mauSac { get; set; }
        public size size { get; set; }
        public hangSX hangSX { get; set; }
        public List<hoaDonChiTiet> hoaDonChiTiet { get; set; }
    }
}
