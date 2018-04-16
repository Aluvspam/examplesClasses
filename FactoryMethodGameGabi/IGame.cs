using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodGameGabi
{
    public interface IGame
    {
        AbstractGameMap LoadEnvironment();

        void PrintMapDetails();
    }
}
