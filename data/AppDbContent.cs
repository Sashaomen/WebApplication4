using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.data.models;

namespace WebApplication4.data
{
    public class AppDbContent : DbContext
    {
        public AppDbContent(DbContextOptions<AppDbContent> options) : base(options) { }
        public DbSet<moto> Moto { get; set; }
        public DbSet<category> Category { get; set; }
    }
    
    
}
