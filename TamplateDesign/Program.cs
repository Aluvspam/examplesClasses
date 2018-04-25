using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamplateDesign
{
    public class Program
    {
        public static void Main()
        {
            AplicationClassOne masina1 = new AplicationClassOne();
            masina1.TemplateMethod();
            AplicationClassTwo masina2 = new AplicationClassTwo();
            masina2.TemplateMethod();
        }
    }
}
