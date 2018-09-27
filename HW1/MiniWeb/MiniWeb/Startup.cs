using System;
using System.Linq;
using MiniWeb.Persistence;
using MiniWeb.Persistence.Abstractions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace MiniWeb
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ICountryRepository>(new CountryRepository());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app,
           IHostingEnvironment env,
           IServiceProvider provider)
        {
            app.Run(async (context) =>
            {
                var country = provider.GetService<ICountryRepository>();
                var query = context.Request.Query["q"];
                var listOfCountries = country.AllBy(query).ToList();
                var json = JsonConvert.SerializeObject(listOfCountries);

                await context.Response.WriteAsync(json);
            });
        }
           
        
    }
}
