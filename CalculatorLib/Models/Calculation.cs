namespace IS421Midterm.CalculatorLib.Models
{
    public class Calculation
    {
        public double First { get; set; }

        public double Second { get; set; }

        public string Operation { get; set; }

        public double Result { get; private set; }

        public double HasResult { get; set; }

        public bool WasModified { get; set; }
        
        public Calculation(double first, double second, string op)
        {
            First = first;
            Second = second;
            Operation = op;
        }
    }
}