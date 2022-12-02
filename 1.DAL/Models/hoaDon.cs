using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class hoaDon
    {
<<<<<<< HEAD
        public int IDHoaDon { get; set; }
        public int IDNhanVien { get; set; }
        public string? SDT_KH { get; set; }
        public float tongTien { get; set; }
=======
        public int maHoaDon { get; set; }
        public int maNhanVien { get; set; }
        public string SDT_KH { get; set; }
>>>>>>> 1710443d32302164027f53c3117c1f3cc70e67a3
        public DateTime ngayBan { get; set; }
        public string ghiChu { get; set; }
        public bool trangThai { get; set; }
        public virtual List<hoaDonChiTiet> HoaDonChiTiets { get; set; }
        public nhanVien nhanVien { get; set; }
        public khachHang khachHang { get; set; }
    }
}
