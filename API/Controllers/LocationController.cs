using System.Collections.Generic;
using System.Threading.Tasks;
using API.Entities;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class LocationController : Controller
    {
        private readonly IBaseService<Location> _service;

        public LocationController(IBaseService<Location> service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Location> Get()
        {
            return _service.getAll();
        }

        [HttpGet("{id}")]
        public async Task<Location> Get(int id)
        {
            return await _service.getById(id);
        }

        [HttpPost]
        public async Task<bool> Post([FromBody]Location location)
        {
            return await _service.Add(location);
        }

        [HttpPut("{id}")]
        public async Task<bool> Put([FromBody]Location location)
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
