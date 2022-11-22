using _1.DAL.Models;
using System;
using System.Collections.Generic;

namespace _1.DAL.IRepositories
{
    public interface IchatLieuRepositories
    {
        List<chatLieu> GetchatLieuFromDB();
        bool addchatLieu(chatLieu ChatLieu);
        bool RemoveChatLieu(chatLieu ChatLieu);
        bool UpdateChatLieu(chatLieu ChatLieu);
    }
}
