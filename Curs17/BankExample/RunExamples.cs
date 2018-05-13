namespace Curs17.BankExample
{
    public class RunExamples
    {

        public static void Run()
        {
            Bank bank = new Bank();

            Person p = new Person(bank);
            bank.Subscribe(p);

            TourismAgency agency = new TourismAgency(bank);
            bank.Subscribe(agency);

            Importer importer = new Importer(bank);
            bank.Subscribe(importer);

            bank.Euro = 4.45;
            bank.Euro = 4.46;
        }
    }
}
