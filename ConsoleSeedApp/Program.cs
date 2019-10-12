using System;
using System.IO;
using ConsoleSeedApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ConsoleSeedApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IServiceCollection services = ConfigureServices();
            ServiceProvider serviceProvider = services.BuildServiceProvider();
            serviceProvider.GetService<ConsoleApplication>().Run();
        }

        private static IServiceCollection ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();

            IConfiguration config = LoadConfiguration();

            services.AddLogging(logging =>
            {
                logging.AddConfiguration(config.GetSection("Logging"));
                logging.AddConsole();
            }).Configure<LoggerFilterOptions>(options => options.MinLevel = LogLevel.Information);

            services.AddSingleton(config);

            services.AddTransient<ISomeService, SomeService>();

            services.AddDbContext<SomeDbContext>(options => options.UseSqlServer(config.GetConnectionString("Default")));

            services.AddTransient<ConsoleApplication>();

            return services;
        }

        private static IConfiguration LoadConfiguration()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            return builder.Build();
        }
    }
}
