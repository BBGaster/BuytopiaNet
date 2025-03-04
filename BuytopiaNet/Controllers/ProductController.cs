using Buytopia.BLL.Model;
using Buytopia.BLL.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Buytopia.PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public ProductController(IProductService service)
        {
            _service = service;
        }

        private readonly IProductService _service;

        // GET: ProductController
        [HttpGet]
        public IEnumerable<ProductModel> Get()
        {
            return _service.GetAll().ToList();
        }

        // GET: ProductController/id
        [HttpGet("{id}")]
        public ProductModel GetById(int id)
        {
            return _service.GetById(id);
        }

        // POST: ProductController/
        [HttpPost]
        public bool Add([FromBody] ProductModel model)
        {
            return _service.Add(model);
        }


        // UPDATE: Non penso funzioni
        [HttpPut("{id}")]
        public bool Update([FromBody] ProductModel model)
        {
            return _service.Update(model);
        }

        // DELETE: ProductController/id
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _service.Delete(id);
        }

    }
}
