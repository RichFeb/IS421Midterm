using CalculatorLib.Interfaces;
using CalculatorLib.Models;
using System.Collections.Generic;

namespace IS421Midterm.CalculatorLib.Models
{
    public class HistoryIterator : IHistoryIterator
    {
        private static HistoryCollection History;

        private int Current = -1;

        private bool IsEmpty => History.Count == 0; 

        public bool IsCompleted
        {
            get { return Current >= History.Count;  }
        }

        public HistoryIterator(HistoryCollection history)
        {
            History = history;
        }
        public Calculation First()
        {
            Current = 0;
            return History.GetCalculation(Current);
        }

        public Calculation Last()
        {
            Current = History.Count - 1;
            return History.GetCalculation(Current);
            
        }

        public Calculation Next()
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

        public Calculation Prev()
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


        public List<Calculation> PrintAll() 
        {
            return null;
        }
    }
}
