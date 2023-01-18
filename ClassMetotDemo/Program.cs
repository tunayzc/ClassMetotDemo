using System;
namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1005;
            musteri1.MusteriAd = "Ahmet";
            musteri1.MusteriSoyad = "Yazıcı";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 5003;
            musteri2.MusteriAd = "Tuna";
            musteri2.MusteriSoyad = "Yazıcı";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("ID"+ ":" + " " + musteri.MusteriId + " " + "Ad-Soyad"+ ":" + " " + musteri.MusteriAd + " " + musteri.MusteriSoyad);
                
            }
            Console.WriteLine("---------Kayıt işlemleri-------------");
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            Console.WriteLine("----------Üyelik silme işlemleri------------");
            musteriManager.Sil(musteri1);

            Console.WriteLine("-------Kayıtlı müşterilerimiz--------");
            musteriManager.List(musteri2); 

        }
       

    }
}
