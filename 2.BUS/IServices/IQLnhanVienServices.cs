using _1.DAL.Models;
using _2.BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLnhanVienServices
    {
        List<nhanVien> GetNhanVienFromDB();
        bool addNhanVien(nhanVien NhanVien);
        bool RemoveNhanVien(nhanVien NhanVien);
        bool UpdateNhanVien(nhanVien NhanVien);
        List<ViewHienThi> getViewNhanVien();
    }
}
