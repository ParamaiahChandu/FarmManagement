using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmManagement.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FarmManagement
{
    public class Startup
    {
        private IConfiguration _config;
        public Startup(IConfiguration config)
        {
            _config = config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //To register DB Context 
            services.AddDbContextPool<AppDbContext>(options => options.UseSqlServer(_config.GetConnectionString("SaplingDBConnection")));

            //To add services required for MVC
            services.AddMvc(options => options.EnableEndpointRouting = false).AddXmlSerializerFormatters();
            //To register with the dependency injection container, add interfaces, you want, to the services
            //services.AddSingleton<ISaplingRepository, MockSaplingRepository>();
            services.AddScoped<ISaplingRepository, SQLSaplingRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseStaticFiles();

            //Add MVC to the middleware
            app.UseMvcWithDefaultRoute();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hosting Environment is: " + env.EnvironmentName);
            });
        }
    }
}
