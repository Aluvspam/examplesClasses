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
            DeckOfCards deck = new DeckOfCards();
           
            deck.Shuffle(Card [] );
            for (int i = 0; i < 52; i++)
            {
                Console.WriteLine("{0}", deck.PullCard());

            }
            Console.ReadLine();
        }
    }
}