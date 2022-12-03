using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class mauSac
    {
        public int IDMauSac { set; get; }
        public string tenMau { get; set; }
        public bool trangThai { get; set; }
        public virtual List<sanPhamChiTiet>? SanphamChitietss { get; set; }
    }
}
