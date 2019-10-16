using API.Entities;
using API.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Service
{
    public class BaseService<T> : IBaseService<T> where T : BaseEntity
    {
        private readonly IBaseRepository<T> _repository;

        public BaseService(IBaseRepository<T> repository)
        {
            _repository = repository;
        }
        
        public List<T> getAll()
        {
            return _repository.getAll();
        }

        public async Task<T> getById(int id)
        {
            return await _repository.getById(id);
        }

        public async Task<bool> Add(T entityClass)
        {
            return await _repository.Add(entityClass);
        }

        public async Task<bool> Update(T entityClass)
        {
            var exist = await getById(entityClass.Id);
            if (exist == null) return false;
            exist.Name = entityClass.Name;
            return await _repository.Update(exist);
        }

        public async Task<bool> Delete(int id)
        {
            var entityClass = await getById(id);
            if (entityClass == null) return false;
            return await _repository.Delete(entityClass);
        }

        public async Task<bool> Login(User entityClass)
        {
            var exist = await _repository.getUser(entityClass.Username);
            if (exist == null) return false;
            if (entityClass.Username == exist.Username && entityClass.Password == exist.Password) return true;
            else return false;
        }
    }
}
