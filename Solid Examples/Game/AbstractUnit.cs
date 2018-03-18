//varianta B
using ClassLibrary1;
using System.Collections.Generic;
using System.Linq;

namespace Solid_Examples.Game
{
    public abstract class AbstractUnit
    {
        public int HitPoint;
        public int Damage;
        public int RateOfFire;//time between 2 consecutive hits in miliseconds
        public List<Point> Location = new List<Point>();
        private List<Person> crew = new List<Person>();
        private int crewIndex;

        public AbstractUnit(Point[] location, int hp, int dmg, int crewSize = -1)
        {
            Location = location;
            HitPoint = hp;
            Damage = dmg;
            crewIndex = 0;
            crew = new List<Person>();
        }
        public abstract void InitCrew();
        protected void AddCrewMember(Person p)
        {
            crew.Add(p);
            crewIndex++;
        }
    }
}
