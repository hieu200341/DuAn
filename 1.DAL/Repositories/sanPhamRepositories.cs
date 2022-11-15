using _1.DAL.Context;
using _1.DAL.IRepositories;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.DAL.Repositories
{
    public class sanPhamRepositories : IsanPhamRepositories
    {
        DatabaseContext DbContext;
        public sanPhamRepositories(DatabaseContext DbContext)
        { 
            this.DbContext = DbContext;
        }
        public bool addSanPham(sanPham sanPham)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<sanPham> GetAll()
        {
            return DbContext.Sanphams.ToList();
        }
        public sanPham GetById(Guid id)
        {
            var sanpham = DbContext.Sanphams.Find(id);
            // Find(param) chỉ dùng với id của sản phẩm
            var sanpham2 = DbContext.Sanphams.
                FirstOrDefault(p => p.IdSP == id);
            return sanpham; // sanpham2

        }
        public bool RemoveSanpham(sanPham sanpham) // Xóa sản phẩm
        {
            try
            {
                DbContext.Sanphams.Remove(sanpham);
                DbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool UpdateSanpham(sanPham sanpham)
        {
            try
            {
                DbContext.Sanphams.Update(sanpham);
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
