using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTFT();
        }

        private static void RunTFT()
        {
            IPlayer luana = new LuanaPlayer();
            IPlayer andrei = new AndreiPlayer();
            IPlayer random = new RandomPlayer();
            IPlayer oana = new OanaPlayer();
            IPlayer random2 = new RandomPlayer2();
            IPlayer tftnice = new TFTPlayer();
            //var game = new Game(luana, andrei);
            //var game = new Game(random, andrei);
            //var game = new Game(random, luana);
            //var game = new Game(random2, luana);
            //var game = new Game(random2, random);
            //var game = new Game(random2, andrei);
            //var game = new Game(tftnice, luana);
            //var game = new Game(tftnice, random);
            //var game = new Game(tftnice, random2);
            //var game = new Game(tftnice, andrei);
            var game = new Game(oana, andrei);

            game.RunGame();
            Console.ReadLine();
        }
    }
}
