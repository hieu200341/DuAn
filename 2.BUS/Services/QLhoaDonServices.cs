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
        private List<hoaDon> _lsthoaDon;
        private IkhachHangRepositories _khachHangRE;
        private InhanVienRepositories _inhanVienRE;

        public QLhoaDonServices()
        {
            _lsthoaDon = new List<hoaDon>();
            _hoaDon = new hoaDonRepositories();
            _inhanVienRE = new nhanVienRepositories();
            _khachHangRE = new khachHangRepositories();
        }

        public string addHoaDon(ViewHienThi1 HoaDon)
        {
            if (HoaDon == null) return "Thêm thất bại";
            var hd = HoaDon.hoaDons;
            if (_hoaDon.addHoaDon(hd)) return "Thêm thành công";
            return "Thêm thất bại";
            
        }

        public List<ViewHienThi1> GetHoaDonFromDB()
        {
            List<ViewHienThi1> list = new List<ViewHienThi1>();
            list = (from a in _hoaDon.GetHoaDonFromDB()
                    join b in _inhanVienRE.GetNhanVienFromDB() on a.maNhanVien equals b.maNhanVien
                    join c in _khachHangRE.GetkhachHangFromDB() on a.SDT_KH equals c.SDT_KH
                    select new ViewHienThi1()
                    {
                        hoaDons = a,
                        nhanViens = b,
                        khachHangs = c,
                    }).ToList();
            return list;
        }

        public string RemoveHoaDon(ViewHienThi1 HoaDon)
        {
            if (HoaDon == null) return "Xóa thất bại";
            var nvv = HoaDon.hoaDons;
            if (_hoaDon.RemoveHoaDon(nvv)) return "Xóa thành công";
            return "Xóa thất bại";
        }

        public string UpdateHoaDon(ViewHienThi1 HoaDon)
        {
            if (HoaDon == null) return "Sửa thất bại";
            var nvv = HoaDon.hoaDons;
            if (_hoaDon.UpdateHoaDon(nvv)) return "Sửa thành công";
            return "Sửa thất bại";
        }

        //public bool addHoaDon(hoaDon HoaDon)
        //{
        //    _hoaDon.addHoaDon(HoaDon);
        //    return true;
        //}

        //public bool RemoveHoaDon(hoaDon HoaDon)
        //{
        //    _hoaDon.RemoveHoaDon(HoaDon);
        //    return true;
        //}

        //public List<hoaDon> GetHoaDonFromDB()
        //{
        //    _lsthoaDon = _hoaDon.GetHoaDonFromDB();
        //    return _lsthoaDon;
        //}

        //public bool UpdateHoaDon(hoaDon HoaDon)
        //{
        //    _hoaDon.UpdateHoaDon(HoaDon);
        //    return true;
        //}
    }
}
