using _1.DAL.Models;
using System.Collections.Generic;
using System;

namespace _1.DAL.IRepositories
{
    public interface InhanVienRepositories
    {
        List<nhanVien> GetNhanVienFromDB(); 
        bool addNhanVien(nhanVien NhanVien); 
        bool RemoveNhanVien(nhanVien NhanVien); 
        bool UpdateNhanVien(nhanVien NhanVien); 
    }
}
