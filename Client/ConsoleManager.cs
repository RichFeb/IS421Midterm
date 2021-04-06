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

            while (UserInput) {

                


                Func<double, double, double> operation = enterOperation.OnLog();
                var num = enterNumericInput.OnLog();
                var num2 = enterNumericInput.OnLog();

                DoCalculation(num, num2, operation);

                var menuOption = enterMenuOption.OnLog();
                

            }
        }


        public void DoCalculation(double num, double num2, Func<double, double, double> menuoption) {


            var CalcResult = calculator.Create(num, num2, menuoption);

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
