//varianta B
using ClassLibrary1;
using System.Collections.Generic;

namespace Solid_Examples.Game
{
    public abstract class AbstractUnit
    {
        public int HitPoint;
        public int Damage;
        public int RateOfFire;//time between 2 consecutive hits in miliseconds
        public Point[] Location;
        private List<Person> crew = new List<Person>;
        private int crewIndex;
		int crewSize = -1;

        public AbstractUnit(Point[] location, int hp, int dmg, int crewSize)
        {
            Location = location;
            HitPoint = hp;
            Damage = dmg;
            crewIndex = 0;
            crew = new List<Person>(crewSize);
			
		}
        public abstract void InitCrew();
        protected void AddCrewMember(Person p)
        {
            crew[crewIndex] = p;
            crewIndex++;
        }
    }
}
