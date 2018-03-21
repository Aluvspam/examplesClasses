using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid_Examples
{
    public class birdDaniel : IMove
    {
        string name = "bird";

        public void Move()
        {
            Console.WriteLine("I am a {0} and I fly", name);
        }
    }
}