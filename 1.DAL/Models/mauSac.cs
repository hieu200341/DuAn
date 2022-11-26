using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class mauSac
    {
        public string maMauSac { set; get; }
        public string tenMau { get; set; }
        public bool trangThai { get; set; }
        public virtual List<SanPham>? SanphamChitietss { get; set; }
    }
}
