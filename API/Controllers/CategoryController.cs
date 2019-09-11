using API.Entities;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IBaseService<Category> _service;

        [HttpGet]
        public List<Category> Get()
        {
            return _service.getAll();
        }

        [HttpGet("{id}")]
        public async Task<Category> Get(int id)
        {
            return await _service.getById(id);
        }

        [HttpPost]
        public async Task<bool> Post([FromBody]Category location)
        {
            return await _service.Add(location);
        }

        [HttpPut("{id}")]
        public async Task<bool> Put([FromBody]Category location)
        {
            return await _service.Update(location);
        }

        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _service.Delete(id);
        }
    }
}
