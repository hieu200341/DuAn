using _1.DAL.Context;
using _1.DAL.IRepositories;
using _1.DAL.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace _1.DAL.Repositories
{
    public class sizeRepositories : IsizeRepositories
    {
        DatabaseContext DbContext;
        public sizeRepositories(DatabaseContext DbContext)
        {
            this.DbContext = DbContext;
        }
        public bool addsize(size Size)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<size> GetAll()
        {
            return DbContext.Sizes.ToList();
        }
        public size GetById(Guid id)
        {
            var Size = DbContext.Sizes.Find(id);
            // Find(param) chỉ dùng với id của sản phẩm
            var Size1 = DbContext.Sizes.
                FirstOrDefault(p => p.IdSize == id);
            return Size; // sanpham2

        }
        public bool RemoveSize(size Size) // Xóa sản phẩm
        {
            try
            {
                DbContext.Sizes.Remove(Size);
                DbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool UpdateSize(size Size)
        {
            try
            {
                DbContext.Sizes.Update(Size);
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
