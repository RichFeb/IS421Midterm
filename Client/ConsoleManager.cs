using System;
using System.Collections.Generic;
using System.Text;
using IS421Midterm.CalculatorLib.Models;
using IS421Midterm.Client.Events;
using IS421Midterm.Client.Interfaces;

namespace IS421Midterm.Client
{
    public class ConsoleManager
    {
        Calculator calculator;
        ConsoleEventAggregator consoleAgg = new ConsoleEventAggregator();

        public ConsoleEvent consoleEvent = new ConsoleEvent();
        ProgramInit programInit = new ProgramInit();
        EnterOperation enterOperation = new EnterOperation();
        EnterNumericInput enterNumericInput = new EnterNumericInput();
        EnterMenuOption enterMenuOption = new EnterMenuOption();
        DivideByZero divideByZero = new DivideByZero();

        IConsoleSubject consolsub ;
        private IConsoleObserver observer;

        public void Run()
        {
            bool UserInput = true;

            
                startUp();
                start();
                
                var NumInput1= UserInputNumbers();
                var NumInput2 = UserInputNumbers(); 
                var operation = start();

                var calculation = calculator.Create(NumInput1, NumInput2, operation);

            Console.WriteLine("If you want to continue press Y. If not Press anyKey");
            char YesorNo = (char)Console.Read();
            bool mybool = (YesorNo == 'y' || YesorNo == 'Y');

            while (mybool)
            {

            int caseSwitch = Int32.Parse(Option());

                switch (caseSwitch)
                {
                    case 1:

                        Console.WriteLine("Calculating ");
                        start();
                        Option();
                    case 2:

                        Console.WriteLine("Showing History ");
                        Option();

                    default:
                        Console.WriteLine("Exitin ......");

                }

            }
        }

        public int UserInputNumbers() {


            Console.WriteLine("Enter enter a number.");

            var NumInput1 = Console.Read();



            return NumInput1;
        }

        public void startUp() {

            Console.WriteLine("Calculator program startup commencing. Please enter an option.");

        }
        public string start() {


            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\t+ - Add");
            Console.WriteLine("\t- - Subtract");
            Console.WriteLine("\t* - Multiply");
            Console.WriteLine("\t/ - Divide");
            Console.WriteLine("\t** - Exp");
            Console.WriteLine("\tsqrt - Square Root");

            var operation = Console.ReadLine();

            return operation;
        }


        public string Option() {


            Console.WriteLine("Please enter 1 of 3 options, listed below:");
            Console.WriteLine("\t0 - Begin/Continue Calculating");
            Console.WriteLine("\t1 - View History");
            Console.WriteLine("\t2 - Exit");
            var option = Console.ReadLine();


            return option;
        }

        public void PublishCalculation(Calculation calculation)
        {
            Console.WriteLine("{0} {1} {2}",
                calculation.First,
                calculation.Operation,
                calculation.Second);
            start();
        }


        void MenuEvent() {

            consoleAgg.RegisterEnterOperation();
            
            consoleAgg.UnregisterEnterOperation();

        }
        void FirstClaculation()

        {
            consolsub.Attach(observer);
            
        }

        void VoidCalculation() {


            consolsub.Detach(observer);
        }
       
    }
}
