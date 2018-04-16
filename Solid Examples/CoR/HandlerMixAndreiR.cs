using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.CoR
{
    public class HandlerMixAndreiR : AbstractHandler
    {
        public override void Handle(Request r)
        {
            if (CanHandle(r))
            {
                if (r.X == 7 || r.X == 11 || r.X == 13)
                {
                    int n = r.X;
                    Console.Write(words[n]);//made by Andrei Roca
                    r.Handled = true;
                }
            }
            base.Handle(r);
        }
        protected bool CanHandle(Request r)
        {
            bool isTrue = false;
            if(r.X == 7 || r.X == 11 || r.X == 13)
            {
                isTrue = true;
            }
            return isTrue;
        }
    }
}
