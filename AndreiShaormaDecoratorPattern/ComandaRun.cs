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
            ShaormaComponent DeVita = new VitaDecorator(new RosiiDecorator(new CastravetiMuratiDecorator(new CeapaDecorator(new VarzaDecorator(new LaFarfurieBase())))));
            Print(DeVita);
            ShaormaComponent dePui = new PuiDecorator(new RosiiDecorator(new CastravetiMuratiDecorator(new CeapaDecorator(new VarzaDecorator(new LaFarfurieBase())))));
            Print(dePui);
        }
        public static void Print (ShaormaComponent cBase)
        {
            Console.WriteLine("Ati comandat o {0} total de plata: {1} lei.", cBase.GetName(), cBase.GetPrice());
        }


    }
}
