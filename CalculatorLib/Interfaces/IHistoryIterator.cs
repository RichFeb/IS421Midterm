using IS421Midterm.CalculatorLib.Interfaces;
using IS421Midterm.CalculatorLib.Models;

namespace CalculatorLib.Interfaces
{
    interface IHistoryIterator
    {
        ICalculation First();
        ICalculation Next();

        ICalculation Prev();
        ICalculation Last();
        
    }
}
