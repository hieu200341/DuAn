using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLsizeServices
    {
        List<size> GetSizeFromDB();
        bool addsize(size Size);
        bool RemoveSize(size Size);
        bool UpdateSize(size Size);
    }
}
