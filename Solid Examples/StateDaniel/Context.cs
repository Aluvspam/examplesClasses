using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.StateDaniel
{
    class Context
    {
        State current;

        public override goNext()
        {
            current.goNext(this);
        }
        public void setState()
        {

        }
    }
}
