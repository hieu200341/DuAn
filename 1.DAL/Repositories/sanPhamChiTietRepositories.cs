using _1.DAL.Context;
using _1.DAL.IRepositories;
using _1.DAL.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace _1.DAL.Repositories
{
    public class sanPhamChiTietRepositories : IsanPhamChiTietRepositories
    {
        DatabaseContext DbContext;
        public sanPhamChiTietRepositories(DatabaseContext DbContext)
        {
            this.DbContext = DbContext;
        }
        public bool addsanPhamChiTiet(sanPhamChiTiet SanPhamChiTiet)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<sanPhamChiTiet> GetAll()
        {
            return DbContext.sanPhamChiTiets.ToList();
        }
        public sanPhamChiTiet GetById(Guid id)
        {
            var SanPhamChiTiet = DbContext.Sanphams.Find(id);
            // Find(param) chỉ dùng với id của sản phẩm
            var sanPhamChiTiet2 = DbContext.sanPhamChiTiets.
                FirstOrDefault(p => p.IdPhamChiTiet == id);
            return sanPhamChiTiet2; // sanpham2

        }
        public bool RemoveSanPhamChiTiet(sanPhamChiTiet SanPhamChiTiet) // Xóa sản phẩm
        {
            try
            {
                DbContext.sanPhamChiTiets.Remove(SanPhamChiTiet);
                DbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool UpdateSanPhamChiTiet(sanPhamChiTiet SanPhamChiTiet)
        {
            try
            {
                DbContext.sanPhamChiTiets.Update(SanPhamChiTiet);
                DbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        List<sanPhamChiTiet> IsanPhamChiTietRepositories.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
