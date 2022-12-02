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
            if (HoaDon == null) return false;
            _context.Add(HoaDon);
            _context.SaveChanges();
            return true;
            
        }

        public bool RemoveHoaDon(hoaDon HoaDon)
        {
            if (HoaDon == null) return false;
            var temp = _context.hoaDons.FirstOrDefault(c => c.maHoaDon == HoaDon.maHoaDon);
            _context.Remove(temp);
            _context.SaveChanges();
            return true;
        }
        public bool UpdateHoaDon(hoaDon HoaDon)
        {
            if (HoaDon == null) return false;
            var temp = _context.hoaDons.FirstOrDefault(c => c.maHoaDon == HoaDon.maHoaDon);
            temp.maNhanVien = HoaDon.maNhanVien;
            temp.SDT_KH = HoaDon.SDT_KH;
            temp.ngayBan = HoaDon.ngayBan;
            temp.ngayTT = HoaDon.ngayTT;
            temp.trangThai = HoaDon.trangThai;
            _context.Update(temp);
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
