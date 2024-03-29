﻿using Abc.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abc.Northwind.MvcWebUI.Services
{
    public interface ICartSessionService
    {
        Cart GetCart(); // Session 'ı okuyacak.
        void SetCart(Cart cart); // Session 'a yazmak.
    }
}
