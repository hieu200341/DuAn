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
    public class QLsanPhamServices : IQLsanPhamServices
    {
        private IsanPhamRepositories _sanPham;
        private List<SanPham> _lstsanPham;
        private IQLsizeServices _qLsizeServices;
        private IQLmauSacServices _qLmauSacServices;
        private IQLhangSXServices _qLhangSXServices;
        private List<ViewHienThi> _lstView;
        public QLsanPhamServices()
        {
            _lstsanPham = new List<SanPham>();
            _sanPham = new sanPhamRepositories();
            _lstView = new List<ViewHienThi>();
            _qLhangSXServices = new QLhangSXServices();
            _qLmauSacServices= new QLmauSacServices();
            _qLsizeServices= new QLsizeServices();
            GetSanPhamFromDB();
        }

        public bool addsanPham(SanPham sanPham)
        {
            _sanPham.addsanPham(sanPham);
            return true;
        }

        public bool RemoveSanPham(SanPham sanPham)
        {
            _sanPham.RemoveSanPham(sanPham);
            return true;
        }

        public List<SanPham> GetSanPhamFromDB()
        {
            _lstsanPham = _sanPham.GetSanPhamFromDB();
            return _lstsanPham;
        }

        public bool UpdateSanPham(SanPham sanPham)
        {
            _sanPham.UpdateSanPham(sanPham);
            return true;
        }
        public List<ViewHienThi> getViewSanPham()
        {
            _lstView = (from a in GetSanPhamFromDB()
                        join b in _qLmauSacServices.GetMauSacFromDB() on a.maSanPham equals b.maMauSac
                        join c in _qLhangSXServices.GetHangSXFromDB() on a.maSanPham equals c.maHangSX
                        join d in _qLsizeServices.GetSizeFromDB() on a.maSanPham equals d.maSize
                        select new ViewHienThi { SanPhams = a, mauSacs = b, hangSXs = c, sizes = d }).ToList();
            return _lstView;
        }
    }
}
