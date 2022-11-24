using _1.DAL.Context;
using _1.DAL.IRepositories;
using _1.DAL.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace _1.DAL.Repositories
{
    public class mauSacRepositories: ImauSacRepositories
    {
        private List<mauSac> _lstMauSac;
        private DatabaseContext _context;
        public mauSacRepositories()
        {
            _lstMauSac = new List<mauSac>();
            _context = new DatabaseContext();
        }
        public bool addMauSac(mauSac MauSac)
        {
            _context.Add(MauSac);
            _context.SaveChanges();
            return true;
        }

        public bool RemoveMauSac(mauSac MauSac)
        {
            _context.Remove(MauSac);
            _context.SaveChanges();
            return true;
        }
        public bool UpdateMauSac(mauSac MauSac)
        {
            _context.Update(MauSac);
            _context.SaveChanges();
            return true;
        }

        public List<mauSac> GetMauSacFromDB()
        {
            _lstMauSac = _context.mauSacs.ToList();
            return _lstMauSac;
        }
    }
}
