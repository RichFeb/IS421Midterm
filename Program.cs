using System;
using IS421Midterm.Client;
using IS421Midterm.Client.Events;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace IS421Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
      
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            var calculatorService = serviceCollection.BuildServiceProvider();

            ConsoleManager conman = calculatorService.GetService<ConsoleManager>();

            conman.Run();

          
        }

        private static void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddLogging(configure => configure.AddConsole())
                .AddTransient<ConsoleManager>();
        }
    }
}
