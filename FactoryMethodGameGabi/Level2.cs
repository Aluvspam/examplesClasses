using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodGameGabi
{
    public class Level2 : IGame
    {
        public AbstractGameMap LoadEnvironment()
        {
            return new EmptyMap();
        }

        public void PrintMapDetails()
        {
            throw new NotImplementedException();
        }
    }
}
