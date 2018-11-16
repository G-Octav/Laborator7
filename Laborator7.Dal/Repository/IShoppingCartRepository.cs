using Laborator7.Domain.ShoppingCart;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator7.Dal.Repository
{
    interface IShoppingCartRepository
    {
        IEnumerable<ShoppingCart> GetAllShoppingCarts();

        IEnumerable<ShoppingCart> GetShoppingCartById();
        

    }
}
