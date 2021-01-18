using System;

namespace BankaKonto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

    Musteri musteri1 = new Musteri();
    musteri1.Ad = "Ihsan";
    musteri1.Soyad = "A";

    Musteri musteri2 = new Musteri();
    musteri2.Ad = "Sinem";
    musteri2.Soyad = "A";


    Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

    MusteriManager musteriManager = new MusteriManager();

    musteriManager.Ekle(musteri1);
    musteriManager.Ekle(musteri2);

    musteriManager.Listele(musteriler);

    musteriManager.Sil(musteriler,musteri1);

    musteriManager.Listele(musteriler);

        }
    }
}
