using System;

namespace Solid_Examples.StateDoor
{
    public class Door
    {
        AbstractState currentState;
        //AbstractState nextState;

        public void goNext()
        {
            currentState.goNext(this);
        }
        public void SetState(AbstractState state)
        {
            currentState = state;
            Console.WriteLine("new state: {0}", state.GetType());
            state.Execute(this);
        }
        public void SetNext(AbstractState state)
        {
            if (state != null)
            {
                //nextState = state; 
            }
        }
    }
}
