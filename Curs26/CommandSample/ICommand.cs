namespace Curs26.CommandSample
{
    public interface ICommand
    {
        event ExecuteHandle ExecuteHandle;
        void Execute();
    }
}