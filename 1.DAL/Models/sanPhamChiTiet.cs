using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class sanPhamChiTiet
    {
        public Guid IdPhamChiTiet { get; set; }
        public Guid IdSP { get; set; }
        public Guid IdMauSac { get; set; }
        public Guid IdChatLieu { get; set; }
        public Guid IdSize { get; set; }
        public Guid IdHangSX { get; set; }
        public double Gianhap { get; set; }
        public double Giaban { get; set; }
        public int Soluong { get; set; }
        public bool Trangthai { get; set; }
        public sanPham sanPham { get; set; }
        public mauSac mauSac { get; set; }
        public size size { get; set; }
        public hangSX hangSX { get; set; }
        public chatLieu chatLieu { get; set; }
        public List<hoaDonChiTiet> hoaDonChiTiet { get; set; }
    }
}
