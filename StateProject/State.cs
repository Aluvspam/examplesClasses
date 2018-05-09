using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateProject
{
    public abstract class State
    {
        public abstract void goNext(Context inContext);
    }
}
