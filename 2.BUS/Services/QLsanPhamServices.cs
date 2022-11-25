﻿using _1.DAL.IRepositories;
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
        private List<SanPham> _lstsanPham;

        public QLsanPhamServices()
        {
            _lstsanPham = new List<SanPham>();
            _sanPham = new sanPhamRepositories();
        }

        public bool addsanPham(SanPham sanPham)
        {
            _sanPham.addsanPham(sanPham);
            return true;
        }

        public bool RemoveSanPham(SanPham sanPham)
        {
            _sanPham.RemoveSanPham(sanPham);
            return true;
        }

        public List<SanPham> GetSanPhamFromDB()
        {
            _lstsanPham = _sanPham.GetSanPhamFromDB();
            return _lstsanPham;
        }

        public bool UpdateSanPham(SanPham sanPham)
        {
            _sanPham.UpdateSanPham(sanPham);
            return true;
        }
    }
}
