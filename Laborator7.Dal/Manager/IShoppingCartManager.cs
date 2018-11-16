using System.Collections.Generic;
using Laborator7.Dto.ShoppingCart;

namespace Laborator7.Dal.Manager
{
    public interface IShoppingCartManager
    {
        IList<ShoppingCartDto> GetAllShoppingCarts();
    }
}