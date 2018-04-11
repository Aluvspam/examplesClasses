using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.StateDoor
{
    public class Door
    {
        AbstractState currentState;
        AbstractState nextState;

        public void goNext()
        {
            currentState.goNext(this);
        }
        public void SetState(AbstractState state)
        {
            currentState = state;
        }
        public void SetNext(AbstractState state)
        {
            if (state != null)
            {
                nextState = state; 
            } 
        }
    }
}
