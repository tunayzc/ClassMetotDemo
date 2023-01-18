using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Kaydınız Başarılı" + " " + "ID :" + musteri.MusteriId);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriId +" " + "ID numaralı kaydınız silinmiştir\nTekrar bekleriz");
        }

        public void List(Musteri musteri) 
        { 
            Console.WriteLine(musteri.MusteriAd + " " + musteri.MusteriSoyad + "(" + musteri.MusteriId +")");
        }
     
    }

}
