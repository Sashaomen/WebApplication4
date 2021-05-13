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
        public IEnumerable<category> AllCategories
        {
            get
            {
                return new List<category>
                {
                    new category {categoryName = "ЭлектроМотоциклы", desc = "Современный вид транспорта"},
                    new category {categoryName = "Классические мотоциклы", desc = "Мотоциклы с двигателем внутреннего сгорания"}
                };
            }
                
                } //=> throw new NotImplementedException();
    }
}
