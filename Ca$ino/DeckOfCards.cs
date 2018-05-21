using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class DeckOfCards
    {

        private static Card[] initialSet;
        private static Random ranNum;
        private int currentCard;
        private int numberOfCard = 52;

        public DeckOfCards()
        {
            string[] rank = { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace " };

            string[] suit = { "Club \u2663 ", "Diamond \u2666", "Spade \u2660", "Heart \u2665" };
            currentCard = 0;
            ranNum = new Random();
            initialSet = new Card[numberOfCard];
            //populez pachetul de carti
            for (int count = 0; count < initialSet.Length; count++)

                initialSet[count] = new Card(rank[count % 13], suit[count / 13]);
        }
        public Card PullCard()
        {
            if (currentCard < initialSet.Length)
            {
                return initialSet[currentCard++];

            }
            else
            {
                return null;
            }
        }
        public static void Shuffle(Card[] initialSet)//TO DO: cu liste 
        {
            int n = initialSet.Length;
            for (int i = 0; i < n; i++)
            {
                int random = i + ranNum.Next(n - i);//i + (0...51)?
                // partea de jos e o schimbare ca la Bubble 
                var temp = initialSet[random];
                initialSet[random] = initialSet[i];
                initialSet[i] = temp;
            }
        }

        public static void Execute()
        {
            DeckOfCards deck = new DeckOfCards();
            Shuffle(initialSet);
            for (int i = 0; i < 52; i++)
            {
                Console.WriteLine("{0, -19}", deck.PullCard());
                if (i % 4 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
       
    }
}
