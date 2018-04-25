using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    class PlayLikeABoss : AbstractTFTPlayer
    {
        public override Moves FirstMove()
        {
            event1 += Event1Handler;
            return base.FirstMove();
        }



        public PlayLikeABoss()
        {
            strategy = new Capra();
        }
        public override Moves MyMove(Moves myLastMove, Moves othersLastMove)
        {
            if (othersLastMove == Moves.D)
            {
                strategy = new Atac();
            }
            return strategy.MoveLikeABoss(this);
        }
    }
}
