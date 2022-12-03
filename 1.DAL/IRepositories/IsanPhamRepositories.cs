using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IsanPhamRepositories
    {
        List<sanPham1> GetsanPhamFromDB();
        bool addsanPham(sanPham1 SanPham);
        bool RemovesanPham(sanPham1 SanPham);
        bool UpdatesanPham(sanPham1 SanPham);
    }
}
