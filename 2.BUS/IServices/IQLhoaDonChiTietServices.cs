using _1.DAL.Models;
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
    }
}
