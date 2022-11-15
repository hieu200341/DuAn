using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class hoaDon
    {
        public Guid IdHD { get; set; }
        public Guid IdNV { get; set; }
        public Guid IdKhachHang { get; set; }
        public DateTime ngayBan { get; set; }
        public DateTime ngayTT { get; set; }
        public bool trangThai { get; set; }
        public virtual List<hoaDonChiTiet> HoaDonChiTiets { get; set; }
        public nhanVien nhanVien { get; set; }
        public khachHang khachHang { get; set; }
    }
}
