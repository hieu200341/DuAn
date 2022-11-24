using _1.DAL.Models;
using System.Collections.Generic;
using System;

namespace _1.DAL.IRepositories
{
    public interface IsizeRepositories
    {
        List<size> GetSizeFromDB(); 
        bool addsize(size Size); 
        bool RemoveSize(size Size); 
        bool UpdateSize(size Size); 
    }
}
