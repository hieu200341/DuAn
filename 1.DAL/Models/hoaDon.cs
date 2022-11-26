﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class hoaDon
    {
        public int maHoaDon { get; set; }
        public int maNhanVien { get; set; }
        public string SDT_KH { get; set; }
        public DateTime ngayBan { get; set; }
        public DateTime ngayTT { get; set; }
        public bool trangThai { get; set; }
        public virtual List<hoaDonChiTiet> HoaDonChiTiets { get; set; }
        public nhanVien nhanVien { get; set; }
        public khachHang khachHang { get; set; }
    }
}
