using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertConsoleAppToWebApp
{
    class StartUp
    {
        public void ConfigurationService(IServiceCollection servise)
        {

        }
        public void Configure(IApplicationBuilder application,IWebHostEnvironment environment)
        {
            application.UseRouting();
            application.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                 {
                     await context.Response.WriteAsync("Welcome to BizRunTime");
                 });
            });
        }


    }
}
