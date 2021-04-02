using IS421Midterm.CalculatorLib.Models;

namespace CalculatorLib.Interfaces
{
    interface IHistoryIterator
    {
        Calculation First();
        Calculation Next();

        Calculation Prev();
        Calculation Last();
        
    }
}
