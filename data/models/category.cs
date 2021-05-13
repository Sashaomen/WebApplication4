using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.data.models
{
    public class category
    {
        public int id { set; get; }
        public string categoryName { set; get; } //имя категории
        public string desc { set; get; } //описание категории
        public List<moto> motos { set; get; } //товары в категории
    }
}
