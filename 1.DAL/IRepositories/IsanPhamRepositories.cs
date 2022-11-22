using _1.DAL.Models;
using System.Collections.Generic;
using System;

namespace _1.DAL.IRepositories
{
    public interface IsanPhamRepositories
    {
        List<sanPham> GetSanPhamFromDB();
        bool addSanPham(sanPham Sanpham);
        bool RemoveSanpham(sanPham Sanpham);
        bool UpdateSanpham(sanPham Sanpham);
    }
}
