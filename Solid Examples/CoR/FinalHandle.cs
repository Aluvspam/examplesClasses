using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.CoR
{
    public class FinalHandle : AbstractHandler
    {
        public override void Handle(Request r)
        {
            if (!r.Handled)
            {
                Console.Write(r.X);
            }
            Console.WriteLine();
        }
    }
}
