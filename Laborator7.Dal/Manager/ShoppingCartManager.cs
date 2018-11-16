using System.Collections.Generic;
using Laborator7.Dal.Repository;
using Laborator7.Dto.ShoppingCart;

namespace Laborator7.Dal.Manager
{
    public class ShoppingCartManager : IShoppingCartManager
    {
        private IShoppingCartRepository _repository;

        public ShoppingCartManager(IShoppingCartRepository repository)
        {
            _repository = repository;
        }

        public IList<ShoppingCartDto> GetAllShoppingCarts()
        {
            return _repository.GetAllShoppingCarts();
        }
    }
}