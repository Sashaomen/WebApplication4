using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication4.data.interfaces;
using WebApplication4.data.models;

namespace WebApplication4.data.Repository
{
    public class CategoryRepository : IMotosCategory
    {
        private readonly AppDbContent appDbContent;
        public CategoryRepository(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }
        public IEnumerable<Category> AllCategories => appDbContent.Category;
    }
}
