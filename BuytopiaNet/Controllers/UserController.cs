using Buytopia.BLL.Model;
using Buytopia.BLL.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Buytopia.PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserController(IUserService service)
        {
            _service = service;
        }


        private readonly IUserService _service;

        // GET: UserController
        [HttpGet]
        public IEnumerable<UserModel> Get()
        {
            return _service.GetAll().ToList();
        }

        // GET: UserController/id
        [HttpGet("{id}")]
        public UserModel GetById(int id)
        {
            return _service.GetById(id);
        }

        // POST: UserController/
        [HttpPost]
        public bool Add([FromBody] UserModel model)
        {
            return _service.Add(model);
        }


        // UPDATE: Non penso funzioni
        [HttpPut("{id}")]
        public bool Update([FromBody] UserModel model)
        {
            return _service.Update(model);
        }

        // DELETE: UserController/id
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _service.Delete(id);
        }

    }
}
