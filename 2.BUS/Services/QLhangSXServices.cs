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
    public class QLhangSXServices : IQLhangSXServices
    {
        private IhangSXRepositories _hangSX;
        private List<hangSX> _lsthangSX;

        public QLhangSXServices()
        {
            _lsthangSX = new List<hangSX>();
           _hangSX = new hangSXRepositories();
        }

        public bool addHangSX(hangSX HangSX)
        {
            _hangSX.addHangSX(HangSX);
            return true;
        }

        public bool RemoveHangSX(hangSX HangSX)
        {
            _hangSX.RemoveHangSX(HangSX);
            return true;
        }

        public List<hangSX> GetHangSXFromDB()
        {
            _lsthangSX = _hangSX.GetHangSXFromDB();
            return _lsthangSX;
        }

        public bool UpdateHangSX(hangSX HangSX)
        {
            _hangSX.UpdateHangSX(HangSX);
            return true;
        }
    }
}
