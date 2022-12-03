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
        private List<sanPhamChiTiet> _lstSanPhamCT;
        private DatabaseContext _context;
        public sanPhamChiTietRepositories()
        {
            _lstSanPhamCT = new List<sanPhamChiTiet>();
            _context = new DatabaseContext();
        }
        public bool addsanPham(sanPhamChiTiet sanPhamCT)
        {
            _context.Add(sanPhamCT);
            _context.SaveChanges();
            return true;
        }

        public bool RemoveSanPham(sanPhamChiTiet sanPhamCT)
        {
            _context.Remove(sanPhamCT);
            _context.SaveChanges();
            return true;
        }
        public bool UpdateSanPham(sanPhamChiTiet sanPhamCT)
    {
            _context.Update(sanPhamCT);
            _context.SaveChanges();
            return true;
        }

        public List<sanPhamChiTiet> GetSanPhamFromDB()
        {
            _lstSanPhamCT = _context.sanPhamCTs.ToList();
            return _lstSanPhamCT;
        }
    }
}
