using _1.DAL.Models;
using _2.BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLsanPhamServices
    {
        List<SanPham> GetSanPhamFromDB();
        bool addsanPham(SanPham sanPham);
        bool RemoveSanPham(SanPham sanPham);
        bool UpdateSanPham(SanPham sanPham);
        List<ViewHienThi1> getViewSanPham();
    }
}
