using System;

namespace Curs17.BankExample
{
    class Importer : AbstractClient
    {
        public Importer(Bank bank) : base(bank)
        {
        }

        public override void Notify()
        {
            var eur = Bank.Euro;
            Console.WriteLine("I would like to buy 10000 euros for {0} per euro", eur);
        }
    }
}
