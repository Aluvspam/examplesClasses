using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    class TFTPlayerMean : AbstractTFTPlayer
    {
        public override Moves FirstMove()
        {
            return Moves.D;
        }
    }
}
