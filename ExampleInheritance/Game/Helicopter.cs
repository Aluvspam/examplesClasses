using ClassLibrary1;
using System;

namespace Solid_Examples.Game
{
    public class Helicopter : AbstractUnit
    {
        public int Altitude;
        public int Range;
        public Helicopter(Point[] location) : base(location, 100, 35, 4)
        {
            Altitude = 0;
        }

        public override void InitCrew()
        {
            Crew[0] = (new Person("Captain", DateTime.Now, null));
            Crew[1] = (new Person("Gunner", DateTime.Now, null));
            Crew[2] = (new Person("Gunner2", DateTime.Now, null));
            Crew[3] = (new Person("1stOfficer", DateTime.Now, null));
        }
    }
}
