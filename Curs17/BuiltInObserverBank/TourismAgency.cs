using System;

namespace Curs17.BuiltInObserverBank
{
    class TourismAgency : AbstractClient
    {
        public TourismAgency(Bank bank) : base(bank)
        {
            Bank.PropertyChanged += Bank_PropertyChanged;
        }

        private void Bank_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Console.WriteLine("Thanks, but I don't need any right now.");
        }
    }
}
