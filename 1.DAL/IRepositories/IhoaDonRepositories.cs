using _1.DAL.Models;
using System.Collections.Generic;
using System;

namespace _1.DAL.IRepositories
{
    public interface IhoaDonRepositories
    {
        List<hoaDon> GetHoaDonFromDB(); 
        bool addHoaDon(hoaDon HoaDon); 
        bool RemoveHoaDon(hoaDon HoaDon); 
        bool UpdateHoaDon(hoaDon HoaDon); 
    }
}
