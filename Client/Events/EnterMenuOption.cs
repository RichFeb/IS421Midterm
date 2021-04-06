using System;

namespace IS421Midterm.Client.Events
{
    public class EnterMenuOption
    {
        public void OnLog(object sender, EventArgs e)
        {
            Console.WriteLine("Please enter 1 of 3 options, listed below:");
            Console.WriteLine("\t0 - Begin/Continue Calculating");
            Console.WriteLine("\t1 - View History");
            Console.WriteLine("\t2 - Exit");
           

            
        }


    }
}
