using System;
using System.Collections.Generic;
using System.Text;

namespace IS421Midterm.State
{
    // Unmodified Calculator


    class UnmodifiedCalculator : State
    {
        public override void Handle(Context context)
        {
            context.State = new UnmodifiedCalculator();
        }
    }
}