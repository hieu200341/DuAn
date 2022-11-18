using _1.DAL.Models;
using System.Collections.Generic;
using System;

namespace _1.DAL.IRepositories
{
    public interface IhoaDonRepositories
    {
        List<hoaDon> GetAll(); // Lấy tất cả các SP trong DB
        hoaDon GetById(Guid id); // Lấy sản phẩm theo ID
        bool addHoaDon(hoaDon HoaDon); // Thêm Sản phẩm
        bool RemoveHoaDon(hoaDon HoaDon); // Xóa
        bool UpdateHoaDon(hoaDon HoaDon); // Sửa 1 sản phẩm
    }
}
