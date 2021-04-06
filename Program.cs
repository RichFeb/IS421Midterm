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

            Calculator _calculator = Calculator.Instance;

            var serviceCollection = new ServiceCollection();

            ConfigureServices(serviceCollection);

            var calculatorService = serviceCollection.BuildServiceProvider();


            var _consoleInit = _serviceProvider.GetService<ProgramInit>();
            var _consoleNumber = _serviceProvider.GetService<EnterMenuOption>();
            

            var _consoleOption = _serviceProvider.GetService<EnterOperation>();
            var _consoleMenuOption = _serviceProvideer.GetService<EnterMenuOption>();

            var _consoleEManager = _serviceProvider.GetService<ConsoleManager>();

            //conman.Run();
            // we dont have start method for this one


            ConsoleManager.Run();

        }

   


        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging(configure => configure.AddConsole())
                .AddTransient<ConsoleEvent>();
        }
    }

   

}
