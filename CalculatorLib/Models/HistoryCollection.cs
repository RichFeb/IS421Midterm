using IS421Midterm.CalculatorLib.Interfaces;
using IS421Midterm.CalculatorLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace CalculatorLib.Models
{
    public class HistoryCollection : IHistoryCollection
    {
        private List<Calculation> CalculationList = new List<Calculation>();
        public HistoryIterator CreateIterator()
        {
            return new HistoryIterator(this);
        }

        public int Count
        {
            get { return CalculationList.Count(); }
        }

        public void AddCalculation(ICalculation calc)
        {
            CalculationList.Add((Calculation)calc);
        }

        public Calculation GetCalculation(int index)
        {
            return CalculationList[index];
        }

        public void EditCalculation(int index)
        {
            
        }
    }
}
