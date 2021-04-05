using System;
using IS421Midterm.CalculatorLib.Models;

namespace IS421Midterm.CalculatorLib.Interfaces
{
     abstract class IHistoryState 
    {
        public HistoryIterator CreateIterator;

        public int Count;

        public ICalculation AddCalculation;
        public Calculation GetCalculation;
        public  Calculation EditCalculation;


    }
}
