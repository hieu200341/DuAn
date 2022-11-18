using _1.DAL.Context;
using _1.DAL.IRepositories;
using _1.DAL.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace _1.DAL.Repositories
{
    public class hoaDonRepositories: IhoaDonRepositories
    {
        DatabaseContext DbContext;
        public hoaDonRepositories(DatabaseContext DbContext)
        {
            this.DbContext = DbContext;
        }
        public bool addHoaDon(hoaDon HoaDon)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<hoaDon> GetAll()
        {
            return DbContext.hoaDons.ToList();
        }
        public hoaDon GetById(Guid id)
        {
            var hoadon = DbContext.hoaDons.Find(id);
            // Find(param) chỉ dùng với id của sản phẩm
            var hoaDon2 = DbContext.hoaDons.
                FirstOrDefault(p => p.IdHD == id);
            return hoaDon2; // sanpham2

        }
        public bool RemoveHoaDon(hoaDon HoaDon) // Xóa sản phẩm
        {
            try
            {
                DbContext.hoaDons.Remove(HoaDon);
                DbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool UpdateHoaDon(hoaDon HoaDon)
        {
            try
            {
                DbContext.hoaDons.Update(HoaDon);
                DbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        List<hoaDon> IhoaDonRepositories.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
