using System;

namespace ClassIntro
{
    public class Program
    {
        static void Main(string[] args)
        {
            string adi = "Kaan";
            int yas = 32;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "kaan ÇOLAK";
            kurs1.IzlenmeOranı = 257;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "python";
            kurs2.Egitmen = "kaan ÇOLAK";
            kurs2.IzlenmeOranı = 257;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "java";
            kurs3.Egitmen = "kaan ÇOLAK";
            kurs3.IzlenmeOranı = 257;

            //Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2,kurs3};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }
    }
}
