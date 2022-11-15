
using System.Collections.Generic;
using System;
using System.Linq;
using _1.DAL.Context;
using _1.DAL.IRepositories;
using _1.DAL.Models;

namespace _1.DAL.Repositories
{
    public class chatLieuRepositories: IchatLieuRepositories
    {
        DatabaseContext DbContext;
        public chatLieuRepositories(DatabaseContext DbContext)
        {
            this.DbContext = DbContext;
        }
        public bool addchatLieu(chatLieu ChatLieu)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<chatLieu> GetAll()
        {
            return DbContext.chatLieus.ToList();
        }
        public chatLieu GetById(Guid id)
        {
            var chatlieu = DbContext.chatLieus.Find(id);
            // Find(param) chỉ dùng với id của sản phẩm
            var chatLieu2 = DbContext.chatLieus.
                FirstOrDefault(p => p.IdChatLieu == id);
            return chatLieu2; // sanpham2

        }
        public bool RemoveChatLieu(chatLieu ChatLieu) // Xóa sản phẩm
        {
            try
            {
                DbContext.chatLieus.Remove(ChatLieu);
                DbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool UpdateChatLieu(chatLieu ChatLieu)
        {
            try
            {
                DbContext.chatLieus.Update(ChatLieu);
                DbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
