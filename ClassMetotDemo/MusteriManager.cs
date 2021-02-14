using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Isim + " " + musteri.Soyisim + " isimli müşteri eklendi.");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Isim + " " + musteri.Soyisim + " isimli müşteri silindi.");
        }

        public void Güncelle(Musteri musteri)
        {
            Console.WriteLine(musteri.Isim + " " + musteri.Soyisim + " isimli müşterinin bilgileri güncellendi.");
        }

        public void Listele(Musteri[] musteriler)
        {
            Console.WriteLine("Mevcut Müşterilerin Listesi");
            Console.WriteLine("---------------------------");
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + "#" + musteri.Isim + "#" + musteri.Soyisim + "#" + musteri.Bakiye);

            }
        }
    }
}
