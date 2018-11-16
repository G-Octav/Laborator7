using System.Collections.Generic;

namespace Laborator7.Dal.Repository
{
    public interface IShoppingCartRepository
    {
        IEnumerable<ShoppingCart> GetAllShoppingCarts();
    }
}
