using IS421Midterm.CalculatorLib.Interfaces;
using IS421Midterm.CalculatorLib.Models;
using System;
using System.Collections.Generic;
using System.Text;
using IS421Midterm.Client;

namespace IS421Midterm.CalculatorLib.Models
{
    // 1- define a delegate
    // 2- Define an event based on that delagte
    // 3- Raise the event 
    
    public class Calculator : ICalculator
    {

        ConsoleManager consoleManager = new ConsoleManager(); //publisher
        Calculator calculator = new Calculator(); // subscriber 

        //

        public Calculator()
        {

            //subscribing
            
        }


        public void OnConsoleManaged(object source, EventArgs e) {
            Console.WriteLine("Calculator is ON");

        }


        public Calculation Create(double a, double b, string op)
        {
            return new Calculation(a, b, op);
        }

     
        public void ShowResult(Calculation calculation)
        {
            Console.WriteLine(calculation.Result);
        }

      
    }
}
