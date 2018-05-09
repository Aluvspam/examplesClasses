using System;
using System.Threading;

namespace Curs26.SimpleThread
{
    public class Game
    {
        private Thread player1Thread;
        private Thread player2Thread;
        private string gameName;
        private int sleepTime;
        private int counter = 0;
        private Random random = new Random();
        private object lock1 = new object();

        bool started = false;
        bool running = false;

        public Game(string name, int sleepTime)
        {
            gameName = name;
            this.sleepTime = sleepTime;
            //Acest thread controlat din meniu
            player1Thread = new Thread(Add1);
            //Acest thread nu va fi suspendat din meniu
            player2Thread = new Thread(Substract1);
            //Acest thread nu va fi controlat din meniu
            Info();
            var showCounterThread = new Thread(ShowCounter);
            //Acesta este thread-ul principal si va dormi 5 sec
            Thread.Sleep(5000);
            showCounterThread.Start();
        }

        private void Add1()
        {
            while (true)
            {
                lock (lock1)
                {
                    counter++;
                }
                Thread.Sleep(random.Next(100));
            }
        }

        private void Substract1()
        {
            while (true)
            {
                lock (lock1)
                {
                    counter--;
                }
                Thread.Sleep(random.Next(100));
            }
        }

        public void ShowCounter()
        {
            while (true)
            {
                Console.WriteLine("{0} current value of counter is: {1}", gameName, counter);
                Thread.Sleep(100);
            }
        }

        public void Info()
        {
            Console.WriteLine("Game menu:");
            Console.WriteLine("s : to start the game");
            Console.WriteLine("p : to pause the game");
            Console.WriteLine("r : to resume the game");
            Console.WriteLine("e : to exit the game");
            Console.WriteLine("Apasa caracterul apoi ENTER");
            Console.WriteLine("La start vor porni si thread-ul producer si consumer.");
            Console.WriteLine("La pauza se opreste doar producer-ul.");
            Console.WriteLine("Pornim in 5 secunde.");
        }


        public void Start()
        {
            if (!started)
            {
                player1Thread.Start();
                player2Thread.Start();
                started = true;
                running = true;
            }
        }
        public void Stop()
        {
            if (started)
            {
                player1Thread.Abort();
                player2Thread.Start();
                started = false;
                running = false;
            }
        }
        public void Suspend()
        {
            if (started && running)
            {
                player1Thread.Suspend();
                running = false;
            }
        }
        public void Resume()
        {
            if (started && !running)
            {
                player1Thread.Resume();
                running = true;
            }
        }
    }
}
