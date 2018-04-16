using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs20.cristi
{
    public abstract class AbstractGame : Igame
    {
        public abstract AbstractGameMap LoadEnvironment();
        public AbstractGameMap map;
        public virtual void PrintDetails()
        {
            Console.WriteLine(map.details);
        }
    }
}
