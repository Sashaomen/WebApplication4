using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication4.data.interfaces;
using WebApplication4.data.models;

namespace WebApplication4.data.Mocks
{
    public class MockCategory : IMotosCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {categoryName = "ЭлектроМотоциклы", desc = "Современный вид транспорта"},
                    new Category {categoryName = "Классические мотоциклы", desc = "Мотоциклы с двигателем внутреннего сгорания"}
                };
            }
                
                } //=> throw new NotImplementedException();
    }
}
