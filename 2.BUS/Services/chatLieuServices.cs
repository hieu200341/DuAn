using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.BUS.IServices;
using _2.BUS.ViewModel;
using _1.DAL.Context;
using _1.DAL.Models;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;


namespace _2.BUS.Services
{
    public class chatLieuServices : IchatLieuServices
    {
        IchatLieuRepositories _ChatLieuRe;
        public chatLieuServices()
        {
            _ChatLieuRe = new chatLieuRepositories();
        }
        public string Add(ChatLieuViews obj)
        {
            if (_ChatLieuRe == null) return "Thêm thất bại";
            var temp = new chatLieu()
            {
                IdChatLieu = obj.IdChatLieu,
                tenCL = obj.tenCL,
                trangThai = obj.trangThai,
            };
            _ChatLieuRe.addchatLieu(temp);
            return "Thêm thành công";
        }

        public string Delete(ChatLieuViews obj)
        {
            if (_ChatLieuRe == null) return "Xóa Thất bại";
            var temp = _ChatLieuRe.GetAll().FirstOrDefault(c => c.IdChatLieu == obj.IdChatLieu);
            _ChatLieuRe.RemoveChatLieu(temp);
            return "Xóa thành công";
        }

        public List<ChatLieuViews> GetAll()
        {
            List<ChatLieuViews> list = new List<ChatLieuViews>();
            list = (from a in _ChatLieuRe.GetAll()
                           select new ChatLieuViews
                           {
                               IdChatLieu = a.IdChatLieu,
                               tenCL = a.tenCL,
                               trangThai = a.trangThai,

                           }).ToList();
            return list;
        }

        public string Update(ChatLieuViews obj)
        {
            if (_ChatLieuRe == null) return "Sửa Thất bại";
            var temp = _ChatLieuRe.GetAll().FirstOrDefault(c => c.IdChatLieu == obj.IdChatLieu);
            temp.tenCL = obj.tenCL;
            temp.trangThai = obj.trangThai;
            _ChatLieuRe.UpdateChatLieu(temp);
            return "Sửa thành công";
        }
    }
}
