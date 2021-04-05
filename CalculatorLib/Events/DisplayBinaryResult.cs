﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IS421Midterm.CalculatorLib.Events
{
    public class DisplayBinaryResult
    {
        public void OnCalculation(object sender, CalcEventArgs e)
        {
            Console.WriteLine("The result is: {0}", e.Calculation.GetBinaryResult());
        }
    }
}
