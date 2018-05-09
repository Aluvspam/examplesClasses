namespace Curs26.CommandSample
{
    public class RunExamples
    {
        public static void Run()
        {
            CommandExecutor ce = new CommandExecutor();
            for (int i = 0; i < 30; i++)
            {
                ce.AddSomeWork(i.ToString());
            }
        }
    }
}
