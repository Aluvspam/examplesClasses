using System;

namespace Solid_Examples.Game
{
    public class Marine : AbstractUnit
    {
        public int Range;
        public Marine(Point[] loc) : base(loc, 10, 4, 1)
        {
            Range = 4;
        }

        public override void InitCrew()
        {
            Crew.Add(new ClassLibrary1.Person("Marine", DateTime.Now, null));
        }
    }
}
