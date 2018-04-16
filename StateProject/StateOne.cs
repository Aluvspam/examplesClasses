using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateProject
{
    class StateOne : State
    {
        

        public override void goNext(Context inContext)
        {
            inContext.setState(new StateOne());
        }
    }
}
