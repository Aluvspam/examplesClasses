using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid_Examples
{
    public class World

    {
        string color;
        string sex;
        IMove myPet;

        public World(IMove something)
        {
            myPet = something;
        }

        public void execute(World animal)
        {
            myPet.Move();
        }
    }
}