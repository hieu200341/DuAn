using _1.DAL.Models;
using System.Collections.Generic;
using System;

namespace _1.DAL.IRepositories
{
    public interface IhangSXRepositories
    {
        IEnumerable<hangSX> GetAll(); // Lấy tất cả các SP trong DB
        hangSX GetById(Guid id); // Lấy sản phẩm theo ID
        bool addHangSX(hangSX HangSX); // Thêm Sản phẩm
        bool RemoveHangSX(hangSX HangSX); // Xóa
        bool UpdateHangSX(hangSX HangSX); // Sửa 1 sản phẩm
    }
}
