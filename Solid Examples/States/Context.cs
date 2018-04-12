using System;

namespace State
{
    public class Context
    {
        State current;

        public void goNext()
        {
            current.goNext(this);
        }

        public void setState(State newState)
        {
            current = newState;
        }

    }
}

