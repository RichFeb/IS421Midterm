using System;
using System.Collections.Generic;
using System.Text;

namespace IS421Midterm.State
{
    // The state of the calcultor 
    abstract class State
    {
        public abstract void Handle(Context context);
    }
}