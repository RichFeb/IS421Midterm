
using System;
using System.Collections.Generic;
using System.Text;

namespace IS421Midterm.State
{
    // the modified calculator


    class ModifiedCalculator : State
    {
        public override void Handle(Context context)
        {
            context.State = new ModifiedCalculator();
        }
    }
}