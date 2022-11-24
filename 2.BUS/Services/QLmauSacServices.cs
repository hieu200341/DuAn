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
    public class QLmauSacServices : IQLmauSacServices
    {
        private ImauSacRepositories _mauSac;
        private List<mauSac> _lstmauSac;

        public QLmauSacServices()
        {
            _lstmauSac = new List<mauSac>();
            _mauSac = new mauSacRepositories();
        }

        public bool addMauSac(mauSac MauSac)
        {
            _mauSac.addMauSac(MauSac);
            return true;
        }

        public bool RemoveMauSac(mauSac MauSac)
        {
            _mauSac.RemoveMauSac(MauSac);
            return true;
        }

        public List<mauSac> GetMauSacFromDB()
        {
            _lstmauSac = _mauSac.GetMauSacFromDB();
            return _lstmauSac;
        }

        public bool UpdateMauSac(mauSac MauSac)
        {
            _mauSac.UpdateMauSac(MauSac);
            return true;
        }
    }
}
