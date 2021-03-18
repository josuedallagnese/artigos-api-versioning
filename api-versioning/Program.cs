using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.Threading.Tasks;

namespace ApiVersioning
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Console.Title = typeof(Program).Namespace;

            var host = Host.CreateDefaultBuilder(args)
                    .ConfigureAppConfiguration((hostingContext, config) =>
                    {
                        var env = hostingContext.HostingEnvironment;
                        config.AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: false, reloadOnChange: true);

                        config.AddEnvironmentVariables();
                        config.AddCommandLine(args);

                        var configurationRoot = config.Build();
                    })
                    .ConfigureWebHostDefaults(webBuilder =>
                    {
                        webBuilder
                            .UseStartup<Startup>()
                            .UseKestrel()
                            .UseContentRoot(Directory.GetCurrentDirectory())
                            .UseIISIntegration()
                            .UseSetting("detailedErrors", "true");
                    });

            await host.RunConsoleAsync();
        }
    }
}
