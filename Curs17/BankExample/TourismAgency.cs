using System;

namespace Curs17.BankExample
{
    class TourismAgency : AbstractClient
    {
        public TourismAgency(Bank bank) : base(bank)
        {
        }

        public override void Notify()
        {
            Console.WriteLine("Thanks, but I don't need any right now.");
        }
    }
}
