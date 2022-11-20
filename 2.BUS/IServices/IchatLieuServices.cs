using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.BUS.ViewModel;


namespace _2.BUS.IServices
{
    public interface IchatLieuServices
    {
        string Add(ChatLieuViews obj);
        string Update(ChatLieuViews obj);
        string Delete(ChatLieuViews obj);
         List<ChatLieuViews> GetAll();
    }
}
