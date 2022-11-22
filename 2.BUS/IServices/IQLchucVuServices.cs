using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLchucVuServices
    {
        List<chucVu> GetchucVuFromDB();
        bool addChucVu(chucVu ChucVu);
        bool RemoveChucVu(chucVu ChucVu);
        bool UpdateChucVu(chucVu ChucVu);
    }
}
