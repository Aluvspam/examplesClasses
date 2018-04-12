using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.AndreiR
{
    public class Dog : AbstractEntity
    {
        public Dog()
        {
            name = "dog";
            moveStrategy = new Running4Feet();
        }
    }
}
