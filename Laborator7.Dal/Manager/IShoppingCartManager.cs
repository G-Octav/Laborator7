using System.Collections.Generic;
using Laborator7.Dal.Repository;
using Laborator7.Dto.ShoppingCart;

namespace Laborator7.Dal.Manager
{
    public interface IShoppingCartManager
    {
        IList<ShoppingCartDto> GetAllShoppingCarts();
    }
}