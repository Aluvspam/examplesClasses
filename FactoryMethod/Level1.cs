using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Level1 : IGame
    {
        
        AbstractGameMap IGame.LoadEnviroment()
        {
            return new EmptyMap();
        }

        void IGame.PrintMyDetails()
        {
            Console.WriteLine();
        }
    }
}
