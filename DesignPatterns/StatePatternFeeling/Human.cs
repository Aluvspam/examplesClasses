using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StatePatternFeeling
{
    public class Human
    {
        AbstractState currentState;
        AbstractState nextState;

        public void GoNext()
        {
            currentState.GoNext(this);
        }
        public void SetState(AbstractState state)
        {
            currentState = state;
            Console.WriteLine("new state: {0}", state.GetType().ToString().Substring(35));
            state.ToDo(this);
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
