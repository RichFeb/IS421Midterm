using IS421Midterm.CalculatorLib.Interfaces;
using IS421Midterm.CalculatorLib.Models;
using System;
using System.Collections.Generic;
using System.Text;
using IS421Midterm.Client;
using IS421Midterm.CalculatorLib.Events;

namespace IS421Midterm.CalculatorLib.Models
{
    // 1- define a delegate
    // 2- Define an event based on that delagte
    // 3- Raise the event 
    
    public class Calculator 
    {

        public CalculatorEvent _calcEvent = new CalculatorEvent();

        ConsoleManager consoleManager = new ConsoleManager(); //publisher
        Calculator calculator = new Calculator(); // subscriber 

        //
        private ICalculator _calculator;

        public Calculator()
        {

            
            
        }

        public Calculator( Calculator calculator)
        {

            this._calculator = (ICalculator)calculator;


        }


        public void OnConsoleManaged(object source, EventArgs e) {
            Console.WriteLine("Calculator is ON");

        }


        public Calculation Create(double a, double b, string op)

        {
            var _calculation = _calculator.Create(a, b, op);
            _calcEvent.GrabCalculation(_calculation);
            return _calculation;
        }

        public void SetCalculator(Calculator calculator) {

            this._calculator = (ICalculator)calculator;


        }
     
        public void ShowResult(Calculation calculation)
        {
            Console.WriteLine(calculation.Result);
        }

      
    }
}
