using _1.DAL.Context;
using _1.DAL.IRepositories;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class sanPhamRepositories : IsanPhamRepositories
    {
        private List<sanPham1> _lstsanPham;
        private DatabaseContext _context;
        public sanPhamRepositories()
        {
            _lstsanPham = new List<sanPham1>();
            _context = new DatabaseContext();
        }
        public bool addsanPham(sanPham1 SanPham)
        {
            _context.Add(SanPham);
            _context.SaveChanges();
            return true;
        }

        public bool RemovesanPham(sanPham1 SanPham)
        {
            _context.Remove(SanPham);
            _context.SaveChanges();
            return true;
        }
        public bool UpdatesanPham(sanPham1 SanPham)
        {
            _context.Update(SanPham);
            _context.SaveChanges();
            return true;
        }

        public List<sanPham1> GetsanPhamFromDB()
        {
            _lstsanPham = _context.sanPhams.ToList();
            return _lstsanPham;
        }
    }
}
