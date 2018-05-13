using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    class TitForTat : AbstractStrategy
    {
        public override Moves MoveLikeABoss(AbstractTFTPlayer player)
        {
            var result = (player.hisLastMove == Moves.B) ? Moves.D : player.hisLastMove;
            return result;
        }
    }
}
