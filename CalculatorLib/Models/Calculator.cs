using IS421Midterm.CalculatorLib.Interfaces;
using IS421Midterm.CalculatorLib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IS421Midterm.CalculatorLib.Models
{
    public class Calculator : ICalculator
    {
        public Calculator()
        {
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
