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
        DatabaseContext DbContext;
        public nhanVienRepositories(DatabaseContext DbContext)
        {
            this.DbContext = DbContext;
        }
        public bool addNhanVien(nhanVien NhanVien)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<nhanVien> GetAll()
        {
            return DbContext.nhanViens.ToList();
        }
        public nhanVien GetById(Guid id)
        {
            var nhanvien = DbContext.nhanViens.Find(id);
            // Find(param) chỉ dùng với id của sản phẩm
            var nhanVien2 = DbContext.nhanViens.
                FirstOrDefault(p => p.IdNV == id);
            return nhanVien2; // sanpham2

        }
        public bool RemoveNhanVien(nhanVien NhanVien) // Xóa sản phẩm
        {
            try
            {
                DbContext.nhanViens.Remove(NhanVien);
                DbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool UpdateNhanVien(nhanVien NhanVien)
        {
            try
            {
                DbContext.nhanViens.Update(NhanVien);
                DbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        List<nhanVien> InhanVienRepositories.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
