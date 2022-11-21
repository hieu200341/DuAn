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
        private IsanPhamRepositories _sanPham;
        private List<sanPham> _lstsanPham;

        public QLsanPhamServices()
        {
            _lstsanPham = new List<sanPham>();
            _sanPham = new sanPhamRepositories();
        }

        public bool addSanPham(sanPham Sanpham)
        {
            _sanPham.addSanPham(Sanpham);
            return true;
        }

        public bool RemoveSanpham(sanPham Sanpham)
        {
            _sanPham.RemoveSanpham(Sanpham);
            return true;
        }

        public List<sanPham> GetSanPhamFromDB()
        {
            _lstsanPham = _sanPham.GetSanPhamFromDB();
            return _lstsanPham;
        }

        public bool UpdateSanpham(sanPham Sanpham)
        {
            _sanPham.UpdateSanpham(Sanpham);
            return true;
        }
    }
}
