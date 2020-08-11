//dotnet new web --no-https -o projectname
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DisplayTime
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(option => option.EnableEndpointRouting = false);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
       {
            Console.WriteLine(env.ContentRootPath);
            Console.WriteLine(env.IsDevelopment());
            if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
            app.UseMvc();
}
    }
}
