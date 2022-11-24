using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class hangSX
    {
        public Guid IdHangSX { get; set; }
        public string maHangSX { get; set; }
        public string tenHangSX { get; set; }
        public bool trangThai { get; set; }
        public virtual List<SanPham> SanphamChitietss { get; set; }
    }
}
