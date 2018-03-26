using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.StateDaniel
{
    class Context
    {
        State current;

        public void goNext()
        {
            current.goNext(this);
        }
        public void setState(State state)
        {
            current = state;
        }
    }
}
