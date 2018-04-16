using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodGameGabi
{
    public abstract class Level2 : IGame
    {
        public AbstractGameMap LoadEnvironment()
        {
            return new SimpleMap();
        }

        public void PrintMapDetails()
        {
            throw new NotImplementedException();
        }
    }
}
