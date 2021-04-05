using IS421Midterm.CalculatorLib.Interfaces;
using IS421Midterm.CalculatorLib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IS421Midterm.CalculatorLib.Models
{
    public sealed class Calculator : ICalculator
    {
        private static readonly Calculator instance = new Calculator();

        static Calculator() { }

        private Calculator() { }

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
