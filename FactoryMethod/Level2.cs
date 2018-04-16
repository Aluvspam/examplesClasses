using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Level2 : IGame
    {
        public AbstractGameMap LoadEnviroment()
        {
            return new SimpleMap();
        }

        public void PrintMyDetails()
        {
            Console.WriteLine();
        }
    }
}
