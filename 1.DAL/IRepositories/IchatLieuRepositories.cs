using _1.DAL.Models;
using System;
using System.Collections.Generic;

namespace _1.DAL.IRepositories
{
    public interface IchatLieuRepositories
    {
        IEnumerable<chatLieu> GetAll(); // Lấy tất cả các SP trong DB
        chatLieu GetById(Guid id); // Lấy sản phẩm theo ID
        bool addchatLieu(chatLieu ChatLieu); // Thêm Sản phẩm
        bool RemoveChatLieu(chatLieu ChatLieu); // Xóa
        bool UpdateChatLieu(chatLieu ChatLieu); // Sửa 1 sản phẩm
    }
}
