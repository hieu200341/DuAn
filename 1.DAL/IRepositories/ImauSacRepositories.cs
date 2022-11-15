using _1.DAL.Models;
using System.Collections.Generic;
using System;

namespace _1.DAL.IRepositories
{
    public interface ImauSacRepositories
    {
        IEnumerable<mauSac> GetAll(); // Lấy tất cả các SP trong DB
        mauSac GetById(Guid id); // Lấy sản phẩm theo ID
        bool addMauSac(mauSac MauSac); // Thêm Sản phẩm
        bool RemoveMauSac(mauSac MauSac); // Xóa
        bool UpdateMauSac(mauSac MauSac); // Sửa 1 sản phẩm
    }
}
