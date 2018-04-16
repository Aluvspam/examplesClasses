using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Door
    {
        AbstractState currentState;
        //AbstractState NextState;

        public void goNext()
        {
            currentState.goNext(this);
        }
        public void SetState(AbstractState state)
        {
            Console.WriteLine("new state: {0}", state.GetType());
            state.Execute(this);
        }
        public void SetNext(AbstractState state)
        {
            if (state != null)
            {
                //next state = state;
            }
        }

    }
}
