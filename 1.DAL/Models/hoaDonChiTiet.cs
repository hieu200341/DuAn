﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class hoaDonChiTiet
    {
        public int IDHoaDon { get; set; }
        public int IDSanPham { get; set; }
        public int Soluong { get; set; }
        public decimal donGia { get; set; }
        public bool Trangthai { get; set; }
        public SanPham sanPham { get; set; }
        public hoaDon hoaDon { get; set; }
    }
}
