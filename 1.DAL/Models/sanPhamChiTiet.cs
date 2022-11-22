﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class sanPhamChiTiet
    {
        public Guid IdSanPhamChiTiet { get; set; }
        public string maSanPhamChiTiet { get; set; }
        public string maSanPham { get; set; }
        public string maMauSac { get; set; }
        public string maChatLieu { get; set; }
        public string maSize { get; set; }
        public string maHangSX { get; set; }
        public double Gianhap { get; set; }
        public double Giaban { get; set; }
        public int Soluong { get; set; }
        public bool Trangthai { get; set; }
        public sanPham sanPham { get; set; }
        public mauSac mauSac { get; set; }
        public size size { get; set; }
        public hangSX hangSX { get; set; }
        public chatLieu chatLieu { get; set; }
        public List<hoaDonChiTiet> hoaDonChiTiet { get; set; }
    }
}
