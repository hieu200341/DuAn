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
        private List<chucVu> _lstChucVu;
        private DatabaseContext _context;
        public chucVuRepositories()
        {
            _lstChucVu = new List<chucVu>();
            _context = new DatabaseContext();
        }
        public bool addChucVu(chucVu ChucVu)
        {
            _context.Add(ChucVu);
            _context.SaveChanges();
            return true;
        }
        
        public bool RemoveChucVu(chucVu ChucVu) // Xóa sản phẩm
        {
            _context.Remove(ChucVu);
            _context.SaveChanges();
            return true;
        }
        public bool UpdateChucVu(chucVu ChucVu)
        {
            _context.Update(ChucVu);
            _context.SaveChanges();
            return true;
        }

        public List<chucVu> GetchucVuFromDB()
        {
            _lstChucVu = _context.chucVus.ToList();
            return _lstChucVu;
        }
    }
}
