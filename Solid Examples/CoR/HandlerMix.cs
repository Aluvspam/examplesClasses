using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.CoR
{
    public class HandlerMix : AbstractHandler
    {
        public override void Handle(Request r)
        {
            if (CanHandle(r))
            {
                if (r.X == 7)
                {
                    Console.WriteLine(words[7]);
                    r.Handled = true;
                }
                else if (r.X == 11)
                {
                    Console.WriteLine(words[11]);
                    r.Handled = true;
                }
                else if( r.X == 13)
                {
                    Console.WriteLine(words[13]);
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
