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
    public class QLsanPhamChiTietServices : IQLsanPhamChiTietServices
    {
        private IsanPhamChiTietRepositories _sanPhamCT;
        private List<sanPhamChiTiet> _lstsanPhamCT;
        private IQLsizeServices _qLsizeServices;
        private IQLmauSacServices _qLmauSacServices;
        private IQLhangSXServices _qLhangSXServices;
        private IQLsanPhamServices _qLsanPhamServices;
        private List<ViewHienThi1> _lstView;
        public QLsanPhamChiTietServices()
        {
            _lstsanPhamCT = new List<sanPhamChiTiet>();
            _sanPhamCT = new sanPhamChiTietRepositories();
            _lstView = new List<ViewHienThi1>();
            _qLhangSXServices = new QLhangSXServices();
            _qLmauSacServices= new QLmauSacServices();
            _qLsizeServices= new QLsizeServices();
            _qLsanPhamServices = new QLsanPhamServices();
            GetSanPhamCTTFromDB();
        }

        public bool addsanPham(sanPhamChiTiet sanPhamCT)
        {
            _sanPhamCT.addsanPham(sanPhamCT);
            return true;
        }

        public bool RemoveSanPham(sanPhamChiTiet sanPhamCT)
        {
            _sanPhamCT.RemoveSanPham(sanPhamCT);
            return true;
        }

        public List<sanPhamChiTiet> GetSanPhamCTTFromDB()
        {
            _lstsanPhamCT = _sanPhamCT.GetSanPhamFromDB();
            return _lstsanPhamCT;
        }

        public bool UpdateSanPham(sanPhamChiTiet sanPhamCT)
        {
            _sanPhamCT.UpdateSanPham(sanPhamCT);
            return true;
        }
        public List<ViewHienThi1> getViewSanPhamCT()
        {
            _lstView = (from a in GetSanPhamCTTFromDB()
                        join b in _qLmauSacServices.GetMauSacFromDB() on a.IDMauSac equals b.IDMauSac
                        join c in _qLhangSXServices.GetHangSXFromDB() on a.IDHangSX equals c.IDHangSX
                        join d in _qLsizeServices.GetSizeFromDB() on a.IDSize equals d.IDSize
                        join e in _qLsanPhamServices.GetsanPhamFromDB() on a.IDsanPham equals e.IDsanPham
                        select new ViewHienThi1 { SanPhamChiTiets = a, mauSacs = b, hangSXs = c, sizes = d, sanPhams = e }).ToList();
            return _lstView;
        }
    }
}
