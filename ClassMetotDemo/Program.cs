using System;

namespace ClassMetotDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1=new Musteri();
            musteri1.musteriId = 1;
            musteri1.musterininAdi = "Kaan";
            musteri1.musterininSoyadi = "ÇOLAK";
            musteri1.Adresi = "İstanbul";

            Musteri musteri2 = new Musteri();
            musteri2.musteriId = 2;
            musteri2.musterininAdi = "Serhat Yasin";
            musteri2.musterininSoyadi = "EROL";
            musteri2.Adresi = "İstanbul";

            Musteri[] musteriler = new Musteri[]{musteri1, musteri2 };
            //Musteri[] musteriler=new Musteri[] {musteri1,musteri2};

            //foreach (var musteri in musteriler)
            //{
            //    Console.WriteLine(musteri.musterininAdi);
            //    Console.WriteLine(musteri.musterininSoyadi);
            //    Console.WriteLine(musteri.Adresi);
            //}


            MusteriManager musterimanager = new MusteriManager();
            musterimanager.Ekle(musteri1);
            musterimanager.Ekle(musteri2);
            musterimanager.musteriListeleme(musteriler);
            musterimanager.Sil(musteri2);
            musterimanager.musteriListeleme(musteriler);
        }
    }
}