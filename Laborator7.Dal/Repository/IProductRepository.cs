using Laborator7.Domain.Product;

namespace Laborator7.Dal.Repository
{
    interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();

        IEnumerable<Product> GetProductById();
    }
}
