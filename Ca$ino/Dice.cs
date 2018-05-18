using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Casino
{
    public class Dice
    {
        private int die1;
        private int die2;
        public int Die1
        {
            get { return die1; }
            set { die1 = value; }
        }
        public int Die2
        {
            get { return die2; }
            set { die2 = value; }
        }
        public void RollDice()
        {
            Random random1 = new Random();
            Die1 = random1.Next(1, 6);
            Die2 = random1.Next(1, 6);
        }
    }
}
