using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pryaniky_TestTask.Models;
using Pryaniky_TestTask.Services;

namespace Pryaniky_TestTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _service;

        public OrderController(IOrderService service)
        {
            _service = service;
        }

        [HttpPost("Create")]
        public Order Create([FromQuery] int productId)
        {
            return _service.Create(productId);
        }

        [HttpPost("Remove")]
        public IActionResult Remove([FromQuery] int id)
        {
            return _service.Remove(id);
        }
    }
}
