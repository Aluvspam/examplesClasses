using System;

namespace State
{
    public abstract class State
    {
        public abstract void goNext(Context inContext);
    }
}

