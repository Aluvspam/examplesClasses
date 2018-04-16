using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodGameGabi
{
    class SimpleMap : AbstractGameMap
    {
        public SimpleMap()
        { 
             details = "outside walls";
             Console.WriteLine(details);
        }
    }
}

