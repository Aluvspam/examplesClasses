using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternChainOfResponsibility
{
    class HandlerTwo : Handler
    {
        public bool request;
        public  void handle()
        {
            if (CanHandle(request))
            {
                Console.WriteLine("Handle it");
            }
            else
            {
                super.handle();
            }
        }
        public bool CanHandle(bool request)
        {
            return (request);
        }
    }
}
