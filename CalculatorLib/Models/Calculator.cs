using CalculatorLib.Models;
using IS421Midterm.CalculatorLib.Interfaces;
using System;

namespace IS421Midterm.CalculatorLib.Models
{
    public sealed class Calculator : ICalculator
    {

        private static readonly Calculator instance = new Calculator();
        private ICalculator _calculator;

        public Calculator()
        {
          

        }
        public Calculator(ICalculator calculator)
        {
            this._calculator = calculator;

        }

        

        public static Calculator Instance { get { return instance; }}

        public Calculation Create(double a, double b, Func<double, double, double> op)
        {
            return new Calculation(a, b, op);
        }

        public Calculation Create(double a, Func<double, double> op)
        {
            return new Calculation(a, op);
        }

        
    }
}
