using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
     public class SimpleMap: AbstractGameMap
    {
        public override string details
        {
            get
            {
                return "outside walls";
            }

            set
            {
                details = value;
            }
        }
        public SimpleMap()
        {
           
            Console.WriteLine(details);
        }
    }
}
