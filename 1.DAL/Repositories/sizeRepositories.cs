using _1.DAL.Context;
using _1.DAL.IRepositories;
using _1.DAL.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace _1.DAL.Repositories
{
    public class sizeRepositories : IsizeRepositories
    {
        private List<size> _lstSize;
        private DatabaseContext _context;
        public sizeRepositories()
        {
            _lstSize = new List<size>();
            _context = new DatabaseContext();
        }
        public bool addsize(size Size)
        {
            _context.Add(Size);
            _context.SaveChanges();
            return true;
        }

        public bool RemoveSize(size Size)
        {
            _context.Remove(Size);
            _context.SaveChanges();
            return true;
        }
        public bool UpdateSize(size Size)
        {
            _context.Update(Size);
            _context.SaveChanges();
            return true;
        }

        public List<size> GetSizeFromDB()
        {
            _lstSize = _context.Sizes.ToList();
            return _lstSize;
        }
    }
}
