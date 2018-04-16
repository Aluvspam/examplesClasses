using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodGame
{
    public abstract class AbstractGameMap
    {
        public string details;
    }

    class EmptyMap : AbstractGameMap
    {
        public EmptyMap()
        {
            details = "no walls";
            Console.WriteLine(details);
        }
    }

    class SimpleMap : AbstractGameMap
    {
        public SimpleMap()
        {
            details = "outside walls";
            Console.WriteLine(details);
        }
    }
}
