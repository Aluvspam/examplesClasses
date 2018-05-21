using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WinformWriteDana
{
    public class WriteDana
    {
        public void WriteIt(string text)
        {
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" {0} {1} {2} ", '\u2660', text.ToUpper(), '\u2660');
                }
                Console.WriteLine();
            }
            for (int i = 7; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" {0} {1} {2} ", '\u2663', text.ToUpper(), '\u2663');
                }
                Console.WriteLine();
            }
        }
    }
}
