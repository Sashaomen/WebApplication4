using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication4.data.models;

namespace WebApplication4.ViewModels
{
    public class MotosListViewModel
    {
        public IEnumerable<moto> allMotos { get; set; }
        public string currCategory { get; set; }
    }
}
