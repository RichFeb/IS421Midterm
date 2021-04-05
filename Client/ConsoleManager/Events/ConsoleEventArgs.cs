using System;

namespace IS421Midterm.Client.ConsoleManager.Events
{
    public class ConsoleEventArgs : EventArgs
    {
        public double NumericInput { get; set; }

        public Func<double, double, double> OperationInput { get; set; }

        public string StringInput { get; set; }

    }
}
