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
    internal class QLsanPhamChiTietServices : IQLsanPhamChiTietServices
    {
        private IsanPhamChiTietRepositories _sanPhamChiTiet;
        private List<sanPhamChiTiet> _lstsanPhamChiTiet;

        public QLsanPhamChiTietServices()
        {
            _lstsanPhamChiTiet = new List<sanPhamChiTiet>();
            _sanPhamChiTiet = new sanPhamChiTietRepositories();
        }

        public bool addsanPhamChiTiet(sanPhamChiTiet SanPhamChiTiet)
        {
            _sanPhamChiTiet.addsanPhamChiTiet(SanPhamChiTiet);
            return true;
        }

        public bool RemoveSanPhamChiTiet(sanPhamChiTiet SanPhamChiTiet)
        {
            _sanPhamChiTiet.RemoveSanPhamChiTiet(SanPhamChiTiet);
            return true;
        }

        public List<sanPhamChiTiet> GetSanPhamChiTietFromDB()
        {
            _lstsanPhamChiTiet = _sanPhamChiTiet.GetSanPhamChiTietFromDB();
            return _lstsanPhamChiTiet;
        }

        public bool UpdateSanPhamChiTiet(sanPhamChiTiet SanPhamChiTiet)
        {
            _sanPhamChiTiet.UpdateSanPhamChiTiet(SanPhamChiTiet);
            return true;
        }
    }
}
