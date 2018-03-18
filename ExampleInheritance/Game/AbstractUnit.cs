//varianta A
using ClassLibrary1;

namespace Solid_Examples.Game
{
    public abstract class AbstractUnit
    {
        public int HitPoint;
        public int Damage;
        public int RateOfFire;//time between 2 consecutive hits in miliseconds
        public Point[] Location;
        public Person[] Crew;

        public AbstractUnit(Point[] location, int hp, int dmg, int crewSize)
        {
            Location = location;
            HitPoint = hp;
            Damage = dmg;
            Crew = list<Person>;
            Crew.Add(new Person(new Point[1] {new Point (0, 9)} ));
        }
        public abstract void InitCrew();

    }
}
