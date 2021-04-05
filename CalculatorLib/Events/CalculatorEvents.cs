using IS421Midterm.CalculatorLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace IS421Midterm.CalculatorLib.Events
{
   public class CalculatorEvents
    {

        public event EventHandler<CalcEventArgs> CalculationComplete;


        public void GetBinaryCalculation(ICalculation calculation)
        {
            Console.WriteLine("The calculation you have queued is: {0}", calculation.GetBinaryResult());
        }

        public void GetUnaryCalculation(ICalculation calculation)
        {
            Console.WriteLine("The calculation you have queued is: {0}", calculation.GetUnaryResult());
        }

        protected virtual void OnBinaryCalculation(ICalculation calculation)
        {
            CalculationComplete?.Invoke(this, new CalcEventArgs() { Calculation = calculation });
        }

        protected virtual void OnUnaryCalculation(ICalculation calculation)
        {
            CalculationComplete?.Invoke(this, new CalcEventArgs() { Calculation = calculation });
        }
    }
}
