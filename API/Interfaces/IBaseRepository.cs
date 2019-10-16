using API.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        List<T> getAll();
        Task<T> getById(int id);
        Task<bool> Add(T entityClass);
        Task<bool> Update(T entityClass);
        Task<bool> Delete(T entityClass);
        Task<bool> Add(Location entityClass);
        Task<User> getUser(string username);
    }
}
