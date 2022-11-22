using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class chatLieu
    {
        public Guid IdChatLieu { get; set; }
        public string maChatLieu { get; set; }
        public string tenCL { get; set; }
        public bool trangThai { get; set; }
        public virtual List<sanPhamChiTiet>? SanphamChitietss { get; set; }
    }
}
