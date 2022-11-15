using System.Collections.Generic;
using System;
using System.Linq;
using _1.DAL.Context;
using _1.DAL.IRepositories;
using _1.DAL.Models;

namespace _1.DAL.Repositories
{
    public class hangSXRepositories: IhangSXRepositories
    {
        DatabaseContext DbContext;
        public hangSXRepositories(DatabaseContext DbContext)
        {
            this.DbContext = DbContext;
        }
        public bool addHangSX(hangSX HangSX)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<hangSX> GetAll()
        {
            return DbContext.hangSXes.ToList();
        }
        public hangSX GetById(Guid id)
        {
            var hangsx = DbContext.hangSXes.Find(id);
            // Find(param) chỉ dùng với id của sản phẩm
            var hangSX2 = DbContext.hangSXes.
                FirstOrDefault(p => p.IdHangSX == id);
            return hangSX2; // sanpham2

        }
        public bool RemoveHangSX(hangSX HangSX) // Xóa sản phẩm
        {
            try
            {
                DbContext.hangSXes.Remove(HangSX);
                DbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool UpdateHangSX(hangSX HangSX)
        {
            try
            {
                DbContext.hangSXes.Update(HangSX);
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
