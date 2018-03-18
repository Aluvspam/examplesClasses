using System;

namespace ClassLibrary1
{
    public class Teacher : Person
    {
        public int Wage { get; set; }

        public Teacher(string name, DateTime dob, Address address, int wage) : base(name, dob, address)
        {
            Wage = wage;
        }

        public void SetWage(int newWage)
        {
            Wage = newWage;
        }
    }
}
