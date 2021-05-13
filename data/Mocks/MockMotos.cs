using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication4.data.interfaces;
using WebApplication4.data.models;

namespace WebApplication4.data.Mocks
{
    public class MockMotos : IAllMotos
    {
        private readonly IMotosCategory _categoryMotos = new MockCategory();
        public IEnumerable<moto> Motos {
            get
            {
                return new List<moto>
                {
                    new moto {
                        name = "Emoto",
                        shortDesc ="ЭлектроЭндуро",
                        longDesc ="ЭлетроЭндуро с запасом хода на 100км",
                        img="/img/emoto.jpg",
                        price = 45000,
                        isFavorite = true,
                        available = true,
                        Category = _categoryMotos.AllCategories.First()
                    },
                     new moto {
                        name = "Djebel",
                        shortDesc ="Легенда Японского мотопрома",
                        longDesc ="Легендарный, надёжный Японский Эндуро",
                        img="/img/djebel.jpg",
                        price = 24500,
                        isFavorite = false,
                        available = true,
                        Category = _categoryMotos.AllCategories.Last()
                     },
                       new moto {
                        name = "TDM",
                        shortDesc ="Турист",
                        longDesc ="Легендарный, надёжный Японский Турист",
                        img="/img/TDM.jpg",
                        price = 45500,
                        isFavorite = true,
                        available = true,
                        Category = _categoryMotos.AllCategories.Last()
                     },
                       new moto {
                        name = "Serow",
                        shortDesc ="Ещё одна легенда",
                        longDesc ="Легендарный, надёжный Японский Эндуро",
                        img="/img/serow.jpg",
                        price = 30500,
                        isFavorite = true,
                        available = true,
                        Category = _categoryMotos.AllCategories.Last()
                     },
            };
               
            }
        }
        public IEnumerable<moto> getFavMotos { get; set; }

        public moto getObjectMoto(int motoId)
        {
            throw new NotImplementedException();
        }
    }
}
