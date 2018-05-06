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
            IPlayer daniel = new DanielPlayer();
            IPlayer luana = new LuanaPlayer();
            IPlayer andrei = new AndreiPlayer();
            //IPlayer random = new RandomPlayer();
            IPlayer oana = new OanaPlayer();
            IPlayer dana = new DanaPlayer();
            IPlayer random2 = new RandomPlayer2();
            IPlayer tftnice = new TFTPlayernice();
            IPlayer meanTFT = new TFTPlayerMean();
            IPlayer andreiMF = new AndreiMFPlayer();
            IPlayer error = new PlayerWithError();
            IPlayer cristi = new CristiPlayer();
            IPlayer cristi2 = new CristiSecondPlayer();
            var game = new Game(cristi, cristi2);
            //var game = new Game(meanTFT, andreiMF);
            //var game = new Game(dana, andrei);
            //var game = new Game(dana, random);
            //var game = new Game(dana, random2);

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
            //var game = new Game(oana, andrei);
            //var game = new Game(oana, luana);
            //var game = new Game(oana, random);
            //var game = new Game(oana, random2);
            //var game = new Game(oana, tftnice);
            try
            {
                game.RunGame();
            }
            catch (Exception)
            {
                Console.WriteLine("Ai gresit jocu' baiatu meu!");
            }
            Console.ReadLine();
        }
    }
}
