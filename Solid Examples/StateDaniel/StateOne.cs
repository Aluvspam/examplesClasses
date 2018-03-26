using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.StateDaniel
{
    class StateOne : State
    {
        public void goNext(Context context)
        {
            context.setState(new StateTwo());
        }
    }
}
