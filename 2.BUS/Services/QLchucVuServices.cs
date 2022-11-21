using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class QLchucVuServices : IQLchucVuServices
    {
        private IchucVuRepositories _chucVu;
        private List<chucVu> _lstchucVu;

        public QLchucVuServices()
        {
            _lstchucVu = new List<chucVu>();
            _chucVu = new chucVuRepositories();
        }

        public bool addChucVu(chucVu ChucVu)
        {
            _chucVu.addChucVu(ChucVu);
            return true;
        }

        public bool RemoveChucVu(chucVu ChucVu)
        {
            _chucVu.RemoveChucVu(ChucVu);
            return true;
        }

        public List<chucVu> GetchucVuFromDB()
        {
            _lstchucVu = _chucVu.GetchucVuFromDB();
            return _lstchucVu;
        }

        public bool UpdateChucVu(chucVu ChucVu)
        {
            _chucVu.UpdateChucVu(ChucVu);
            return true;
        }
    }
}
