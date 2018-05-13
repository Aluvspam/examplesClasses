using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    class Player2 : AbstractTFTPlayer
    {
        public Player2()
        {
            strategy = new Capra();
            Subscribe(2, Event2Handler);
        }
        public override Moves FirstMove()
        {
            strategy = new Atac();
            Invoke1();
            return base.FirstMove();
        }
        //protected override void WhenIInvoke1()
        //{
        //    strategy = new Capra();
        //}

        protected override void Event2Handler()
        {
            strategy = new Capra();
        }
        public override Moves MyMove(Moves myLastMove, Moves othersLastMove)
        {
            return strategy.MoveLikeABoss(this);
        }
    }
}
