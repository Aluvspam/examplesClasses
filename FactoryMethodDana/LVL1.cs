using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDana
{
    public class LVL1: AbsGame
    {
        public LVL1()
        {
            Map = LandEnvironment;
        }
        public override AbstractGameMap LandEnvironment();
        {
       return new EmptyMap();
        }
      
    }
}
