using _1.DAL.Context;
using _1.DAL.IRepositories;
using _1.DAL.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace _1.DAL.Repositories
{
    public class sanPhamChiTietRepositories : IsanPhamChiTietRepositories
    {
        private List<sanPhamChiTiet> _lstSanPhamChiTiet;
        private DatabaseContext _context;
        public sanPhamChiTietRepositories()
        {
            _lstSanPhamChiTiet = new List<sanPhamChiTiet>();
            _context = new DatabaseContext();
        }
        public bool addsanPhamChiTiet(sanPhamChiTiet SanPhamChiTiet)
        {
            _context.Add(SanPhamChiTiet);
            _context.SaveChanges();
            return true;
        }

        public bool RemoveSanPhamChiTiet(sanPhamChiTiet SanPhamChiTiet)
        {
            _context.Remove(SanPhamChiTiet);
            _context.SaveChanges();
            return true;
        }
        public bool UpdateSanPhamChiTiet(sanPhamChiTiet SanPhamChiTiet)
        {
            _context.Update(SanPhamChiTiet);
            _context.SaveChanges();
            return true;
        }

        public List<sanPhamChiTiet> GetSanPhamChiTietFromDB()
        {
            _lstSanPhamChiTiet = _context.sanPhamChiTiets.ToList();
            return _lstSanPhamChiTiet;
        }
    }
}
