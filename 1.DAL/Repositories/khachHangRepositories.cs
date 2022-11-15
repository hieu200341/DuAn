using _1.DAL.Context;
using _1.DAL.IRepositories;
using _1.DAL.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace _1.DAL.Repositories
{
    public class khachHangRepositories: IkhachHangRepositories
    {
        DatabaseContext DbContext;
        public khachHangRepositories(DatabaseContext DbContext)
        {
            this.DbContext = DbContext;
        }
        public bool addkhachHang(khachHang KhachHang)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<khachHang> GetAll()
        {
            return DbContext.khachHangs.ToList();
        }
        public khachHang GetById(Guid id)
        {
            var khachHang = DbContext.khachHangs.Find(id);
            // Find(param) chỉ dùng với id của sản phẩm
            var khachHang2 = DbContext.khachHangs.
                FirstOrDefault(p => p.IdKhachHang == id);
            return khachHang2; // sanpham2

        }
        public bool RemoveKhachHang(khachHang KhachHang) // Xóa sản phẩm
        {
            try
            {
                DbContext.khachHangs.Remove(KhachHang);
                DbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool UpdateKhachHang(khachHang KhachHang)
        {
            try
            {
                DbContext.khachHangs.Update(KhachHang);
                DbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
