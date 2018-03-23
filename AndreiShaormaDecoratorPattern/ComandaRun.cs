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
            Print(DePui);
            ShaormaComponent DeVita = new VitaDecorator(new LaFarfurieBase(new RosiiDecorator(new CastravetiMuratiDecorator(new CeapaDecorator(new VarzaDecorator())))));
        }
        public static void Print (ShaormaComponent cBase)
        {
            Console.WriteLine("Ati comandat o {0}, pret: {1} lei.", cBase.GetName(), cBase.GetPrice() );
        }


    }
}
