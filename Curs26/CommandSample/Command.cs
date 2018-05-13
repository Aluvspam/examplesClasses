namespace Curs26.CommandSample
{
    class Command : ICommand
    {
        public event ExecuteHandle ExecuteHandle;

        public void Execute()
        {
            if (ExecuteHandle != null)
            {
                ExecuteHandle();
            }
        }
    }
}
