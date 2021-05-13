using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.data.models
{
    public class ShopCartItem
    {
        public int id { get; set; }
        public moto moto { get; set; }  
        public int price { get; set; }
        public string ShopCartId { get; set; }
    }
}
