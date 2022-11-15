using _1.DAL.Models;
using System.Collections.Generic;
using System;

namespace _1.DAL.IRepositories
{
    public interface IkhachHangRepositories
    {
        IEnumerable<khachHang> GetAll(); // Lấy tất cả các SP trong DB
        khachHang GetById(Guid id); // Lấy sản phẩm theo ID
        bool addkhachHang(khachHang KhachHang); // Thêm Sản phẩm
        bool RemoveKhachHang(khachHang KhachHang); // Xóa
        bool UpdateKhachHang(khachHang KhachHang); // Sửa 1 sản phẩm
    }
}
