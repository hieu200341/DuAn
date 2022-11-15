using _1.DAL.Models;
using System.Collections.Generic;
using System;

namespace _1.DAL.IRepositories
{
    public interface InhanVienRepositories
    {
        IEnumerable<nhanVien> GetAll(); // Lấy tất cả các SP trong DB
        nhanVien GetById(Guid id); // Lấy sản phẩm theo ID
        bool addNhanVien(nhanVien NhanVien); // Thêm Sản phẩm
        bool RemoveNhanVien(nhanVien NhanVien); // Xóa
        bool UpdateNhanVien(nhanVien NhanVien); // Sửa 1 sản phẩm
    }
}
