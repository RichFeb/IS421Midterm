using IS421Midterm.CalculatorLib.Models;
using IS421Midterm.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace IS421Midterm.CalculatorLib.Interfaces
{
    interface ICalculator
    {
        public Calculation Create(double a, double b, string op);
        public Calculation Create(List<double> listValues, Func<List<double>, double> operation);

        public void Subscribe(ConsoleManager consoleManager){}

        public void ShowResult(Calculation calculation);
    }
}
