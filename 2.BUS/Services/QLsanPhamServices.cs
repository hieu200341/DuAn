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
    internal class QLsanPhamServices : IQLsanPhamServices
    {
        private IsanPhamRepositories _sanPhamChiTiet;
        private List<SanPham> _lstsanPhamChiTiet;

        public QLsanPhamServices()
        {
            _lstsanPhamChiTiet = new List<SanPham>();
            _sanPhamChiTiet = new sanPhamChiTietRepositories();
        }

        public bool addsanPhamChiTiet(SanPham SanPhamChiTiet)
        {
            _sanPhamChiTiet.addsanPhamChiTiet(SanPhamChiTiet);
            return true;
        }

        public bool RemoveSanPhamChiTiet(SanPham SanPhamChiTiet)
        {
            _sanPhamChiTiet.RemoveSanPhamChiTiet(SanPhamChiTiet);
            return true;
        }

        public List<SanPham> GetSanPhamChiTietFromDB()
        {
            _lstsanPhamChiTiet = _sanPhamChiTiet.GetSanPhamChiTietFromDB();
            return _lstsanPhamChiTiet;
        }

        public bool UpdateSanPhamChiTiet(SanPham SanPhamChiTiet)
        {
            _sanPhamChiTiet.UpdateSanPhamChiTiet(SanPhamChiTiet);
            return true;
        }
    }
}
