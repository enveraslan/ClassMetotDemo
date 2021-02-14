using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. müşteri bilgilerini tanımla
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Isim = "Enver";
            musteri1.Soyisim = "ASLAN";
            musteri1.Bakiye = 10000.0F;

            // 2. müşteri bilgilerini tanımla
            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Isim = "Ali Fuat";
            musteri2.Soyisim = "ALKAYA";
            musteri2.Bakiye = 50000.0F;

            // 3. müşteri bilgilerini tanımla
            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Isim = "Abdulkadir";
            musteri3.Soyisim = "ASLAN";
            musteri3.Bakiye = 5000.0F;

            // Müşteri listesini tanımla
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            // Müşteri ekleme, silme , güncelleme ve listeleme işlemi yapabilmek için MusteriManager
            // değişkenini tanımla
            MusteriManager musteriManager = new MusteriManager();

            // Musteri ekle
            musteriManager.Ekle(musteri1);

            // Musteri sil
            musteriManager.Sil(musteri2);

            // Musteri güncelle
            musteriManager.Güncelle(musteri1);

            // Musterileri listele
            musteriManager.Listele(musteriler);
        }
    }
}
