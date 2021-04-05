using System;
using IS421Midterm.CalculatorLib.Interfaces;

namespace IS421Midterm.CalculatorLib.Models
{
    public class Calculation
    {
       

        public double First { get; set; }

        public double Second { get; set; }

        public Func<double, double, double> Operation { get; set; }
        

        public double HasResult { get; set; }

        public bool WasModified { get; set; }
        
        public Calculation(double first, double second, Func<double, double, double> op)
        {
            First = first;
            Second = second;
            Operation = op;
        }

      

        public static Calculation Create(double a, double b, Func<double, double, double> op) {

            var _calculation = IAbstractFactory.calcObject();
            return _calculation.Create(a, b, op);

        }

        public double GetResult() {

            return Operation(First, Second);
        }

    }
}