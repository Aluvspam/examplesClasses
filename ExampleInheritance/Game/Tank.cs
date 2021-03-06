﻿using ClassLibrary1;
using System;

namespace Solid_Examples.Game
{
    public class Tank : AbstractUnit
    {
        public int Armor;
        public int Range;
        public Tank(Point[] location) : base(location, 400, 25, 3)
        {
            Armor = 100;
            Range = 12;
        }
        public override void InitCrew()
        {
            Crew.Add(new Person("Driver", DateTime.Now, null));
            Crew.Add(new Person("Gunner", DateTime.Now, null));
            Crew.Add(new Person("Mechanic", DateTime.Now, null));
        }
    }
}
