using System;

using IS421Midterm.CalculatorLib.Models;
using IS421Midterm.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using IS421Midterm.CalculatorLib;
using IS421Midterm.Client.Events;

namespace IS421Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            _ = new ConsoleManager();

            var serviceCollection = new ServiceCollection();

            ConfigureServices(serviceCollection);

            var calculatorService = serviceCollection.BuildServiceProvider();




            ConsoleManager conman = calculatorService.GetService<ConsoleManager>();


            conman.Run();

        }

   


        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging(configure => configure.AddConsole())
                .AddTransient<ConsoleEvent>();
        }
    }

   

}
