using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples
{
    class CristiClockLinesAngles
    {
        // Function to calculate the angle
        static int calcAngle(int h, int m)
        {
            // validate the input
            if (h < 0 || m < 0 ||
                h > 12 || m > 60)
                Console.Write("Wrong input");

            if (h == 12)
                h = 0;

            if (m == 60)
                m = 0;

            // Calculate the angles moved by hour and
            // minute hands with reference to 12:00
            int hour_angle = (int)(0.5 * (h * 60 + m));  //daca vreti sa calculati unghiul exact, in timp ce se misca si limba de ora, lasati asa, daca nu, stergeti "+m"
            int minute_angle = (int)(6 * m);

            // Find the difference between two angles
            int angle = Math.Abs(hour_angle - minute_angle);

            // smaller angle of two possible angles
            angle = Math.Min(360 - angle, angle);

            return angle;
        }

        // Driver code
        public static void Main()
        {
            Console.WriteLine(calcAngle(8, 5));
            // Console.Write(calcAngle(3, 30));
            Console.ReadLine();
        }
    }
}
