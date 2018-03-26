using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.State
{
    public class StateOne : AbstractState
    {
        public override void goNext(Context InContext)
        {
            InContext.SetState(new StateOne());
        }
    }
}
