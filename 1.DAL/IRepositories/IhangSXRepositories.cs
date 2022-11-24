using _1.DAL.Models;
using System.Collections.Generic;
using System;

namespace _1.DAL.IRepositories
{
    public interface IhangSXRepositories
    {
        List<hangSX> GetHangSXFromDB(); 
        
        bool addHangSX(hangSX HangSX); 
        bool RemoveHangSX(hangSX HangSX); 
        bool UpdateHangSX(hangSX HangSX); 
    }
}
