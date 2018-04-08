using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples
{
    class B2
    {
        AClass myThing = new AClass();
        public void Execute()
        {
            myThing.DoCeva();
            myThing.ceva = 2;
            myThing.altceva = "2";
        }
    }
}
