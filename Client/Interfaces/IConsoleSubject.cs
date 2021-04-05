using System;
using System.Collections.Generic;
using System.Text;

namespace IS421Midterm.Client.Interfaces
{
    public interface IConsoleSubject
    {
        void Attach(IConsoleObserver observer);

        void Detach(IConsoleObserver observer);

        void Notify();
    }
}
