using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern_Dana_
{
    public class Context
    {

        IState current;
         
        public void goNext()
        {
            current.goNext(this);//obiectul de tipul asta
        }
        public void setState(IState state )
        {
            current = state;
        }
    }
}
