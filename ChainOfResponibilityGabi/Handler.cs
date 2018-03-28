using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponibilityGabi
{
    public class Handler
    {
        private Handler super;
        private Handler nextHandler;

        public void Handle()
        {
            nextHandler.Handle();
        }
    }
}
