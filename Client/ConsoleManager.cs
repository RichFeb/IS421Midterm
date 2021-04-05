using IS421Midterm.CalculatorLib;
using IS421Midterm.CalculatorLib.Models;
using System;


namespace IS421Midterm.Client
{
    public class ConsoleManager
    {
        public ConsoleManager() { }
      
        public EventHandler<Calculation> CalculationPublished;
        public EventHandler<Calculator> CalculatorSubscriber;


        public static Calculator _calculator = new Calculator();

        

        ConsoleManager _consoleManager = new ConsoleManager();

        

        RegisterEvents _consoleEventManager = new RegisterEvents(_calculator);

        // define delegate
       // public delegate void ConsoleManagerEventHandler(object source, EventArgs args);
        // definie event
        //public event ConsoleManagerEventHandler ConsoleManged;



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

            // preforming the calculation here

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


        //I m not sure down here what I should do 


       // void InitializeCalculationEvent()

       // {

          //  _consoleManager.Attach()
       // }






        // these are my old attempt 

        // protected virtual void OnPublishCalculation(Calculation calculation)
        // {
        // CalculationPublished?.Invoke(this,  calculation);
        // }




       // protected virtual void OnConsoleManager() {
          //  ConsoleManged?.Invoke(this, EventArgs.Empty);
       // }

       


    }
}
