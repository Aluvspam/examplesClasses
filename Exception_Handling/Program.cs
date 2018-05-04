using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            label:
            try // Try block: The code which may raise exception at runtime
            {
               

                int num1, num2;
                decimal result;
                Console.WriteLine("Program impartire. Introduceti doua numere si returnam rezultatul: ");
                Console.WriteLine("Primul numar: ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduceti al doilea numar:");
                num2 = int.Parse(Console.ReadLine());
                result = (decimal)num1 / (decimal)num2;
                Console.WriteLine("Impartirea : " + result.ToString());
                Console.ReadLine();

                //------------------------------------------------

            }
            catch (DivideByZeroException dex) //The 'catch' block handle the exception if try block gets error 
            {

                Console.WriteLine("Ai introdus 0 0");
                Console.WriteLine("Mai multe detalii despre eroare: \n\n" + dex.ToString() + "\n\n");
                goto label;

            }
            catch       (FormatException fex)
            {
                Console.WriteLine("Intrare invalida");
                Console.WriteLine("Mai multe detalii despre eroare: \n\n" + fex.ToString() + "\n\n");
                goto label;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Othe Exception raised" + ex.ToString() + "\n\n");
                goto label;
            }
            finally //it always executes
            {
                Console.WriteLine("Finally Block: For Continue Press Enter and for Exit press Ctrl + c");
                Console.ReadLine();
            }

        }
    }
}
