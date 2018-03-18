using ClassLibrary1;
using System;
using System.Collections.Generic;

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
			
            AddCrewMember(new Person("Driver", DateTime.Now, null));
            AddCrewMember(new Person("Gunner", DateTime.Now, null));
            AddCrewMember(new Person("Mechanic", DateTime.Now, null));
        }
    }
}
