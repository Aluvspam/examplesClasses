using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs20.cristi
{
    class Lvl1 : AbstractGame
    {
        public override AbstractGameMap LoadEnvironment()
        {
            return new EmptyMap();
        }
        public Lvl1()
        {
            LoadEnvironment();
        }
    }
}
