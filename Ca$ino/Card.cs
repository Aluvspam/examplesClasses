using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Card
    {
        public Card(int Number, string color)//Dana, imi cere constructor
        {

        }

        public CardNumber number 
        {
            get 
            { 
                return this.number; 
            }
            set 
            {
                this.number = value;
            }
        }


        public CardColor color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }


        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return string.Format("{0} of {1}", number, color);
        }
    }
}
