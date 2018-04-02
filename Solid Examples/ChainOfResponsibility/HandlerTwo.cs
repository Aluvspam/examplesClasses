using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.ChainOfResponsibility
{
    class HandlerTwo : Handler
    {
        public override void Handle()
        {
            if (CanHandle())
            {
                this.CanHandle();
            }
            else
            {
                super.Handle();
            }
        }
        private bool CanHandle()
        {
            throw new NotImplementedException();
        }
    }
}



