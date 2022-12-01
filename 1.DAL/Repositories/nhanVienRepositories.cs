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
            if (NhanVien == null) return false;
            _context.nhanViens.Add(NhanVien);
            _context.SaveChanges();
            return true;
        }

        public bool RemoveNhanVien(nhanVien NhanVien)
        {
            if (NhanVien == null) return false;
            var temp = _context.nhanViens.FirstOrDefault(p => p.IDNhanVien == NhanVien.IDNhanVien);
            _context.nhanViens.Remove(temp);
            _context.SaveChanges();
            return true;
        }
        public bool UpdateNhanVien(nhanVien NhanVien)
        {
            if (NhanVien == null) return false;
            var temp = _context.nhanViens.FirstOrDefault(p => p.IDNhanVien == NhanVien.IDNhanVien);
            temp.TenNV = NhanVien.TenNV;
            temp.SDT = NhanVien.SDT;
            temp.chucVu = NhanVien.chucVu;
            temp.IDChucVu = NhanVien.IDChucVu;
            temp.diaChi = NhanVien.diaChi;
            temp.email = NhanVien.email;
            temp.matKhau = NhanVien.matKhau;
            _context.nhanViens.Update(temp);
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
