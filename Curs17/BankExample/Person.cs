using System;

namespace Curs17.BankExample
{
    class Person : AbstractClient
    {
        public Person(Bank bank) : base(bank)
        {
        }

        public override void Notify()
        {
            Console.WriteLine("Thanks, please give me 1000 euros");
            Bank.Unsubscribe(this);
        }
    }
}
