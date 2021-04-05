using System;
using System.Collections.Generic;
using System.Text;

namespace IS421Midterm.Client.Events
{
    public class ProgramInit
    {
        public void OnLog(object sender, EventArgs e)
        {
            Console.WriteLine("Calculator program startup commencing. Please enter an option.");
        }
    }
}
