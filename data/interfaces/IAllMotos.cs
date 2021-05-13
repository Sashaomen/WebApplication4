using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication4.data.models;

namespace WebApplication4.data.interfaces
{
    public interface IAllMotos
    {
        IEnumerable<moto> Motos { get; } //функция вывода товаров которые у нас есть
        IEnumerable<moto> getFavMotos { get; }
        moto getObjectMoto(int motoId);
    }
}
