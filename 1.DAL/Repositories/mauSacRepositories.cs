using _1.DAL.Context;
using _1.DAL.IRepositories;
using _1.DAL.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace _1.DAL.Repositories
{
    public class mauSacRepositories: ImauSacRepositories
    {
        DatabaseContext DbContext;
        public mauSacRepositories(DatabaseContext DbContext)
        {
            this.DbContext = DbContext;
        }
        public bool addMauSac(mauSac MauSac)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<mauSac> GetAll()
        {
            return DbContext.mauSacs.ToList();
        }
        public mauSac GetById(Guid id)
        {
            var MauSac = DbContext.mauSacs.Find(id);
            // Find(param) chỉ dùng với id của sản phẩm
            var mauSac2 = DbContext.mauSacs.
                FirstOrDefault(p => p.IdMauSac == id);
            return mauSac2; // sanpham2

        }
        public bool RemoveMauSac(mauSac MauSac) // Xóa sản phẩm
        {
            try
            {
                DbContext.mauSacs.Remove(MauSac);
                DbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool UpdateMauSac(mauSac MauSac)
        {
            try
            {
                DbContext.mauSacs.Update(MauSac);
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
