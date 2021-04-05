
using System;
using System.Collections.Generic;
using System.Text;

namespace IS421Midterm.State
{
    
    class Context
    {
        public State State { get; set; }

        public Context(State state)
        {
            this.State = state;
        }

        public void Request()
        {
            State.Handle(this);
        }
    }
}