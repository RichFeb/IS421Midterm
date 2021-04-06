using IS421Midterm.CalculatorLib.Models;
using IS421Midterm.Client.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace IS421Midterm.Client
{
    public class ConsoleManager
    {


        public void Run()
        {
            var calculator = Calculator.Instance;
            var aggregator = new ConsoleEventAggregator();

        }

        internal object GetLastInput()
        {
            throw new NotImplementedException();
        }
    }
}
