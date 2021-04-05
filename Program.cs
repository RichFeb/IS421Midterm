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
             * Next Steps
             * 
             * Test that event gets published to calculator
             * 
             * Process calculation
             * 
             * Add to history
             * 
             * Test history collection & iterate through it
             * 
             * Finish writing tests
             * 
            */

            var conman = new ConsoleManager();
            conman.CalculationPublished += conman.CalculationPublished;
            var calculation = conman.GetUserInput();
            conman.PublishCalculation(calculation);
        }
    }
}
