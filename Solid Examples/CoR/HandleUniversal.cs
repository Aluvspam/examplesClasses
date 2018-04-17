using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.CoR
{
    public class HandleUniversal : AbstractHandler
    {
        private int x;
        public HandleUniversal(int numarul)
        {
            x = numarul;
        }
        public override void Handle(Request r)
        {
            if (CanHandle(r))
            {
                Console.Write(words[x]);
                r.Handled = true;
            }
            base.Handle(r);
        }
        protected bool CanHandle(Request r)
        {
            return (r.X % x == 0);
        }
    }
}
