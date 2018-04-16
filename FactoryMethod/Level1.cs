using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Level1 : AbstractGame
    {
        public Level1()
        {
            LoadEnviroment();
        }
        public override AbstractGameMap LoadEnviroment()
        {
            return new EmptyMap();
        }
    }
}
