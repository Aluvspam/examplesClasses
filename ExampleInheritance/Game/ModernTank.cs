using ClassLibrary1;
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
            Crew[0] = new Person("Driver", DateTime.Now, null);
            Crew[1] = new Person("Gunner", DateTime.Now, null);
            Crew[2] = new Person("Mechanic", DateTime.Now, null);
            Crew[3] = new Person("Officer", DateTime.Now, null);
        }
    }
}
