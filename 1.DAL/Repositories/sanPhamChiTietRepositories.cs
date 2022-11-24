using _1.DAL.Context;
using _1.DAL.IRepositories;
using _1.DAL.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace _1.DAL.Repositories
{
    public class sanPhamChiTietRepositories : IsanPhamRepositories
    {
        private List<SanPham> _lstSanPhamChiTiet;
        private DatabaseContext _context;
        public sanPhamChiTietRepositories()
        {
            _lstSanPhamChiTiet = new List<SanPham>();
            _context = new DatabaseContext();
        }
        public bool addsanPhamChiTiet(SanPham SanPhamChiTiet)
        {
            _context.Add(SanPhamChiTiet);
            _context.SaveChanges();
            return true;
        }

        public bool RemoveSanPhamChiTiet(SanPham SanPhamChiTiet)
        {
            _context.Remove(SanPhamChiTiet);
            _context.SaveChanges();
            return true;
        }
        public bool UpdateSanPhamChiTiet(SanPham SanPhamChiTiet)
    {
            _context.Update(SanPhamChiTiet);
            _context.SaveChanges();
            return true;
        }

        public List<SanPham> GetSanPhamChiTietFromDB()
        {
            _lstSanPhamChiTiet = _context.sanPhamChiTiets.ToList();
            return _lstSanPhamChiTiet;
        }
    }
}
