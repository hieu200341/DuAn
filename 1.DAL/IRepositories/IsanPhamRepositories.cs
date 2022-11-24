using _1.DAL.Models;
using System.Collections.Generic;
using System;

namespace _1.DAL.IRepositories
{
    public interface IsanPhamRepositories
    {
        List<SanPham> GetSanPhamChiTietFromDB(); 
        bool addsanPhamChiTiet(SanPham SanPhamChiTiet); 
        bool RemoveSanPhamChiTiet(SanPham SanPhamChiTiet); 
        bool UpdateSanPhamChiTiet(SanPham SanPhamChiTiet); 
    }
}
