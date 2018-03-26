using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern_Dana_
{
    public class SateOne: IState
    {
        public  void goNext(Context inContext)
        {
            inContext.setState(new StateTwo());
        }
    }
}
