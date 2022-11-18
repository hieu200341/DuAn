using _1.DAL.Models;
using System.Collections.Generic;
using System;

namespace _1.DAL.IRepositories
{
    public interface IchucVuRepositories
    {
        List<chucVu> GetAll(); // Lấy tất cả các SP trong DB
        chucVu GetById(Guid id); // Lấy sản phẩm theo ID
        bool addChucVu(chucVu ChucVu); // Thêm Sản phẩm
        bool RemoveChucVu(chucVu ChucVu); // Xóa
        bool UpdateChucVu(chucVu ChucVu); // Sửa 1 sản phẩm
    }
}
