using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication4.data.models;

namespace WebApplication4.data.interfaces
{
    public interface IMotosCategory
    {
        IEnumerable<category> AllCategories { get; }
    }
}
