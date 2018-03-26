using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern_Dana_
{
    public interface IState
    {
         void goNext(Context inContext);
        
    }
}
