using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class nhanVien
    {
        public int IDNhanVien { get; set; }
        public int IDChucVu { get; set; }
        public string? TenNV { get; set; }
        public string? diaChi { get; set; }
        public string? SDT { get; set; }
        public string? email { get; set; }
        public bool tinhTrang { get; set; }
        public string matKhau { get; set; }
        public chucVu chucVu { get; set; }
        public virtual List<hoaDon> HoaDons { get; set; }
    }
}
