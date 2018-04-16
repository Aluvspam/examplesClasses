using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public abstract class AbstractState
    {
        public abstract void Execute(Door door);
        public abstract void goNext(Door door);
    }
}
