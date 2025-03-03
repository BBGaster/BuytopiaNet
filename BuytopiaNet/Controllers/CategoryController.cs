using Buytopia.BLL.Model;
using Buytopia.BLL.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Buytopia.PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        public CategoryController(ICategoryService service)
        {
            _service = service;
        }


        private readonly ICategoryService _service;

        // GET: CategoryController
        [HttpGet]
        public IEnumerable<CategoryModel> Get()
        {
            return _service.GetAll().ToList();
        }

        // GET: CategoryController/id
        [HttpGet("{id}")]
        public CategoryModel GetById(int id)
        {
            return _service.GetById(id);
        }

        // POST: CategoryController/
        [HttpPost]
        public bool Add([FromBody] CategoryModel model)
        {
            return _service.Add(model);
        }


        // UPDATE: Non penso funzioni
        [HttpPut("{id}")]
        public bool Update([FromBody] CategoryModel model)
        {
            return _service.Update(model);
        }

        // DELETE: CategoryController/id
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _service.Delete(id);
        }

    }
}
