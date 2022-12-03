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
    public class QLsanPhamServices : IQLsanPhamServices
    {
        private IsanPhamRepositories _sanPham;
        private List<sanPham1> _lstsanPham;

        public QLsanPhamServices()
        {
            _lstsanPham = new List<sanPham1>();
            _sanPham = new sanPhamRepositories();
        }

        public bool addsanPham(sanPham1 SanPham)
        {
            _sanPham.addsanPham(SanPham);
            return true;
        }

        public bool RemovesanPham(sanPham1 SanPham)
        {
            _sanPham.RemovesanPham(SanPham);
            return true;
        }

        public List<sanPham1> GetsanPhamFromDB()
        {
            _lstsanPham = _sanPham.GetsanPhamFromDB();
            return _lstsanPham;
        }

        public bool UpdatesanPham(sanPham1 SanPham)
        {
            _sanPham.UpdatesanPham(SanPham);
            return true;
        }
    }
}
