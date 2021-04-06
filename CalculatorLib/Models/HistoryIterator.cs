using CalculatorLib.Interfaces;
using CalculatorLib.Models;
using IS421Midterm.CalculatorLib.Interfaces;
using System.Collections.Generic;

namespace IS421Midterm.CalculatorLib.Models
{
    public class HistoryIterator : IHistoryIterator
    {
        private static HistoryCollection History;

        private int Current = -1;

        public bool IsCompleted
        {
            get { return Current >= History.Count;  }
        }

        public HistoryIterator(HistoryCollection history)
        {
            History = history;
        }
        public ICalculation First()
        {
            Current = 0;
            return History.GetCalculation(Current);
        }

        public ICalculation Last()
        {
            Current = History.Count - 1;
            return History.GetCalculation(Current);
            
        }

        public ICalculation Next()
        {
            Current += 1;
            if (!IsCompleted)
            {
                return History.GetCalculation(Current);
            } else
            {
                return null;
            }
        }

        public ICalculation Prev()
        {
            Current -= 1;
            if (!IsCompleted)
            {
                return History.GetCalculation(Current);
            } else
            {
                return null;
            }
        }


        public List<ICalculation> PrintAll() 
        {
            return null;
        }
    }
}
