using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    class Program
    {


        static void Main(string[] args)
        {
            Dice d = new Dice();
            Dice c = new Dice();
            Dice a = new Dice();
            Dice x = new Dice();
            Console.WriteLine(string.Join(" ", d.RollDice()));
            Console.WriteLine(string.Join(" ", c.RollDice()));
            Console.WriteLine(string.Join(" ", a.RollDice()));
            Console.WriteLine(string.Join(" ", x.RollDice()));
            DeckOfCards.Execute();
            ClasaTest C = new ClasaTest();
            Console.WriteLine(C.CatCostaOPaine);
            Console.ReadLine();
            //DeckOfCards.Execute();
        }
    }
    public class ClasaTest
    {
        public int CatCostaOPaine
        {
            get
            {
                return this.CatCostaOPaine;
            }
            set
            {
                CatCostaOPaine = value;
            }
        }


    }
}