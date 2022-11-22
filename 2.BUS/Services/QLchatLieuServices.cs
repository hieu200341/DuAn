using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class QLchatLieuServices : IQLchatLieuServices
    {
        private IchatLieuRepositories _chatLieu;
        private List<chatLieu> _lstChatLieu;

        public QLchatLieuServices()
        {
            _lstChatLieu = new List<chatLieu>();
            _chatLieu = new chatLieuRepositories();
        }

        public bool AddchatLieu(chatLieu ChatLieu)
        {
            _chatLieu.addchatLieu(ChatLieu);
            return true;
        }

        public bool RemoveChatLieu(chatLieu ChatLieu)
        {
            _chatLieu.RemoveChatLieu(ChatLieu);
            return true;
        }

        public List<chatLieu> GetchatLieuFromDB()
        {
            _lstChatLieu = _chatLieu.GetchatLieuFromDB();
            return _lstChatLieu;
        }

        public bool UpdateChatLieu(chatLieu ChatLieu)
        {
            _chatLieu.UpdateChatLieu(ChatLieu);
            return true;
        }
    }
}
