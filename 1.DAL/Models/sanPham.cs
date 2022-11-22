using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class sanPham
    {
        public Guid IdSP { get; set; }
        public string maSanPham { get; set; }
        public string TenSP { get; set; }
        public bool trangThai { get; set; }
        public virtual List<sanPhamChiTiet>? sanPhamChiTiets { get; set; }
    }
}
