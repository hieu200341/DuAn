using _1.DAL.Models;
using System.Collections.Generic;
using System;

namespace _1.DAL.IRepositories
{
    public interface IsanPhamChiTietRepositories
    {
        List<sanPhamChiTiet> GetSanPhamFromDB(); 
        bool addsanPham(sanPhamChiTiet sanPhamCT); 
        bool RemoveSanPham(sanPhamChiTiet sanPhamCT); 
        bool UpdateSanPham(sanPhamChiTiet sanPhamCT); 
    }
}
