using _1.DAL.Models;
using System.Collections.Generic;
using System;

namespace _1.DAL.IRepositories
{
    public interface IsanPhamRepositories
    {
        List<SanPham> GetSanPhamFromDB(); 
        bool addsanPham(SanPham SanPham); 
        bool RemoveSanPham(SanPham SanPham); 
        bool UpdateSanPham(SanPham SanPham); 
    }
}
