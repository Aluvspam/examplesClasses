namespace Curs17.BankExample
{
    abstract class AbstractClient
    {
        protected Bank Bank;
        public abstract void Notify();

        public AbstractClient(Bank bank)
        {
            Bank = bank;
        }
    }
}
