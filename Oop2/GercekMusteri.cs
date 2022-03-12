using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{
    class GercekMusteri:Musteri // bu olaya miras vermek denir
                                // :  sonraki sınıf kapsayıcıı sınıftır
                                //burada gercekmusteri de musteridir denmek istenir
                                // musteri de ki tum ozellikler gercekmusteri de vardır.
    {
       
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TcNo { get; set; }
    }
}
