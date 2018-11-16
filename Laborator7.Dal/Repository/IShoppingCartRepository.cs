using System.Collections.Generic;
using Laborator7.Domain.ShoppingCart;

namespace Laborator7.Dal.Repository
{
    public interface IShoppingCartRepository
    {
        IEnumerable<ShoppingCart> GetAllShoppingCarts();
        IEnumerable<ShoppingCart> GetAllShoppingCartById();
    }
}
