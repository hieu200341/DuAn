
using System.Collections.Generic;
using System;
using System.Linq;
using _1.DAL.Context;
using _1.DAL.IRepositories;
using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace _1.DAL.Repositories
{
    public class chatLieuRepositories: IchatLieuRepositories
    {
        private List<chatLieu> _lstChatLieu;
        private DatabaseContext _context;
        public chatLieuRepositories()
        {
            _lstChatLieu= new List<chatLieu>();
            _context = new DatabaseContext();
        }
        public bool addchatLieu(chatLieu ChatLieu)
        {
            _context.Add(ChatLieu);
            _context.SaveChanges();
            return true;
        }
        public bool RemoveChatLieu(chatLieu ChatLieu) // Xóa sản phẩm
        {
            _context.Remove(ChatLieu);
            _context.SaveChanges();
            return true;

        }
        public bool UpdateChatLieu(chatLieu ChatLieu)
        {
            _context.Update(ChatLieu);
            _context.SaveChanges();
            return true;
        }

        public List<chatLieu> GetchatLieuFromDB()
        {
            _lstChatLieu = _context.chatLieus.ToList();
            return _lstChatLieu;
        }
    }
}
