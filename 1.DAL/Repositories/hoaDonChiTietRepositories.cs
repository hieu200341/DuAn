using _1.DAL.Context;
using _1.DAL.IRepositories;
using _1.DAL.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace _1.DAL.Repositories
{
    public class hoaDonChiTietRepositories: IhoaDonChiTietRepositories
    {
        private List<hoaDonChiTiet> _lsthoaDonChiTiet;
        private DatabaseContext _context;
        public hoaDonChiTietRepositories()
        {
            _lsthoaDonChiTiet = new List<hoaDonChiTiet>();
            _context = new DatabaseContext();
        }
        public bool addHoaDonChiTiet(hoaDonChiTiet HoaDonChiTiet)
        {
            _context.Add(HoaDonChiTiet);
            _context.SaveChanges();
            return true;
        }

        public bool RemoveHoaDonChiTiet(hoaDonChiTiet HoaDonChiTiet)
        {
            _context.Remove(HoaDonChiTiet);
            _context.SaveChanges();
            return true;
        }
        public bool UpdateHoaDonChiTiet(hoaDonChiTiet HoaDonChiTiet)
        {
            _context.Update(HoaDonChiTiet);
            _context.SaveChanges();
            return true;
        }

        public List<hoaDonChiTiet> GetHoaDonChiTietFromDB()
        {
            _lsthoaDonChiTiet = _context.hoaDonChiTiets.ToList();
            return _lsthoaDonChiTiet;
        }
    }
}
