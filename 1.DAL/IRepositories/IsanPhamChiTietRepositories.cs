using _1.DAL.Models;
using System.Collections.Generic;
using System;

namespace _1.DAL.IRepositories
{
    public interface IsanPhamChiTietRepositories
    {
        List<sanPhamChiTiet> GetAll(); // Lấy tất cả các SP trong DB
        sanPhamChiTiet GetById(Guid id); // Lấy sản phẩm theo ID
        bool addsanPhamChiTiet(sanPhamChiTiet SanPhamChiTiet); // Thêm Sản phẩm
        bool RemoveSanPhamChiTiet(sanPhamChiTiet sanPhamChiTiet); // Xóa
        bool UpdateSanPhamChiTiet(sanPhamChiTiet sanPhamChiTiet); // Sửa 1 sản phẩm
    }
}
