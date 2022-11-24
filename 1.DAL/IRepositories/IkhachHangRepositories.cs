using _1.DAL.Models;
using System.Collections.Generic;
using System;

namespace _1.DAL.IRepositories
{
    public interface IkhachHangRepositories
    {
        List<khachHang> GetkhachHangFromDB(); 
        bool addkhachHang(khachHang KhachHang); 
        bool RemoveKhachHang(khachHang KhachHang); 
        bool UpdateKhachHang(khachHang KhachHang); 
    }
}
