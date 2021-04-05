using System;
using IS421Midterm.CalculatorLib.Models;
using IS421Midterm.Client;

namespace IS421Midterm.CalculatorLib
{
    public class RegisterEvents
    {
        public RegisterEvents(Calculator calculator)
        {
            this._calculator = calculator;
        }

        Calculator _calculator;

        ConsoleManager _consoleManager = new ConsoleManager();
        DisplayCalculation displayCalculation = new DisplayCalculation();

        public  void EventRegister(Calculator calculator)
        {

            this._calculator = calculator;
        }

        public void RegisterDisplayCalculationEvent() {

            _calculator._calcEvent.CalculationCompleted += displayCalculation.OnCalculation;
        }

        public void UnRegisterDisplayCalculationEvent() {

            _calculator._calcEvent.CalculationCompleted -= displayCalculation.OnCalculation;
        }

    }
}
