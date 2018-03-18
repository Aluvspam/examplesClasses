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
        public List <Point> Location = new List<Point>();
        private List <Person> Crew = new List<Person>();
        private int crewIndex;


        public AbstractUnit(Point[] location, int hp, int dmg, int crewSize = -1)
        {
            Location = location.ToList();
            HitPoint = hp;
            Damage = dmg;
            crewIndex = 0;
            Crew = new List<Person>();
            //int crew size = -1;
        }
        public abstract void InitCrew();
        protected void AddCrewMember(Person p)
        {
            List<Person> crew = new List<Person>();
            Crew.Add( p);
            

            crew[crewIndex] = p;
            crewIndex++;
        }
    }
}
