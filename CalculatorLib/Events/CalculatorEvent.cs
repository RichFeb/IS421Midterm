using System;
using IS421Midterm.CalculatorLib.Models;

namespace IS421Midterm.CalculatorLib.Events
{
    public class CalculatorEvent
    {
        public ICalculation Calculation { get; private set; }

        public event EventHandler<CalcEventArgs> CalculationCompleted;
        public event EventHandler<CalculatorEventArgs> UsingCalculator;

        public void GrabCalculation(ICalculation calculation) {
            Console.WriteLine("Grabbing the calculation");
            OnCalculation(calculation);

        }

        public void UseCalculation(Calculator calculator) {

            Console.WriteLine("Using the Calculator ");
            OnCalculation((ICalculation)calculator);

        }

       

        protected virtual void OnCalculation(ICalculation calculation) {
            CalculationCompleted?.Invoke(this, new CalcEventArgs());
            {
                Calculation = calculation;
            }
   
        }

        protected virtual void OnCalculation(Calculator calculator) {

            UsingCalculator?.Invoke(this, new CalculatorEventArgs() { Caculator = calculator });
        }

        internal void GrabCalculation(Calculation calculation)
        {
            throw new NotImplementedException();
        }
    }
}
