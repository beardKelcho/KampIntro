using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Musteri musteri1=new Musteri();
            //musteri1.Adi = "Kaan";
            //musteri1.Soyadi = "Çolak";
            //musteri1.Id = 1;
            //musteri1.TcNo = "1111111111";
            //musteri1.MusteriNo = "12345";
            //musteri1.SirketAdi = "?"; // kaan bir şirket olmadığı için bu alan gereksiz
                                       // class ın bu özellik burada manasız kalıyor


            GercekMusteri musteri1=new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Kaan";
            musteri1.Soyadi = "Çolak";
            musteri1.TcNo = "1234567890";


            TuzelMusteri musteri2=new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "BeardKelcho";
            musteri2.VergiNo = "0987654321";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager= new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);


        }
    }
}