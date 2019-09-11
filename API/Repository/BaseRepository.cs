using API.Data;
using API.Entities;
using API.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly DataContext _context;

        public BaseRepository(DataContext context)
        {
            _context = context;
        }

        public List<T> getAll()
        {
            return _context.Set<T>().ToList();
        }

        public async Task<T> getById(int id)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<bool> Add(T entityClass)
        {
            await _context.Set<T>().AddAsync(entityClass);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Add(Location entityClass)
        {
            await _context.Set<Location>().AddAsync(entityClass);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Update(T entityClass)
        {
            _context.Set<T>().Update(entityClass);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Delete(T entityClass)
        {
            _context.Set<T>().Remove(entityClass);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
