using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreiShaormaDecoratorPattern
{
    public class ComandaRun
    {
        public static void Execute()
        {
            ShaormaComponent DePui = new PuiDecorator(new ShaormaLaPachetBase());
            Convert.ToString(DePui);
        }
        public static void (ShaormaComponent sBase)
        {
            Console.WriteLine("Ati comandat o {0} cu: {1}",  );
        }


    }
}
