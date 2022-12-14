using MVC_Demo.Models;

namespace MVC_Demo
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
    }
}