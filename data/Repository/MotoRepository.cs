using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication4.data.interfaces;
using WebApplication4.data.models;

namespace WebApplication4.data.Repository
{
    public class MotoRepository : IAllMotos
    {
        private readonly AppDbContent appDbContent;
        public MotoRepository(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }
        public IEnumerable<moto> Motos => appDbContent.Moto.Include(c => c.Category);
        public IEnumerable<moto> getFavMotos => appDbContent.Moto.Where(p => p.isFavorite).Include(c => c.Category);

        public moto getObjectMoto(int motoId) => appDbContent.Moto.FirstOrDefault(p => p.id == motoId);
        
        
    }
}
