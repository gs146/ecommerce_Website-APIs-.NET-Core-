using ecommerceWebsite.Data;
using ecommerceWebsite.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerceWebsite
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CommerceContext>(opt => opt.UseSqlServer
                        (Configuration.GetConnectionString("EcommerceConnection")));
            services.AddControllers();
            services.AddScoped<ICustomer, SqlCustomer>();
            services.AddScoped<IAddress, SqlAddress>();
            services.AddScoped<ICategory, SqlCategory>();
            services.AddScoped<IPayment, SqlPayment>();
            services.AddScoped<IProduct, SqlProduct>();
            services.AddScoped<ICart, SqlCart>();
            services.AddScoped<IOrder, SqlOrder>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
