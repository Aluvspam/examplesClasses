using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.State
{
    public abstract class AbstractState
    {
        public abstract void goNext( Context InContext);
    }
}
