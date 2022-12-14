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
    public class QLkhachHangServices : IQLkhachHangServices
    {
        private IkhachHangRepositories _khachHang;
        private IhoaDonRepositories _hoaDon;
        private List<khachHang> _lstkhachHang;
        private List<ViewHienThi1> _lstView;

        public QLkhachHangServices()
        {
            _lstkhachHang = new List<khachHang>();
            _khachHang = new khachHangRepositories();
            _hoaDon = new hoaDonRepositories();
            _lstView = new List<ViewHienThi1>();

        }

        public bool addkhachHang(khachHang KhachHang)
        {
            _khachHang.addkhachHang(KhachHang);
            return true;
        }

        public bool RemoveKhachHang(khachHang KhachHang)
        {
            _khachHang.RemoveKhachHang(KhachHang);
            return true;
        }

        public List<khachHang> GetkhachHangFromDB()
        {
            _lstkhachHang = _khachHang.GetkhachHangFromDB();
            return _lstkhachHang;
        }

        public bool UpdateKhachHang(khachHang KhachHang)
        {
            _khachHang.UpdateKhachHang(KhachHang);
            return true;
        }
        public List<ViewHienThi1> getViewkhachHang()
        {
            _lstView = (from a in GetkhachHangFromDB()
                        join b in _hoaDon.GetHoaDonFromDB() on a.SDT_KH equals b.SDT_KH
                        select new ViewHienThi1 { khachHangs = a, hoaDons = b}).ToList();
            return _lstView;
        }
    }
}
