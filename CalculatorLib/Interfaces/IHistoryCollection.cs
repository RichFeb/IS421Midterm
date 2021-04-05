using IS421Midterm.CalculatorLib.Models;

namespace IS421Midterm.CalculatorLib.Interfaces
{
    interface IHistoryCollection
    {
        HistoryIterator CreateIterator();
        public void AddCalculation(ICalculation calc);
        public Calculation GetCalculation(int index);
        public void EditCalculation(int index);
    }
}
