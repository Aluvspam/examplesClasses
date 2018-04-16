using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class EmptyMap: AbstractGameMap
    {
        public override string details
        {
            get
            {
                return "no walls";
            }
            set
            {
                details = value;
            }
        }
        public EmptyMap()
        {
            Console.WriteLine(details);
        } 
    }
}
