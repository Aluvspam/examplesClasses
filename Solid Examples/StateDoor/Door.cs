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
        public void goNext()
        {
            currentState.goNext(this);
        }
        public void SetState 
        public abstract void goNext(Door door);
    }
}
