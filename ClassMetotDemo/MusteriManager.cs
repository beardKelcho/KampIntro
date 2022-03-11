using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.musteriId + " Id'li Kullanıcı Eklendi!"); 
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.musteriId + "Id'li Kullanıcı Silindi");
        }
        public void musteriListeleme(Musteri[] musteri)
        {
            
            foreach (Musteri mus in musteri)
            {
                Console.WriteLine(mus.musterininAdi);
                Console.WriteLine(mus.musterininSoyadi);
                Console.WriteLine(mus.Adresi);
            }
        }
    }
}
