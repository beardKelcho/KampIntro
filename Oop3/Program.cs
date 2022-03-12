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

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager);
            basvuruManager.BasvuruYap(tasitKrediManager);
            basvuruManager.BasvuruYap(konutKrediManager);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager};

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}