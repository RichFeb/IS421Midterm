using System;
using System.Collections.Generic;
using System.Text;

namespace IS421Midterm.Client.Events
{
    public class EnterNumericInput
    {
        public int OnLog(object sender, EventArgs e)
        {
            Console.WriteLine("Enter enter a number.");

            var NumInput = Console.Read();

            return NumInput;

        }



       
    }
}
