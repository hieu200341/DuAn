using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;

namespace _2.BUS.ViewModel
{
    public class ChatLieuViews
    {
        public Guid IdChatLieu { get; set; }
        public string tenCL { get; set; }
        public bool trangThai { get; set; }
        public virtual List<sanPhamChiTiet>? SanphamChitietss { get; set; }
    }
}
