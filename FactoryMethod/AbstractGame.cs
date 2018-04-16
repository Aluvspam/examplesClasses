using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class AbstractGame : IGame
    {
        public abstract AbstractGameMap LoadEnviroment();
        protected AbstractGameMap map;
        public virtual void PrintDetails()
        {
            Console.WriteLine(map.details);
        }
    }
}
