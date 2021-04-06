using IS421Midterm.Client.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace IS421Midterm.Client.Observer
{
    public class InputObserver : IConsoleObserver
    {
        public void Update(ConsoleManager subject)
        {
            var input = subject.GetLastInput();
            Console.WriteLine("Last recorded input was: {0}", input);
        }
    }
}
