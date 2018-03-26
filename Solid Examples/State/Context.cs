using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.State
{
    public class Context
    {
        private AbstractState current;
        public void goNext()
        {
            current.goNext(this);
        }
        public void SetState(AbstractState state)
        {
            current = state;
        }
    }
}
