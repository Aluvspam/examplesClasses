using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class Student : Person
    {
        #region Properties
        public List<Curs> Classes { get; set; }
        public Dictionary<Curs, int> Grades { get; set; }
        #endregion
        #region Constructors
        public Student(string name, DateTime dob, Address address) : base(name, dob, address)
        {
            Classes = new List<Curs>();
            Grades = new Dictionary<Curs, int>();
        }
        #endregion
        public void AddClass(Curs curs)
        {
            Classes.Add(curs);
        }
        public void AddGrade(Curs curs, int grade)
        {
            Grades.Add(curs, grade);
        }
    }
}
