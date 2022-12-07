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
        private List<ViewHoaDonCT> _lsthoadonCT;
        private IQLhoaDonServices _qLhoaDonServices;
        private IQLsanPhamChiTietServices _qLsanPhamServices;
        private DatabaseContext _dbContex;

        public QLhoaDonChiTietServices()
        {
            _lsthoaDonChiTiet = new List<hoaDonChiTiet>();
            _hoaDonChiTiet = new hoaDonChiTietRepositories();
            _lsthoadonCT = new List<ViewHoaDonCT>();
            _qLhoaDonServices = new QLhoaDonServices();
            _qLsanPhamServices= new QLsanPhamChiTietServices();
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
        public List<ViewHoaDonCT> getViewHoaDonChiTiet(int maHoaDon)
        {
            var data = (from od in _dbContex.hoaDonChiTiets
                        join o in _dbContex.hoaDons on od.IDHoaDon equals o.IDHoaDon
                        join p in _dbContex.sanPhamCTs on od.IDSanPham equals p.IDSanPhamChiTiet
                        where od.IDHoaDon == maHoaDon
                        select new ViewHoaDonCT
                        {
                            ID = od.IDHoaDon,
                            maSanPham = p.maSP,
                            tenSanPham = p.TenSP,
                            soLuong = od.Soluong,
                            donGia = od.donGia
                        }).ToList();
            return data;
        }

    }
}
