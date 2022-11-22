using _1.DAL.Context;
using _1.DAL.IRepositories;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.DAL.Repositories
{
    public class sanPhamRepositories : IsanPhamRepositories
    {
        private List<sanPham> _lstSanPham;
        private DatabaseContext _context;
        public sanPhamRepositories()
        {
            _lstSanPham = new List<sanPham>();
            _context = new DatabaseContext();
        }
        public bool addSanPham(sanPham Sanpham)
        {
            _context.Add(Sanpham);
            _context.SaveChanges();
            return true;
        }

        public bool RemoveSanpham(sanPham Sanpham)
        {
            _context.Remove(Sanpham);
            _context.SaveChanges();
            return true;
        }
        public bool UpdateSanpham(sanPham Sanpham)
        {
            _context.Update(Sanpham);
            _context.SaveChanges();
            return true;
        }

        public List<sanPham> GetSanPhamFromDB()
        {
            _lstSanPham = _context.Sanphams.ToList();
            return _lstSanPham;
        }
    }
}
