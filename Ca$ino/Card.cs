using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Card 
    {
        private string suit;
        private string rank;

        public Card(string CardRank, string CardSuit)
        {
            suit = CardSuit;
            rank = CardRank;
        }
        //public CardNumber number
        //{
        //    get
        //    {
        //        return this.number;
        //    }
        //    set
        //    {
        //        this.number = value;
        //    }
        //}


        //public CardSuit color

        //{
        //    get
        //    {
        //        return this.color;
        //    }
        //    set
        //    {
        //        this.color = value;
        //    }
        //}


        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return rank + " of " + suit;
        }
    }
}
