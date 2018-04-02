using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.ChainOfResponsibility
{
    public abstract class Handler
    {
        protected Handler super;
        private Handler nextHandler;

        public virtual void Handle()
        {
            nextHandler.Handle();
        }
    }
}
