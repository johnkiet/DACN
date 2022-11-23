﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDotNetV2.Data.Entities
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Product Product{ get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
