using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class Maths
    {
        //testare metoda privata statica
        private static int calculatePower(int Base, int Exponent)
        {
            int Product = 1;
            for (int i = 1; i <= Exponent; i++)
            {
                Product = Product * Base;
            }
            return Product;
        }
        //testare metoda privata
        private int calculatePower1(int Base, int Exponent)
        {
            int Product = 1;
            for (int i = 1; i <= Exponent; i++)
            {
                Product = Product * Base;
            }
            return Product;
        }
        public static int Divide(int numerator, int denominator)
        {
            int result = numerator / denominator;
            return result;
        }
    }
}
