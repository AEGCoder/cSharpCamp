internal class Program
{
    private static void Main(string[] args)
    {
        IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();

        IKrediManager tasitKrediManager = new TasitKrediManager();

        IKrediManager konutKrediManager = new KonutKrediManager();

         IloggerServices databaseLoggerService = new DatabaseLoggerService();
            IloggerServices fileLoggerService = new FileLoggerService();

        BasvuruManager basvuruManager = new BasvuruManager();
        basvuruManager.BasvuruYap(tasitKrediManager, databaseLoggerService);

        List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager};

        //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        
    }
}