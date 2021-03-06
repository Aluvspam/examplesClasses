﻿using ClassLibrary1;
using System;

namespace Solid_Examples.Game
{
    public class ModernTank : AbstractUnit
    {
        public int Armor;
        public int Range;
        public ModernTank(Point[] location) : base(location, 500, 30, 4)
        {
            Armor = 120;
            Range = 14;
        }
        public override void InitCrew()
        {
            AddCrewMember(new Person("Driver", DateTime.Now, null));
            AddCrewMember(new Person("Gunner", DateTime.Now, null));
            AddCrewMember(new Person("Mechanic", DateTime.Now, null));
            AddCrewMember(new Person("Officer", DateTime.Now, null));
        }
    }
}
