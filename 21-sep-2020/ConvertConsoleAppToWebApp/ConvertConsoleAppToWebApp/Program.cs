using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;

namespace ConvertConsoleAppToWebApp
{
    class Program
    {
        static void Main(string[] args)
        {
            HostBuilder(args).Build().Run();
        }
        public static IHostBuilder HostBuilder(String[] args) =>
        
            Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<StartUp>();
            });
        
    }
}
