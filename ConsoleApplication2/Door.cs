using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Door
    {
        IState currentState;
        //IState NextState;

        public void goNext()
        {
            currentState.goNext(this);
        }
        public void SetState(IState state)
        {
            currentState = state;
        }
        public void SetNext(AbstracteState )

    }
}
