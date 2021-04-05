using System;
using IS421Midterm.CalculatorLib.Events;

namespace IS421Midterm.CalculatorLib
{
    public class DisplayCalculation
    {


        public void OnCalculation(object sender, CalcEventArgs calcEvent) {

            Console.WriteLine("Result is: " + calcEvent.Calc.GetResult());
        }
    }
}
