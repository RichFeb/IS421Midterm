using CalculatorLib.Models;
using IS421Midterm.CalculatorLib.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace IS421Midterm.Tests
{
    [TestClass()]
    public class CalculatorTests
    {

        [TestMethod()]
        public void CalculatorTest()
        {

            Calculator _calculator = new Calculator();
            Assert.IsInstanceOfType(_calculator, typeof(Calculator));

        }

        [TestMethod()]
        public void SumTest()
        {


            double _a = 1;
            double _b = 2;
            Func<double, double, double> _action = Operations.Sum;
            Calculator _calculator = new Calculator(new Calculator());

           
            var _result = _calculator.Create(_a, _b, _action);

            Console.WriteLine(_result.GetResult());
            Assert.AreEqual(_result.GetResult(), 3);

        }


        [TestMethod()]
        public void DifferenceTest()
        {
            double _a = 15;
            double _b = 5;
            Func<double, double, double> _action = Operations.Subtract;
            Calculator _calculator = new Calculator(new Calculator());

            var _result = _calculator.Create(_a, _b, _action);
            Assert.AreEqual(_result.GetResult(), 10);
        }


        [TestMethod()]
        public void MultiplicationTest()
        {
            double _a = 15;
            double _b = 5;
            Func<double, double, double> _action = Operations.Multiply;

            Calculator _calculator = new Calculator(new Calculator());

            var _result = _calculator.Create(_a, _b, _action);
            Assert.AreEqual(_result.GetResult(), 75);
        }
        [TestMethod()]
        public void DivisionTest()
        {
            double _a = 15;
            double _b = 5;
            Func<double, double, double> _action = Operations.Divide;
            Calculator _calculator = new Calculator(new Calculator());

            var _result = _calculator.Create(_a, _b, _action);

            Assert.AreEqual(_result.GetResult(), 3);

        }

        

    }
}