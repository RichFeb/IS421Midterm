using CalculatorLib.Models;
using IS421Midterm.CalculatorLib.Models;
using IS421Midterm.Client.Events;
using IS421Midterm.Client.Interfaces;
using System;
using System.Collections.Generic;

namespace IS421Midterm.Client
{
    public class ConsoleManager 
    {
        public ConsoleEventAggregator eventAgg = new ConsoleEventAggregator();

        ConsoleEvent _consoleEvent = new ConsoleEvent();
        ProgramInit programInit = new ProgramInit();
        EnterOperation enterOperation = new EnterOperation();
        EnterNumericInput enterNumericInput = new EnterNumericInput();
        EnterMenuOption enterMenuOption = new EnterMenuOption();
        DivideByZero divideByZero = new DivideByZero();
        

        public ConsoleManager() { }

        public void Run()
        {
            bool myFlag = true;

            var calculator = Calculator.Instance;

            while(myFlag)
            {
                
            }
        }

        public void Init()
        {
            eventAgg.RegisterProgramInit();
            eventAgg.consoleEvent.Log();
            eventAgg.UnregisterProgramInit();
        }

        public void GetUserNumericInput()
        {
            eventAgg.RegisterEnterNumericInput();
            eventAgg.consoleEvent.Log();
            eventAgg.UnregisterEnterNumericInput();
        }

        public void GetUserMenuInput()
        {
            eventAgg.RegisterEnterMenuOption();
            eventAgg.consoleEvent.Log();
            eventAgg.UnregisterEnterMenuOption();
        }

        public void GetUserOperationInput()
        {
            eventAgg.RegisterEnterOperation();
            eventAgg.consoleEvent.Log();
            eventAgg.UnregisterEnterOperation();
        }

        public void FlagDivideByZero()
        {
            eventAgg.RegisterDivideByZero();
            eventAgg.consoleEvent.Log();
            eventAgg.UnregisterEnterOperation();
        }

        public void ThrowDivideByZero(Func<double, double, double> op, double second)
        {
            try
            {
                if (op == Operations.Divide && second == 0)
                {
                    throw new DivideByZeroException();
                }
            } catch
            {
                FlagDivideByZero();
            }

        }
    }
}
