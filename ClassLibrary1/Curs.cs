using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Curs
    {
        public List<Student> Students { get; set; }
        public Teacher Teacher { get; set; }
        public string Classname { get; set; }
        public int Year { get; set; }
        public Category Category { get; set; }
        public Orar Orar { get; set; }
        public Curs(string numeCurs, int an, Teacher teacher)
        {
            Classname = numeCurs;
            Year = an;
            Teacher = teacher;
            Students = new List<Student>();
        }
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
        public void AddTeacher(Teacher teacher)
        {
            Teacher = teacher;
        }
        public override string ToString()
        {
            var result = "";
            result += "Curs " + Classname + Environment.NewLine;
            result += Constants.tab + "Categoria: " + Category + Environment.NewLine;
            result += Constants.tab + "orar: " + Orar + Environment.NewLine;
            result += Constants.tab + "profesor: " + Teacher + Environment.NewLine;
            foreach (var student in Students)
            {
                result += Constants.tab + "student: " + student + Environment.NewLine;
            }
            return result;
        }
    }
}
