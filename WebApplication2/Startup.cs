﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace WebApplication2
{
    public class Startup
    {
        public static System.Text.Encoding UTF8 { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMiddleware<IpLoc>();
            //app.Run(async (context) =>
            //{
            //    context.Response.ContentType = "text/html;charset=utf-8";
            //    await context.Response.WriteAsync("Чтобы использовать сервис IP Location, используйте запрос по ссылке /ip/ddd.ddd.ddd.ddd");
            //});
        }
    }
}
