using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using TestTask.Data.Interfaces;
using TestTask.Data.Mocks;

namespace TestTask
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IAllProducts, MockProduct>();
            services.AddTransient<IProductsCategory, MockCategory>();
            services.AddMvc();

        }
        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            // app.UseMvcWithDefaultRoute();
            app.UseMvc(routes => {
                routes.MapRoute(name: "default", template: "{controller=Home}/{action=MainInfo}/{id?}");
                routes.MapRoute(name: "categoryFilter", template: "{controller=Product}/{action}/{category?}");
                routes.MapRoute(name: "productInfo", template: "{controller=Product}/{action=ShowProductInfo}/{productId?}");
            });
        }
    }
}
