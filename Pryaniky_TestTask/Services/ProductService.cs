using dbo = EntityFramework.Entity;
using EntityFramework.Repository;
using Pryaniky_TestTask.Models;
using System.Linq;

namespace Pryaniky_TestTask.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<dbo.Product> _repository;

        public ProductService(IRepository<dbo.Product> repository)
        {
            _repository = repository;
        }

        public Product Create(string name)
        {
            return Convert(
                _repository.Create(new dbo.Product
                {
                    Name = name
                })
            );
        }

        public IEnumerable<Product> GetProducts()
        {
            return _repository.All.ToList().ConvertAll(Convert);
        }

        public Product Remove(int id)
        {
            return Convert(_repository.Remove(id));
        }

        private Product Convert(dbo.Product product)
        {
            return new Product
            {
                Id = product.Id,
                Name = product.Name,
            };
        }
    }
}
