using System.Collections.Generic;
using Laborator7.Dto.Product;
using Laborator7.Dto.ShoppingCart;
using Microsoft.AspNetCore.Mvc;

namespace Laborator7.Controllers
{
    [Route("api/[controller]")]
    public class ShoppingCartController : Controller
    {
        [HttpGet]
        public IList<ShoppingCartDto> Get()
        {
        }

        [HttpGet]
        [Route("api/[controller]/product/{id}")]
        public ProductDto GetProductInShoppingcart()
        {

        }

        [HttpGet]
        [Route("api/[controller]/{id}/products")]
        public ProductDto GetAllProductsInShoppingcart()
        {

        }
    }
}
