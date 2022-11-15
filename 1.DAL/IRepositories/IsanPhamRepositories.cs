using _1.DAL.Models;
using System.Collections.Generic;
using System;

namespace _1.DAL.IRepositories
{
    public interface IsanPhamRepositories
    {
        IEnumerable<sanPham> GetAll(); // Lấy tất cả các SP trong DB
        sanPham GetById(Guid id); // Lấy sản phẩm theo ID
        bool addSanPham(sanPham sanpham); // Thêm Sản phẩm
        bool RemoveSanpham(sanPham sanpham); // Xóa
        bool UpdateSanpham(sanPham sanpham); // Sửa 1 sản phẩm
    }
}
