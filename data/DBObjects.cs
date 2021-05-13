using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.data.models;

namespace WebApplication4.data
{
    public class DBObjects
    {
        public static void Initial(AppDbContent content) {
          //  AppDbContent content;
         //   using (var scope = app.ApplicationServices.CreateScope())
         //   {
           //     content = scope.ServiceProvider.GetRequiredService<AppDbContent>();
           // }
            

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));
            if (!content.Moto.Any())
            {
                content.AddRange(
                    new moto
                    {
                        name = "Emoto",
                        shortDesc = "ЭлектроЭндуро",
                        longDesc = "ЭлетроЭндуро с запасом хода на 100км",
                        img = "/img/emoto.jpg",
                        price = 45000,
                        isFavorite = true,
                        available = true,
                        Category = Categories["ЭлектроМотоциклы"]
                    },
                     new moto
                     {
                         name = "Djebel",
                         shortDesc = "Легенда Японского мотопрома",
                         longDesc = "Легендарный, надёжный Японский Эндуро",
                         img = "/img/djebel.jpg",
                         price = 24500,
                         isFavorite = false,
                         available = true,
                         Category = Categories["Классические мотоциклы"]
                     },
                       new moto
                       {
                           name = "TDM",
                           shortDesc = "Турист",
                           longDesc = "Легендарный, надёжный Японский Турист",
                           img = "/img/TDM.jpg",
                           price = 45500,
                           isFavorite = true,
                           available = true,
                           Category = Categories["Классические мотоциклы"]
                       },
                       new moto
                       {
                           name = "Serow",
                           shortDesc = "Ещё одна легенда",
                           longDesc = "Легендарный, надёжный Японский Эндуро",
                           img = "/img/serow.jpg",
                           price = 30500,
                           isFavorite = true,
                           available = true,
                           Category = Categories["Классические мотоциклы"]
                       }
                    );
            }
            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category {categoryName = "ЭлектроМотоциклы", desc = "Современный вид транспорта"},
                        new Category {categoryName = "Классические мотоциклы", desc = "Мотоциклы с двигателем внутреннего сгорания"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                   
                }
                return category;
            }
        }
    }

}
