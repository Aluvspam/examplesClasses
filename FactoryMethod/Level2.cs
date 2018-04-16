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
            LoadEnviroment();
        }
        public override AbstractGameMap LoadEnviroment()
        {
            return new SimpleMap();
        }
        public override void PrintDetails()
        {
            var level2 = new SimpleMap().details;
            Console.WriteLine(level2);
        }
    }
}
