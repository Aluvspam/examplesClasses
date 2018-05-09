using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    class PlayLikeABoss : AbstractTFTPlayer
    {
        public PlayLikeABoss()
        {
            strategy = new Capra();
            Subscribe(1, Event1Handler);
        }
        public override Moves FirstMove()
        {
            return base.FirstMove();
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
