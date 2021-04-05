using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLib.Models
{
    public class Operations
    {
        public static Func<double, double, double> Sum = (a, b) => a + b;
        public static Func<double, double, double> Subtract = (a, b) => a - b;
        public static Func<double, double, double> Multiply = (a, b) => a * b;
        public static Func<double, double, double> Divide = (a, b) => a / b;
        public static Func<double, double, double> Exp = (a, b) => Math.Pow(a, b);
        public static Func<double, double, double> BinaryUnassigned = (a, b) => 0;
        public static Func<double, double> Square = (a) => a * a;
        public static Func<double, double> SquareRoot = (a) => Math.Pow(a, 0.5);
        public static Func<double, double> UnaryUnassigned = (a) => 0;
    }
}
