using _1.DAL.Context;
using _1.DAL.IRepositories;
using _1.DAL.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace _1.DAL.Repositories
{
    public class sanPhamRepositories : IsanPhamRepositories
    {
        private List<SanPham> _lstSanPham;
        private DatabaseContext _context;
        public sanPhamRepositories()
        {
            _lstSanPham = new List<SanPham>();
            _context = new DatabaseContext();
        }
        public bool addsanPham(SanPham sanPham)
        {
            _context.Add(sanPham);
            _context.SaveChanges();
            return true;
        }

        public bool RemoveSanPham(SanPham sanPham)
        {
            _context.Remove(sanPham);
            _context.SaveChanges();
            return true;
        }
        public bool UpdateSanPham(SanPham sanPham)
    {
            _context.Update(sanPham);
            _context.SaveChanges();
            return true;
        }

        public List<SanPham> GetSanPhamFromDB()
        {
            _lstSanPham = _context.sanPhams.ToList();
            return _lstSanPham;
        }
    }
}
