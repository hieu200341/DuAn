using _1.DAL.Context;
using _1.DAL.IRepositories;
using _1.DAL.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace _1.DAL.Repositories
{
    public class hoaDonChiTietRepositories: IhoaDonChiTietRepositories
    {
        DatabaseContext DbContext;
        public hoaDonChiTietRepositories(DatabaseContext DbContext)
        {
            this.DbContext = DbContext;
        }
        public bool addHoaDonChiTiet(hoaDonChiTiet HoaDonChiTiet)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<hoaDonChiTiet> GetAll()
        {
            return DbContext.hoaDonChiTiets.ToList();
        }
        public hoaDonChiTiet GetById(Guid id)
        {
            var hoadonchitiet = DbContext.hoaDonChiTiets.Find(id);
            // Find(param) chỉ dùng với id của sản phẩm
            var hoaDonChiTiet2 = DbContext.hoaDonChiTiets.
                FirstOrDefault(p => p.IdHD == id);
            return hoaDonChiTiet2; // sanpham2

        }
        public bool RemoveHoaDonChiTiet(hoaDonChiTiet HoaDonChiTiet) // Xóa sản phẩm
        {
            try
            {
                DbContext.hoaDonChiTiets.Remove(HoaDonChiTiet);
                DbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool UpdateHoaDonChiTiet(hoaDonChiTiet HoaDonChiTiet)
        {
            try
            {
                DbContext.hoaDonChiTiets.Update(HoaDonChiTiet);
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
