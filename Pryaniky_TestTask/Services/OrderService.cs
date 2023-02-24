using EntityFramework.Repository;
using Microsoft.AspNetCore.Mvc;
using Pryaniky_TestTask.Models;
using dbo = EntityFramework.Entity;

namespace Pryaniky_TestTask.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<dbo.Order> _repository;
        private readonly IRepository<dbo.Product> _productRepository;

        public OrderService(IRepository<dbo.Order> repository, IRepository<dbo.Product> productRepostory)
        {
            _repository = repository;
            _productRepository = productRepostory;
        }

        public Order Create(int productId)
        {
            var product = _productRepository.FindById(productId);
            return Convert(
                _repository.Create(new dbo.Order
                {
                    CreatedDate = DateTime.Now,
                    Product = product
                })
            );
        }

        public IActionResult Remove(int id)
        {
            var removed = _repository.Remove(id);
            return removed != null ? new OkObjectResult(removed): new NotFoundResult();
        }

        public Order Convert(dbo.Order order)
        {
            return new Order
            {
                Id = order.Id,
                CreatedDate = order.CreatedDate
            };
        }
    }
}
