using _1.DAL.Models;
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
        bool addsanPham(SanPham SanPhamChiTiet);
        bool RemoveSanPham(SanPham SanPhamChiTiet);
        bool UpdateSanPham(SanPham SanPhamChiTiet);
    }
}
