namespace Curs26.CommandSample
{
    public interface ICommandExecutor
    {
        void AddSomeWork(string workItem);
        void Init();
    }
}