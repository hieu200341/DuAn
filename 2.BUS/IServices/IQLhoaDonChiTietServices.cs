using _1.DAL.Models;
using _2.BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLhoaDonChiTietServices
    {
        List<hoaDonChiTiet> GetHoaDonChiTietFromDB();
        bool addHoaDonChiTiet(hoaDonChiTiet HoaDonChiTiet);
        bool RemoveHoaDonChiTiet(hoaDonChiTiet HoaDonChiTiet);
        bool UpdateHoaDonChiTiet(hoaDonChiTiet HoaDonChiTiet);
        List<ViewHoaDonCT> getViewHoaDonChiTiet(int maHoaDon);
       
    }
}
