﻿using _1.DAL.IRepositories;
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
    internal class QLhoaDonServices : IQLhoaDonServices
    {
        private IhoaDonRepositories _hoaDon;
        private List<hoaDon> _lsthoaDon;

        public QLhoaDonServices()
        {
            _lsthoaDon = new List<hoaDon>();
            _hoaDon = new hoaDonRepositories();
        }

        public bool addHoaDon(hoaDon HoaDon)
        {
            _hoaDon.addHoaDon(HoaDon);
            return true;
        }

        public bool RemoveHoaDon(hoaDon HoaDon)
        {
            _hoaDon.RemoveHoaDon(HoaDon);
            return true;
        }

        public List<hoaDon> GetHoaDonFromDB()
        {
            _lsthoaDon = _hoaDon.GetHoaDonFromDB();
            return _lsthoaDon;
        }

        public bool UpdateHoaDon(hoaDon HoaDon)
        {
            _hoaDon.UpdateHoaDon(HoaDon);
            return true;
        }
    }
}
