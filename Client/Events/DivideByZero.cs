using System;
using System.Collections.Generic;
using System.Text;

namespace IS421Midterm.Client.Events
{
    public class DivideByZero
    {
        public void OnLog(object sender, EventArgs e)
        {
            Console.WriteLine("LOG: {0} Divide by error detected.", new DateTime());
            Console.WriteLine("LOG: {0} Enter a new calculation.", new DateTime());
        }
    }
}
