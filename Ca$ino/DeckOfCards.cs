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
            IEnumerable<CardRank> rank;
           string [] rank = { };
            string[] suit = { };
            currentCard = 0;
            ranNum = new Random();
            initialSet = new Card[numberOfCard];
            for (int count = 0; count < initialSet.Length; count++)
            
                initialSet[count] = new Card(rank<count % 11> , suit[count / 13]);
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
        public static void Shuffle(Card[] initialSet)
        {
            int n = initialSet.Length;
            for (int i = 0; i < n; i++)
            {
                int random = i + ranNum.Next(n - i);
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
                if (i%4==0)
                {
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
        
    }
}

