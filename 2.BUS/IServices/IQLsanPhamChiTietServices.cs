using _1.DAL.Models;
using _2.BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLsanPhamChiTietServices
    {
        List<sanPhamChiTiet> GetSanPhamCTTFromDB();
        bool addsanPham(sanPhamChiTiet sanPhamCT);
        bool RemoveSanPham(sanPhamChiTiet sanPhamCT);
        bool UpdateSanPham(sanPhamChiTiet sanPhamCT);
        List<ViewHienThi1> getViewSanPhamCT();
    }
}
