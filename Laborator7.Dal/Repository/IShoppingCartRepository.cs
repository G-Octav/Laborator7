<<<<<<< HEAD
﻿using System.Collections.Generic;
=======
﻿using Laborator7.Domain.ShoppingCart;
using System;
using System.Collections.Generic;
using System.Text;
>>>>>>> 96021209575d520e1a2dd0b4b7af887eb8acb87b

namespace Laborator7.Dal.Repository
{
    public interface IShoppingCartRepository
    {
        IEnumerable<ShoppingCart> GetAllShoppingCarts();
<<<<<<< HEAD
=======

        IEnumerable<ShoppingCart> GetAllShoppingCartById();

>>>>>>> 96021209575d520e1a2dd0b4b7af887eb8acb87b
    }
}
