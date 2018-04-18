using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDana
{
    public class LVL2: AbsGame
    {
        public LVL2()
        {
            Map = LandEnvironment();
        }
        public override AbstractGameMap LandEnvironment()
        {
            return new EmptyMap();
        }
    }
}
