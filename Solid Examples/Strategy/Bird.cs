using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.AndreiR
{
    public class Bird : AbstractEntity
    {
        public Bird()
        {
            name = "Bird";
            moveStrategy = new Flying();
        }
    }
}
