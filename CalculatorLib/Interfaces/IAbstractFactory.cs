using System;
using IS421Midterm.CalculatorLib.Factories;
using IS421Midterm.CalculatorLib.Models;

namespace IS421Midterm.CalculatorLib.Interfaces

{
    public interface IAbstractFactory
    {
        static IAbstractCalcObject calcObject()
        {
            return new ConcreteObjects();
        }
    }



    public interface IAbstractCalcObject {

        Calculation Create(double a, double b, Func<double, double, double> operation);
    }




}