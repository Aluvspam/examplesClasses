using ClassLibrary1;
using System;

namespace Solid_Examples.Game
{
    public class Helicopter : AbstractUnit
    {
        public int altitude;
        public Helicopter(Point[] location) : base(location, 100, 35, 4)
        {
            altitude = 0;
        }

        public override void InitCrew()
        {
            AddCrewMember(new Person("Captain", DateTime.Now, null));
            AddCrewMember(new Person("Gunner", DateTime.Now, null));
            AddCrewMember(new Person("Gunner2", DateTime.Now, null));
            AddCrewMember(new Person("1stOfficer", DateTime.Now, null));
        }
    }
}
