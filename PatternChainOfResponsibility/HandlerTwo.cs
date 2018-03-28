using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternChainOfResponsibility
{
    public class HandlerTwo : Handler
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