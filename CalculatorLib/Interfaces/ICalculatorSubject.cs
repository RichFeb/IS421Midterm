using IS421Midterm.Client.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace IS421Midterm.CalculatorLib.Interfaces
{
    public interface ICalculatorSubject
    {
        void Attach(IConsoleObserver observer);

        void Detach(IConsoleObserver observer);

        void Notify();
    }
}
