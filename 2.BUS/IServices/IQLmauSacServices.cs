using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLmauSacServices
    {
        List<mauSac> GetMauSacFromDB();
        bool addMauSac(mauSac MauSac);
        bool RemoveMauSac(mauSac MauSac);
        bool UpdateMauSac(mauSac MauSac);
    }
}
