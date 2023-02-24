using Pryaniky_TestTask.Models;

namespace Pryaniky_TestTask.Services
{
    public interface IProductService
    {
        public IEnumerable<Product> GetProducts();
        public Product Create(string name);
        public Product Remove(int id);
    }
}
