using System;

namespace UrunListeleme
{
    class program
    {
        static void Main(string[] args)
        {
            Urunler urun1 = new Urunler();
            urun1.UrunAdi = "Tayt";
            urun1.UrunFiyati = 120;
            urun1.UrunMensei = "Tayland";

            Urunler urun2 = new Urunler();
            urun2.UrunAdi = "Kazak";
            urun2.UrunFiyati = 250;
            urun2.UrunMensei = "Çin";

            Urunler urun3 = new Urunler();
            urun3.UrunAdi = "T-shirt";
            urun3.UrunFiyati = 100;
            urun3.UrunMensei = "Pekin";

            Urunler urun4 = new Urunler();
            urun4.UrunAdi = "Pantalon";
            urun4.UrunFiyati = 300;
            urun4.UrunMensei = "Türkiye";

            Urunler[] urunler = new Urunler[] { urun1, urun2, urun3, urun4 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi + " " + urun.UrunFiyati + " " +
                    urun.UrunMensei);
            }

            Console.WriteLine("Foreach Bitti");

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].UrunAdi + " " +
                    urunler[i].UrunFiyati + " " + urunler[i].UrunMensei);
            }

            Console.WriteLine("For Bitt");
            int index = 0;
            while (index <= urunler.Length)
            {
                Console.WriteLine(urunler[index].UrunAdi + " " + urunler[index].UrunFiyati +
                    " " + urunler[index].UrunMensei);
                index++;
            }


        }

    }

    class Urunler
    {
        public string UrunAdi { get; set; }
        public int UrunFiyati { get; set; }
        public string UrunMensei { get; set; }
    }
}