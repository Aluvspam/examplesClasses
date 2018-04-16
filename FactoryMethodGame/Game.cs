using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodGame
{
    public abstract class Game
    {
        public AbstractGameMap map;
        public abstract AbstractGameMap LoadEnvironment();
        public virtual void PrintMapDetails()
        {
            Console.WriteLine(map.details);
        }
    }

    class Level1 : Game
    {
        public Level1()
        {
            map = LoadEnvironment();
        }

        public override AbstractGameMap LoadEnvironment()
        {
            return new EmptyMap();
        }
    }

    class Level2 : Game
    {
        public Level2()
        {
            map = LoadEnvironment();
        }

        public override AbstractGameMap LoadEnvironment()
        {
            return new SimpleMap();
        }
    }

}
