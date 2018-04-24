using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    class RandomStrategy : AbstractStrategy
    {
        Random rnd;
        public RandomStrategy()
        {
            rnd = new Random();
        }
        public override Moves MoveLikeABoss(AbstractTFTPlayer player)
        {
            return (rnd.Next(2) == 0) ? Moves.C : Moves.D;
        }
    }
}
