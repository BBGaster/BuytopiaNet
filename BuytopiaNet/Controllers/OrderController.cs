using Buytopia.BLL.Model;
using Buytopia.BLL.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Buytopia.PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        public OrderController(IOrderService service)
        {
            _service = service;
        }


        private readonly IOrderService _service;

        // GET: OrderController
        [HttpGet]
        public IEnumerable<OrderModel> Get()
        {
            return _service.GetAll().ToList();
        }

        // GET: OrderController/id
        [HttpGet("{id}")]
        public OrderModel GetById(int id)
        {
            return _service.GetById(id);
        }

        // POST: OrderController/
        [HttpPost]
        public bool Add([FromBody] OrderModel model)
        {
            return _service.Add(model);
        }


        // UPDATE: Non penso funzioni
        [HttpPut("{id}")]
        public bool Update([FromBody] OrderModel model)
        {
            return _service.Update(model);
        }

        // DELETE: OrderController/id
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _service.Delete(id);
        }

    }
}
