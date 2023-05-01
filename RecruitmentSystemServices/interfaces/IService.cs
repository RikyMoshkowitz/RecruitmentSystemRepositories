using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentSystemServices.interfaces
{
     public interface IService<T>
    {
        Task<List<T>> GetAllAsync();
        Task<T> getById(int id);
    }
}
