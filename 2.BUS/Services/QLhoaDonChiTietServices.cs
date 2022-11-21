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
    internal class QLhoaDonChiTietServices : IQLhoaDonChiTietServices
    {
        private IhoaDonChiTietRepositories _hoaDonChiTiet;
        private List<hoaDonChiTiet> _lsthoaDonChiTiet;

        public QLhoaDonChiTietServices()
        {
            _lsthoaDonChiTiet = new List<hoaDonChiTiet>();
            _hoaDonChiTiet = new hoaDonChiTietRepositories();
        }

        public bool addHoaDonChiTiet(hoaDonChiTiet HoaDonChiTiet)
        {
           _hoaDonChiTiet.addHoaDonChiTiet(HoaDonChiTiet);
            return true;
        }

        public bool RemoveHoaDonChiTiet(hoaDonChiTiet HoaDonChiTiet)
        {
            _hoaDonChiTiet.RemoveHoaDonChiTiet(HoaDonChiTiet);
            return true;
        }

        public List<hoaDonChiTiet> GetHoaDonChiTietFromDB()
        {
            _lsthoaDonChiTiet = _hoaDonChiTiet.GetHoaDonChiTietFromDB();
            return _lsthoaDonChiTiet;
        }

        public bool UpdateHoaDonChiTiet(hoaDonChiTiet HoaDonChiTiet)
        {
            _hoaDonChiTiet.UpdateHoaDonChiTiet(HoaDonChiTiet);
            return true;
        }
    }
}
