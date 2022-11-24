using _1.DAL.Models;
using System.Collections.Generic;
using System;

namespace _1.DAL.IRepositories
{
    public interface ImauSacRepositories
    {
        List<mauSac> GetMauSacFromDB(); 
        bool addMauSac(mauSac MauSac); 
        bool RemoveMauSac(mauSac MauSac); 
        bool UpdateMauSac(mauSac MauSac); 
    }
}
