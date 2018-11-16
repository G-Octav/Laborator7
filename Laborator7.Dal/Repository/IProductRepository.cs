using Laborator7.Domain.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator7.Dal.Repository
{
    interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();

        IEnumerable<Product> GetProductById();
    }
}
