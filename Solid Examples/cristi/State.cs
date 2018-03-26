using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.cristi
{
   public abstract class State 
    {
        public abstract void goNext(Context context);
    }
}
