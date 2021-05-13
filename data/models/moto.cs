using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication4.data.models
{
    public class moto
    {
        public int id { set; get; } //ID товара
        public string name { set; get; } //имя товара
        public string shortDesc { set; get; } //краткое описание товара
        public string longDesc { set; get; } //полное описание товара
        public string img { set; get; } //изображение товара
        public ushort price { set; get; } //стоимоть товара
        public bool isFavorite { set; get; } //отображдение на главной странице в блоке лучшие товары
        public bool available { set; get; }
        public int categoryID { set; get; } 
        public virtual Category Category { set; get; } //к какой категории относится товар
    }
}
