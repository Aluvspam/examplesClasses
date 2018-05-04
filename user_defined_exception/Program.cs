using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_defined_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            int acceptorder;
            Console.WriteLine("Welcome to Shopping Site:\nHow many TV you want to buy (Total 10 in Stock):");
            acceptorder = Convert.ToInt32(Console.ReadLine());
            try
            {
                if(acceptorder ==10 || acceptorder <10)
                {
                    Console.WriteLine("Congratulations! You have bought {0} TV", acceptorder);
                    Console.ReadLine();
                }
                else
                {
                    throw (new OutofStockException("OutofStockException Generated: The number of item you want to buy is out of stock. Please enter total item number within stock"));
                }
            }
            catch(OutofStockException oex)
            {
                Console.WriteLine(oex.Message.ToString());
                Console.ReadLine();
            }
          
        }
        public class OutofStockException : Exception
        {
            public OutofStockException(string message)
                :base(message)
            {

            }

        }
    }


}
