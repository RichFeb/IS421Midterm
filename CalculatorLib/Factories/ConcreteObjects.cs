using System;
using IS421Midterm.CalculatorLib.Interfaces;
using IS421Midterm.CalculatorLib.Models;

namespace IS421Midterm.CalculatorLib.Factories
{
    public class ConcreteObjects  : IAbstractCalcObject
    {
        public ConcreteObjects()
        {
        }

        public static Calculation Create(double a, double b, Func<double, double, double> operation) {

            return new Calculation(a, b, operation);
        }

        Calculation IAbstractCalcObject.Create(double a, double b, Func<double, double, double> operation)
        {
            return ConcreteObjects.Create(a, b, operation);
        }
    }
}
