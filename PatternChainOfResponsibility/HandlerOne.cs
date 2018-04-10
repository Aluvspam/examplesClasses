using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternChainOfResponsibility
{
    class HandlerOne : Handler
    {
        public override void HandleRequest()
        {
            if (CanHandle())
            {
                CanHandle();
            }
            else
            {
                super.HandleRequest();
            }
        }
        public bool CanHandle()
        {
            return true;
        }
    }
}
   