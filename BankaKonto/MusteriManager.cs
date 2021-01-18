using System;
using System.Collections.Generic;
using System.Text;

namespace BankaKonto
{
    class MusteriManager
{
    public void Ekle(Musteri musteri)
    {
        Console.WriteLine(musteri.Ad + " isimli musteri icin hesap olusturulmustur...");
    }

    public void Listele(Musteri[] musteriler)
    {
        foreach (Musteri musteri in musteriler)
        {
            Console.WriteLine(musteri.Ad);
        }
        Console.WriteLine("Musteriler Listelendi...");
    }

    public Musteri[] Sil(Musteri[] musteriler,Musteri musteri)
    {
       Console.WriteLine(musteri.Ad + " isimli musteriye ait hesap silinmistir...");

        return musteriler;
    }
}

}
