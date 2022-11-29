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
    public class QLnhanVienServices : IQLnhanVienServices
    {
        private InhanVienRepositories _nhanVien;
        private List<nhanVien> _lstnhanVien;
        private IQLchucVuServices _qlchucVu;
        private List<ViewHienThi> _lstViewNV;
        public QLnhanVienServices()
        {
            _lstnhanVien = new List<nhanVien>();
            _nhanVien = new nhanVienRepositories();
            _qlchucVu= new QLchucVuServices();
            _lstViewNV = new List<ViewHienThi>();
            GetNhanVienFromDB();
        }

        public bool addNhanVien(nhanVien NhanVien)
        {
            _nhanVien.addNhanVien(NhanVien);
            return true;
        }

        public bool RemoveNhanVien(nhanVien NhanVien)
        {
            _nhanVien.RemoveNhanVien(NhanVien);
            return true;
        }

        public List<nhanVien> GetNhanVienFromDB()
        {
            _lstnhanVien = _nhanVien.GetNhanVienFromDB();
            return _lstnhanVien;
        }

        public bool UpdateNhanVien(nhanVien NhanVien)
        {
            _nhanVien.UpdateNhanVien(NhanVien);
            return true;
        }
        public List<ViewHienThi> getViewNhanVien()
        {
            var _lstViewNV = (from a in _nhanVien.GetNhanVienFromDB()
                        join b in _qlchucVu.GetchucVuFromDB() on a.maNhanVien equals b.maChucVu
                        select new ViewHienThi { nhanViens = a, chucVus = b }).ToList();
            return _lstViewNV;
        }
       
    }
}
