using System;

namespace State
{
    public class StateOne : State
    {
        public override void goNext(Context inContext)
        {
            inContext.setState(new StateOne());
        }
    }
}

