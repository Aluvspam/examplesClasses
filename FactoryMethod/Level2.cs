using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Level2 : AbstractGame
    {
        public Level2()
        {
               
        }
        public override AbstractGameMap LoadEnviroment()
        {
            return new SimpleMap();
        }
    }
}
