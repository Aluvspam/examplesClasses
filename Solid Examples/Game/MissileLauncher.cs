using ClassLibrary1;
using System;

namespace Solid_Examples.Game
{
    public class MissileLauncher : AbstractUnit
    {
        public int Range;
        public MissileLauncher(Point[] location) : base(location, 125, 50, 2)
        {
            Range = 24;
        }
        public override void InitCrew()
        {
            AddCrewMember(new Person("Driver", DateTime.Now, null));
            AddCrewMember(new Person("Gunner", DateTime.Now, null));
        }
    }
}
