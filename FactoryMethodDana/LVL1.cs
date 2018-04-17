using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDana
{
    public class LVL1 : AbsGame
    {
        
        public override AbstractGameMap LandEnvironment()
        {
         return  new EmptyMap();
    }


    }
}