using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLib.Models
{
    public class Operations
    {
        public  static double Add(double a, double b) => a + b;

        public static double Subtract(double a, double b) => a - b;

        public static double Multiply(double a, double b) => a * b;

        public static double Divide(double a, double b) => (b != 0) ? a / b : throw new DivideByZeroException();

        public static double Square(double a) => a * a;

        public static double SquareRoot(double a) => Math.Sqrt(a);
    }
}
