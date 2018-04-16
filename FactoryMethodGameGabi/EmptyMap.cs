using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodGameGabi
{
    class EmptyMap : AbstractGameMap
    {
        public EmptyMap()
        {
            details = "no walls";
            Console.WriteLine(details);
        }
    }
}
