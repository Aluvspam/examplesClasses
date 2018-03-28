using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternChainOfResponsibility
{
    public abstract class Handler
    {
        protected Handler super;
        protected Handler nextHandler;

        public abstract void HandleRequest();
    }
}



