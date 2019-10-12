using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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

            services.AddSingleton(config);

            services.AddTransient<ISomeService, SomeService>();

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
