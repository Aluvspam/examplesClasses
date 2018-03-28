using System;

namespace State
{
    public class StateTwo : State
    {
        public override void goNext(Context inContext)
        {
            inContext.setState(new StateTwo());
        }
    }
}

