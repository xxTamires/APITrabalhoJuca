using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface IBaseService<T> where T : BaseEntity
    {
        List<T> getAll();
        Task<T> getById(int id);
        Task<bool> Add(T entityClass);
        Task<bool> Update(T entityClass);
        Task<bool> Delete(int id);
    }
}
