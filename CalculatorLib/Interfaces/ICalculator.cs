using IS421Midterm.CalculatorLib.Models;
using IS421Midterm.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace IS421Midterm.CalculatorLib.Interfaces
{
    public interface ICalculator
    {
        public Calculation Create(double a, Func<double, double> op);

        public Calculation Create(double a, double b, Func<double, double, double> op);

    }
}
