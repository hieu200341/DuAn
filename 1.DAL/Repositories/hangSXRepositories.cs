using System.Collections.Generic;
using System;
using System.Linq;
using _1.DAL.Context;
using _1.DAL.IRepositories;
using _1.DAL.Models;

namespace _1.DAL.Repositories
{
    public class hangSXRepositories: IhangSXRepositories
    {
        private List<hangSX> _lsthangSX;
        private DatabaseContext _context;
        public hangSXRepositories()
        {
            _lsthangSX = new List<hangSX>();
            _context = new DatabaseContext();
        }
        public bool addHangSX(hangSX HangSX)
        {
            _context.Add(HangSX);
            _context.SaveChanges();
            return true;
        }

        public bool RemoveHangSX(hangSX HangSX) 
        {
            _context.Remove(HangSX);
            _context.SaveChanges();
            return true;
        }
        public bool UpdateHangSX(hangSX HangSX)
        {
            _context.Update(HangSX);
            _context.SaveChanges();
            return true;
        }

        public List<hangSX> GetHangSXFromDB()
        {
            _lsthangSX = _context.hangSXes.ToList();
            return _lsthangSX;
        }
    }
}
