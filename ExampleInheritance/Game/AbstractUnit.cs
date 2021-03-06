﻿//varianta A
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
        public List<Person> Crew;

        public AbstractUnit(Point[] location, int hp, int dmg, int crewSize = -1)
        {
            Location = location;
            HitPoint = hp;
            Damage = dmg;
            Crew = new List<Person>();
        }
        public abstract void InitCrew();
    }
}
