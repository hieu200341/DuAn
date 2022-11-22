using _1.DAL.Models;
using System.Collections.Generic;
using System;

namespace _1.DAL.IRepositories
{
    public interface IsanPhamChiTietRepositories
    {
        List<sanPhamChiTiet> GetSanPhamChiTietFromDB();
        bool addsanPhamChiTiet(sanPhamChiTiet SanPhamChiTiet);
        bool RemoveSanPhamChiTiet(sanPhamChiTiet SanPhamChiTiet);
        bool UpdateSanPhamChiTiet(sanPhamChiTiet SanPhamChiTiet);
    }
}
