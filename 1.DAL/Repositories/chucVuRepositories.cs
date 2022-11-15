using _1.DAL.Context;
using _1.DAL.Models;
using System.Collections.Generic;
using System;
using System.Linq;
using _1.DAL.IRepositories;

namespace _1.DAL.Repositories
{
    public class chucVuRepositories: IchucVuRepositories
    {
        DatabaseContext DbContext;
        public chucVuRepositories(DatabaseContext DbContext)
        {
            this.DbContext = DbContext;
        }
        public bool addChucVu(chucVu ChucVu)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<chucVu> GetAll()
        {
            return DbContext.chucVus.ToList();
        }
        public chucVu GetById(Guid id)
        {
            var chucvu = DbContext.chucVus.Find(id);
            // Find(param) chỉ dùng với id của sản phẩm
            var chucVu2 = DbContext.chucVus.
                FirstOrDefault(p => p.IDchucVu == id);
            return chucVu2; // sanpham2

        }
        public bool RemoveChucVu(chucVu ChucVu) // Xóa sản phẩm
        {
            try
            {
                DbContext.chucVus.Remove(ChucVu);
                DbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool UpdateChucVu(chucVu ChucVu)
        {
            try
            {
                DbContext.chucVus.Update(ChucVu);
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
