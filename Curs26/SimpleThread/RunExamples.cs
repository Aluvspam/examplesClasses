using System;

namespace Curs26.SimpleThread
{
    public class RunExamples
    {
        public static void Run()
        {
            Game game = new Game("First game", 333);

            while (true)
            {
                var c = Console.Read();
                switch (c)
                {
                    case 's':
                        game.Start();
                        break;
                    case 'e':
                        game.Stop();
                        break;
                    case 'p':
                        game.Suspend();
                        break;
                    case 'r':
                        game.Resume();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
