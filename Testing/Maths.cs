using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class Maths
    {
        private int calculatePower(int Base, int Exponent)
        {
            int Product = 1;
            for (int i = 1; i <= Exponent; i++)
            {
                Product = Product * Base;
            }
            return Product;
        }
    }
}
