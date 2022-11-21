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
        List<sanPham> GetSanPhamFromDB();
        bool addSanPham(sanPham Sanpham);
        bool RemoveSanpham(sanPham Sanpham);
        bool UpdateSanpham(sanPham Sanpham);
    }
}
