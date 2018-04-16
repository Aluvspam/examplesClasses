using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
   public class StateClose
    {
        public void goNext(Door door)
        {
            door.SetState(new Openning());
        }
    }
}
