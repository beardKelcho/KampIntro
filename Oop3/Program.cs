using System;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {

            //I ifadesi interface olduuğunu belirtilir aynı sınıflar gibi hareket eder
            //
            IKrediManager ihtiyacKrediManager = new IhtıyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoogerService fileLoggerService = new FileLoggerService();

            List<ILoogerService> loggers=new List<ILoogerService> { new DataBaseLoggerService(),new FileLoggerService()};

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager,
                new List<ILoogerService> { new DataBaseLoggerService(),new SmsLoggerService() });
            basvuruManager.BasvuruYap(tasitKrediManager,new List<ILoogerService> { fileLoggerService });
            basvuruManager.BasvuruYap(konutKrediManager, loggers);
            basvuruManager.BasvuruYap(new EsnafKrediMenager(), new List<ILoogerService> { new SmsLoggerService() });

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}