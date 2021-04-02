using IS421Midterm.CalculatorLib.Models;

namespace IS421Midterm.CalculatorLib.Interfaces
{
    interface IHistoryCollection
    {
        HistoryIterator CreateIterator();
    }
}
