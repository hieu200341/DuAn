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
        List<SanPham> GetSanPhamChiTietFromDB();
        bool addsanPhamChiTiet(SanPham SanPhamChiTiet);
        bool RemoveSanPhamChiTiet(SanPham SanPhamChiTiet);
        bool UpdateSanPhamChiTiet(SanPham SanPhamChiTiet);
    }
}
