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
        List<ViewHienThi1> GetNhanVienFromDB();
        string addNhanVien(ViewHienThi1 NhanVien);
        string RemoveNhanVien(ViewHienThi1 NhanVien);
        string UpdateNhanVien(ViewHienThi1 NhanVien);
        //List<ViewHienThi> getViewNhanVien();
        List<nhanVien> GetAll();
    }
}
