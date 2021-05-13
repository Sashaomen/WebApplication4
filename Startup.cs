using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
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
using Microsoft.AspNetCore.Http;
using WebApplication4.data.models;
using static Microsoft.Extensions.Hosting.IHostEnvironment;

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
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => ShopCart.GetCart(sp));
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddMemoryCache();
            services.AddSession();
            services.AddControllersWithViews(options => options.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();
            app.UseMvcWithDefaultRoute();
            AppDbContent content;
            
            
              using (var scope = app.ApplicationServices.CreateScope())
               {
                content = scope.ServiceProvider.GetRequiredService<AppDbContent>();
                DBObjects.Initial(content);
            }

            
        }
    }
}
