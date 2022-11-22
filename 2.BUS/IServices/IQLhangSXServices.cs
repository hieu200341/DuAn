using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLhangSXServices
    {
        List<hangSX> GetHangSXFromDB();
        bool addHangSX(hangSX HangSX);
        bool RemoveHangSX(hangSX HangSX);
        bool UpdateHangSX(hangSX HangSX);
    }
}
