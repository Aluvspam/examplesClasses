using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
namespace EventMVA
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer myTimer = new Timer(2000); //2 sec
                                             //unul din overloaded constr. al acestui timer, ne permite sa 
                                             //pasam intervalul in milisecunde
            myTimer.Elapsed += MyTimer_Elapsed; //atasez evenimentul MyTimer_Elapsed la event Elapsed

            myTimer.Elapsed += MyTimer_Elapsed1;

            myTimer.Start();

            Console.WriteLine("Press enter to remove the red event");

            Console.ReadLine();
            //
            myTimer.Elapsed -= MyTimer_Elapsed1;//sterg un eveniment

            Console.ReadLine();

        }

        private static void MyTimer_Elapsed1(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}" + e.SignalTime);
        }

        private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.White;
            //scriu codul care vreau sa se execute de fiecare data cand Elapsed este declansat
            Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}" + e.SignalTime);
        }

       
    }
    }

