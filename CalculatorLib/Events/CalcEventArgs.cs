using IS421Midterm.CalculatorLib.Interfaces;
using IS421Midterm.CalculatorLib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IS421Midterm.CalculatorLib.Events
{
    public class CalcEventArgs
    {
        public ICalculation Calculation { get; set; }
    }
}



