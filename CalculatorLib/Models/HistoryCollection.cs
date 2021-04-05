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

        public void AddCalculation(Calculation calc)
        {
            CalculationList.Add(calc);
        }

        public Calculation GetCalculation(int index)
        {
            return CalculationList[index];
        }

        public void EditCalculation(int index)
        {
            Console.WriteLine("Editing: {0) {1} {2} ", 
                CalculationList[index].First, 
                CalculationList[index].Operation,
                CalculationList[index].Second);

            Console.WriteLine("Enter the first number");
            double _first = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the operation");

            // the type is wrong here

           string _op = Console.ReadLine();
            Console.WriteLine("Enter another number");
            double _second = Convert.ToDouble(Console.ReadLine());

            CalculationList[index].First = _first;
            //CalculationList[index].Operation = _op;
            CalculationList[index].Second = _second;
        }
    }
}
