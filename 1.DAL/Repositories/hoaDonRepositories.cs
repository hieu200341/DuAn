using _1.DAL.Context;
using _1.DAL.IRepositories;
using _1.DAL.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace _1.DAL.Repositories
{
    public class hoaDonRepositories: IhoaDonRepositories
    {
        private List<hoaDon> _lsthoaDon;
        private DatabaseContext _context;
        public hoaDonRepositories()
        {
            _lsthoaDon = new List<hoaDon>();
            _context = new DatabaseContext();
        }
        public bool addHoaDon(hoaDon HoaDon)
        {
            _context.Add(HoaDon);
            _context.SaveChanges();
            return true;
        }

        public bool RemoveHoaDon(hoaDon HoaDon)
        {
            _context.Remove(HoaDon);
            _context.SaveChanges();
            return true;
        }
        public bool UpdateHoaDon(hoaDon HoaDon)
        {
            _context.Update(HoaDon);
            _context.SaveChanges();
            return true;
        }

        public List<hoaDon> GetHoaDonFromDB()
        {
            _lsthoaDon = _context.hoaDons.ToList();
            return _lsthoaDon;
        }
    }
}
