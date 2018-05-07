using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    class Player2 : AbstractTFTPlayer
    {
        public override Moves FirstMove()
        {
            event2 += Event2Handler;
            Invoke1();
            strategy = new Atac();
            return base.FirstMove();
        }

        public override void Event2Handler()
        {
            strategy = new Capra();
        }

        public Player2()
        {
            strategy = new Capra();
        }
        public override Moves MyMove(Moves myLastMove, Moves othersLastMove)
        {
            return strategy.MoveLikeABoss(this);
        }
    }
}
