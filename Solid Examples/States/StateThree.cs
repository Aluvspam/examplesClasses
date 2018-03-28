using System;

namespace State
{
    public class StateThree : State
    {
        public override void goNext(Context inContext)
        {
            inContext.setState(new StateThree());
        }
    }
}

