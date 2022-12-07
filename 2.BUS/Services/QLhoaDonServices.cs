using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class QLhoaDonServices : IQLhoaDonServices
    {
        private IhoaDonRepositories _hoaDon;
        InhanVienRepositories _NHanVienRe;
        IkhachHangRepositories _KHRe;
        IhoaDonChiTietRepositories _HoaDonChiTietRepositories;
        private List<hoaDon> _lsthoaDon;
        private IkhachHangRepositories _khachHang;
        private List<ViewHienThi1> _lstView;
        public QLhoaDonServices()
        {
            _lsthoaDon = new List<hoaDon>();
            _khachHang = new khachHangRepositories();
            _lstView = new List<ViewHienThi1>();
            _hoaDon = new hoaDonRepositories();
            _NHanVienRe = new nhanVienRepositories();
            _KHRe = new khachHangRepositories();
            _HoaDonChiTietRepositories = new hoaDonChiTietRepositories();
        }

        public bool addHoaDon(hoaDon HoaDon)
        {
            _hoaDon.addHoaDon(HoaDon);
            return true;
        }

        public bool RemoveHoaDon(hoaDon HoaDon)
        {
            _hoaDon.RemoveHoaDon(HoaDon);
            return true;
        }

        public List<hoaDon> GetHoaDonFromDB()
        {
            _lsthoaDon = _hoaDon.GetHoaDonFromDB();
            return _lsthoaDon;
        }

        public bool UpdateHoaDon(hoaDon HoaDon)
        {
            _hoaDon.UpdateHoaDon(HoaDon);
            return true;
        }

        public List<ViewHienThi1> getViewhoaDon()
        {
            _lstView = (from a in GetHoaDonFromDB()
                        join b in _khachHang.GetkhachHangFromDB() on a.SDT_KH equals b.SDT_KH
                        select new ViewHienThi1 { hoaDons = a, khachHangs = b }).ToList();
            return _lstView;
        }
    }
}
