using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnghiCeas
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 20;
            int min = 5;

            int totalAngle = 360;
            int angleHour = totalAngle / 12;
            int angleMin = totalAngle / 60;
            int neededAngle = angleHour * 5;

            Console.WriteLine("Unghiul dintre limbile ceasului pentru ora 20:05, este: {0}", neededAngle );
            
            Console.ReadLine();
        }
    }
}
