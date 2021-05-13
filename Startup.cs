using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.data;
using WebApplication4.data.interfaces;
using WebApplication4.data.Mocks;
using WebApplication4.data.Repository;

namespace WebApplication4
{
    public class Startup
    {
        private IConfigurationRoot _confString;
        public Startup(IWebHostEnvironment hostEnv)
        {
            _confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }
       public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContent>(Options => Options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
            services.AddTransient<IAllMotos, MotoRepository>();
            services.AddTransient<IMotosCategory, CategoryRepository>();
            services.AddMvc();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
               
            
        }
    }
}
