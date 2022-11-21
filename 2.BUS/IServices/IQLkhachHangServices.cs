using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLkhachHangServices
    {
        List<khachHang> GetkhachHangFromDB();
        bool addkhachHang(khachHang KhachHang);
        bool RemoveKhachHang(khachHang KhachHang);
        bool UpdateKhachHang(khachHang KhachHang);
    }
}
