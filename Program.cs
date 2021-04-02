using System;
using IS421Midterm.Client;

namespace IS421Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*
             * 
             * Steps
             * 
             * 1. Get User Input
             * 2. Process Input
             * 3. Create Calculation
             * 4. Add calculation to history
             * 
             * + => Operation
             * 
             * Console => Publisher
             * Calculator => Subscriber
             * 
             * Events
             * 
             * InputReceived
             * CalculationCreated
             * 
             * 
             * Enter your operands 9 8 7
             * 
             * 
            */

            var conman = new ConsoleManager();
            conman.CalculationPublished += conman.CalculationPublished;
            var calculation = conman.GetUserInput();
            conman.PublishCalculation(calculation);
        }
    }
}
