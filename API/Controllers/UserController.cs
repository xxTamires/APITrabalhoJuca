using API.Entities;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IBaseService<User> _service;

        public UserController(IBaseService<User> service)
        {
            _service = service;
        }

        [HttpGet]
        public List<User> Get()
        {
            return _service.getAll();
        }

        [HttpGet("{id}")]
        public async Task<User> Get(int id)
        {
            return await _service.getById(id);
        }

        [HttpPost]
        public async Task<bool> Post([FromBody]User user)
        {
            return await _service.Add(user);
        }

        [HttpPut()]
        public async Task<bool> Put([FromBody]User user)
        {
            return await _service.Update(user);
        }

        [HttpPut("Login")]
        public async Task<bool> Login([FromBody]User user)
        {
            return await _service.Login(user);
        }

        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _service.Delete(id);
        }
    }
}
