using Microsoft.AspNetCore.Mvc;
using Pryaniky_TestTask.Models;
using Pryaniky_TestTask.Services;

namespace Pryaniky_TestTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpPost("Create")]
        public Product Create([FromQuery] string name)
        {
            return _service.Create(name);
        }

        [HttpGet("Get")]
        public IEnumerable<Product> Get()
        {
            return _service.GetProducts();
        }

        [HttpPost("Remove")]
        public Product Remove([FromQuery] int id)
        {
            return _service.Remove(id);
        }
    }
}