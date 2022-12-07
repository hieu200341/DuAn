using _1.DAL.Models;
using _2.BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLhoaDonServices
    {
        List<hoaDon> GetHoaDonFromDB();
        List<ViewHienThi1> getViewhoaDon();
        bool addHoaDon(hoaDon HoaDon);
        bool RemoveHoaDon(hoaDon HoaDon);
        bool UpdateHoaDon(hoaDon HoaDon);    }
}
