using IS421Midterm.CalculatorLib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IS421Midterm.Client
{
    public class ConsoleManager
    {
        public ConsoleManager() { }
      
        public EventHandler<Calculation> CalculationPublished;
       

        public Calculation GetUserInput()
        {
            var calculator = new Calculator();

            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\t+ - Add");
            Console.WriteLine("\t- - Subtract");
            Console.WriteLine("\t* - Multiply");
            Console.WriteLine("\t/ - Divide");
            Console.WriteLine("\th - History");
            Console.Write("Your option? ");
            string option = (Console.ReadLine());
            Console.WriteLine("Enter a number");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a number");
            double y = Convert.ToDouble(Console.ReadLine());

            var calculation = calculator.Create(x, y, option);
            
            return calculation;
        }

        private void startover() {

            Console.WriteLine("If you want to do another Calculation press Y. If not Press anyKey");
            char YesorNo = (char)Console.Read();
            bool mybool = (YesorNo == 'y' ||  YesorNo== 'Y');

            while (mybool) {

                GetUserInput();

            }

        }

        public void PublishCalculation(Calculation calculation)
        {
            Console.WriteLine("{0} {1} {2}",
                calculation.First,
                calculation.Operation,
                calculation.Second);
            startover();
        }

        protected virtual void OnPublishCalculation(Calculation calculation)
        {
            CalculationPublished?.Invoke(this,  calculation);
        }
    }
}
