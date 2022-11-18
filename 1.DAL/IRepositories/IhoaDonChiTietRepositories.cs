using _1.DAL.Models;
using System.Collections.Generic;
using System;

namespace _1.DAL.IRepositories
{
    public interface IhoaDonChiTietRepositories
    {
        List<hoaDonChiTiet> GetAll(); // Lấy tất cả các SP trong DB
        hoaDonChiTiet GetById(Guid id); // Lấy sản phẩm theo ID
        bool addHoaDonChiTiet(hoaDonChiTiet HoaDonChiTiet); // Thêm Sản phẩm
        bool RemoveHoaDonChiTiet(hoaDonChiTiet HoaDonChiTiet); // Xóa
        bool UpdateHoaDonChiTiet(hoaDonChiTiet HoaDonChiTiet); // Sửa 1 sản phẩm
    }
}
