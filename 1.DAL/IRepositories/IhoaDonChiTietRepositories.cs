using _1.DAL.Models;
using System.Collections.Generic;
using System;

namespace _1.DAL.IRepositories
{
    public interface IhoaDonChiTietRepositories
    {
        List<hoaDonChiTiet> GetHoaDonChiTietFromDB(); 
        bool addHoaDonChiTiet(hoaDonChiTiet HoaDonChiTiet); 
        bool RemoveHoaDonChiTiet(hoaDonChiTiet HoaDonChiTiet); 
        bool UpdateHoaDonChiTiet(hoaDonChiTiet HoaDonChiTiet); 
    }
}
