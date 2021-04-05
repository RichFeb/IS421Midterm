using System;
using System.Collections.Generic;
using System.Text;

namespace IS421Midterm.Client.Events
{
    public class EnterOperation
    {
        public void OnLog(object sender, EventArgs e)
        {
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\t+ - Add");
            Console.WriteLine("\t- - Subtract");
            Console.WriteLine("\t* - Multiply");
            Console.WriteLine("\t/ - Divide");
            Console.WriteLine("\t** - Exp");
            Console.WriteLine("\tsqrt - Square Root");
     
        }
    }
}
