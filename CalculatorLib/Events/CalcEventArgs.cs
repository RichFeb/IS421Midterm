using IS421Midterm.CalculatorLib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IS421Midterm.CalculatorLib.Events
{
    public class CalcEventArgs : EventArgs
    {
        public Calculation Calc { get; set; }
    }

    public class CalculatorEventArgs : EventArgs {

        public Calculator Caculator { get; set; }

    }
}
