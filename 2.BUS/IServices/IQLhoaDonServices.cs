using _2.BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLhoaDonServices
    {
        List<ViewHienThi1> GetHoaDonFromDB();
        string addHoaDon(ViewHienThi1 HoaDon);
        string RemoveHoaDon(ViewHienThi1 HoaDon);
        string UpdateHoaDon(ViewHienThi1 HoaDon);
    }
}
