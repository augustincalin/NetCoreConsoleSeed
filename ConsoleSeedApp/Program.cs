using System;
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

            services.AddTransient<ISomeService, SomeService>();

            services.AddTransient<ConsoleApplication>();

            return services;
        }
    }
}
