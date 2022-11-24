using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class size
    {
        public Guid IdSize { get; set; }
        public string maSize { get; set; }
        public string SiZe { get; set; }
        public bool trangThai { get; set; }
        public virtual List<SanPham>? SanphamChitietss { get; set; }
    }
}
