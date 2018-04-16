using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateProject
{
    public class Context
    {
        private State current;

        public void GoNext()
        {
            current.goNext(this);
        }

        public void setState(State newState)
        {
            current = newState;
        }
    }
}
