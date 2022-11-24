using _1.DAL.Models;
using System.Collections.Generic;
using System;

namespace _1.DAL.IRepositories
{
    public interface IchucVuRepositories
    {
        List<chucVu> GetchucVuFromDB(); 
        bool addChucVu(chucVu ChucVu); 
        bool RemoveChucVu(chucVu ChucVu); 
        bool UpdateChucVu(chucVu ChucVu); 
    }
}
