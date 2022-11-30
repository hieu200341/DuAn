using _1.DAL.Context;
using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class QLhoaDonChiTietServices : IQLhoaDonChiTietServices
    {
        private IhoaDonChiTietRepositories _hoaDonChiTiet;
        private List<hoaDonChiTiet> _lsthoaDonChiTiet;
        private List<hoaDonCT> _lsthoadonCT;
        private IQLhoaDonServices _qLhoaDonServices;
        private IQLsanPhamServices _qLsanPhamServices;
        private DatabaseContext _dbContex;

        public QLhoaDonChiTietServices()
        {
            _lsthoaDonChiTiet = new List<hoaDonChiTiet>();
            _hoaDonChiTiet = new hoaDonChiTietRepositories();
            _lsthoadonCT = new List<hoaDonCT>();
            _qLhoaDonServices = new QLhoaDonServices();
            _qLsanPhamServices= new QLsanPhamServices();
            _dbContex = new DatabaseContext();
        }

        public bool addHoaDonChiTiet(hoaDonChiTiet HoaDonChiTiet)
        {
           _hoaDonChiTiet.addHoaDonChiTiet(HoaDonChiTiet);
            return true;
        }

        public bool RemoveHoaDonChiTiet(hoaDonChiTiet HoaDonChiTiet)
        {
            _hoaDonChiTiet.RemoveHoaDonChiTiet(HoaDonChiTiet);
            return true;
        }

        public List<hoaDonChiTiet> GetHoaDonChiTietFromDB()
        {
            _lsthoaDonChiTiet = _hoaDonChiTiet.GetHoaDonChiTietFromDB();
            return _lsthoaDonChiTiet;
        }

        public bool UpdateHoaDonChiTiet(hoaDonChiTiet HoaDonChiTiet)
        {
            _hoaDonChiTiet.UpdateHoaDonChiTiet(HoaDonChiTiet);
            return true;
        }
        public List<hoaDonCT> getViewHoaDonChiTiet(int maHoaDon)
        {
            var data = (from od in _dbContex.hoaDonChiTiets
                        join o in _dbContex.hoaDons on od.maHoaDon equals o.maHoaDon
                        join p in _dbContex.sanPhams on od.maSanPham equals p.maSanPham
                        where od.maHoaDon == maHoaDon
                        select new hoaDonCT
                        {
                            maSanPham = od.maSanPham,
                            tenSanPham = p.TenSP,
                            soLuong = od.Soluong,
                            donGia = od.donGia
                        }).ToList();
            return data;
        }
    }
}
