namespace Curs17.BuiltInObserverBank
{
    public class RunExamples
    {
        public static void Run()
        {
            Bank bank = new Bank();

            Person p = new Person(bank);
            TourismAgency agency = new TourismAgency(bank);
            Importer importer = new Importer(bank);

            bank.Euro = 4.65;
            bank.Euro = 4.66;
        }
    }
}
