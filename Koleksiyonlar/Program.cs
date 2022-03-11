using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Kaan", "Ege", "Serhat", "Bora" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "Cihan";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);
            // burada 0 dan 3. elemana kadar artık boş durumdadır,
            //sebebi ise =new string[5] kodu yazıldığıı anda
            //yeni bir referans belirlenir ve bi önceki dizinin elemanları yok olur
            //yeni dizi de ilk 3 eleman boştur ve 4. eleman olarak sadece cihanı yazdırı


            List<string> isimler2 = new List<string> { "Kaan", "Ege", "Serhat", "Bora" };
            //isimler2.Add("Kaan");
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Cihan");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

        }
    }
}