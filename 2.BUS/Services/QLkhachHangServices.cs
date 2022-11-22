using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class QLkhachHangServices : IQLkhachHangServices
    {
        private IkhachHangRepositories _khachHang;
        private List<khachHang> _lstkhachHang;

        public QLkhachHangServices()
        {
            _lstkhachHang = new List<khachHang>();
            _khachHang = new khachHangRepositories();
        }

        public bool addkhachHang(khachHang KhachHang)
        {
            _khachHang.addkhachHang(KhachHang);
            return true;
        }

        public bool RemoveKhachHang(khachHang KhachHang)
        {
            _khachHang.RemoveKhachHang(KhachHang);
            return true;
        }

        public List<khachHang> GetkhachHangFromDB()
        {
            _lstkhachHang = _khachHang.GetkhachHangFromDB();
            return _lstkhachHang;
        }

        public bool UpdateKhachHang(khachHang KhachHang)
        {
            _khachHang.UpdateKhachHang(KhachHang);
            return true;
        }
    }
}
