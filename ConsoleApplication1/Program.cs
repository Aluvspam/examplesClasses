using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamplateDesign;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            TamplateDesign.Program.Main();
          
            List<string> catalog = new List<string>()
            {
                "andrei", "ana", "cristi", "elena"
            };
            catalog.ForEach(w => Console.Write(" " + w));
            Console.WriteLine();
            foreach( var i in catalog)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(string.Join(" ", catalog));
            Console.ReadLine();
        }
    }
}
