using IS421Midterm.CalculatorLib.Interfaces;
using System;

namespace IS421Midterm.CalculatorLib.Models
{
    public class Calculation : ICalculation
    {
        public double First { get; set; }

        public double Second { get; set; }

        public Func<double, double, double> BinaryOperation { get; set; }

        public Func<double, double> UnaryOperation { get; set; }

        public Calculation(double first, double second, Func<double, double, double> op)
        {
            First = first;
            Second = second;
            BinaryOperation = op;
        }

        public Calculation(double first, Func<double, double> op)
        {
            First = first;
            UnaryOperation = op;
        }

        public double GetBinaryResult()
        {
            return BinaryOperation(First, Second);
        }

        public double GetUnaryResult()
        {
            return UnaryOperation(First);
        }


        public double GetResult()
        {
            return BinaryOperation(First, Second);

        }
    }
}