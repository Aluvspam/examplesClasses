using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternChainOfResponsibility
{
    public class Handler
    {
        protected Handler super;
        protected Handler nextHandler;

        public void handle()
        {
            nextHandler.handle();
        }
    }
}
