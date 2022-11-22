using _1.DAL.Context;
using _1.DAL.IRepositories;
using _1.DAL.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace _1.DAL.Repositories
{
    public class nhanVienRepositories : InhanVienRepositories
    {
        private List<nhanVien> _lstNhanVien;
        private DatabaseContext _context;
        public nhanVienRepositories()
        {
            _lstNhanVien = new List<nhanVien>();
            _context = new DatabaseContext();
        }
        public bool addNhanVien(nhanVien NhanVien)
        {
            _context.Add(NhanVien);
            _context.SaveChanges();
            return true;
        }

        public bool RemoveNhanVien(nhanVien NhanVien)
        {
            _context.Remove(NhanVien);
            _context.SaveChanges();
            return true;
        }
        public bool UpdateNhanVien(nhanVien NhanVien)
        {
            _context.Update(NhanVien);
            _context.SaveChanges();
            return true;
        }

        public List<nhanVien> GetNhanVienFromDB()
        {
            _lstNhanVien = _context.nhanViens.ToList();
            return _lstNhanVien;
        }
    }
}
