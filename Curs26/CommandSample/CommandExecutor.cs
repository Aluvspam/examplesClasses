using System;
using System.Collections.Concurrent;
using System.Threading;

namespace Curs26.CommandSample
{
    public class CommandExecutor : ICommandExecutor
    {
        private BlockingCollection<Command> commandQueue;
        private bool isInitialized;
        private object lockObject = new object();
        private bool running;

        public void Init()
        {
            if (!isInitialized)
            {
                lock (lockObject)
                {
                    if (!isInitialized)
                    {
                        try
                        {
                            commandQueue = new BlockingCollection<Command>(100);
                            Thread backgroundThread = new Thread(ExecuteCommands);
                            backgroundThread.IsBackground = true;
                            backgroundThread.Name = "Th1";
                            backgroundThread.Start();

                            Thread backgroundThread2 = new Thread(ExecuteCommands);
                            backgroundThread2.IsBackground = true;
                            backgroundThread2.Name = "Th2";
                            backgroundThread2.Start();
                        }
                        catch (Exception exc)
                        {
                            //log.Error("Error at service specific initialization", exc);
                            throw exc;
                        }

                        this.isInitialized = true;
                    }
                }
            }
        }

        public void AddSomeWork(string workItem)
        {
            Console.WriteLine("Adding work item: " + workItem);
            PutCommand(() =>
            {
                Console.WriteLine("{0} working... {1}", Thread.CurrentThread.Name,  workItem);
                Thread.Sleep(300);
                Console.WriteLine("{0} Work done!", Thread.CurrentThread.Name);
            });
            Thread.Sleep(100);
        }


        public void PutCommand(ExecuteHandle method)
        {
            if (!isInitialized)
            {
                Init();
            }

            var cmd = new Command();
            cmd.ExecuteHandle += method;
            commandQueue.Add(cmd);
        }

        private Command TakeCommand()
        {
            return commandQueue.Take();
        }

        private void ExecuteCommands()
        {
            var threadName = "BgThread id: " + Thread.CurrentThread.ManagedThreadId;
            //Thread.CurrentThread.Name = threadName;
            Console.WriteLine("Background thread started! Name: " + Thread.CurrentThread.Name);
            running = true;
            while (running)
            {
                Command command = TakeCommand();
                lock (lockObject)
                { 
                    command.Execute();
                }
            }
        }
    }
}
