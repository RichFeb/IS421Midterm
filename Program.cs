using System;

using IS421Midterm.CalculatorLib.Models;
using IS421Midterm.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using IS421Midterm.CalculatorLib;
namespace IS421Midterm
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculator _calculator = Calculator.Instance;

            var serviceCollection = new ServiceCollection();

            ConfigureServices(serviceCollection);

            var calculatorService = serviceCollection.BuildServiceProvider();

            // are we using ConosoleManager ?? bc we dont have start in it ??

            var _consoleEManager = _serviceProvider.GetService<ConsoleManager>();

        

            //conman.Run();
            // we dont have start method for this one


            Console.Start();

        }

       


        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging(configure => configure.AddConsole())
                .AddTransient<ConsoleManager>();
        }
    }

   

}
