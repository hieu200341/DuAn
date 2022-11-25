using _1.DAL.Models;
using System.Collections.Generic;
using System;

namespace _1.DAL.IRepositories
{
    public interface IsanPhamRepositories
    {
        List<SanPham> GetSanPhamFromDB(); 
        bool addsanPham(SanPham sanPham); 
        bool RemoveSanPham(SanPham sanPham); 
        bool UpdateSanPham(SanPham sanPham); 
    }
}
