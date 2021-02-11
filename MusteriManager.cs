using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Tebrikler Müsteri Eklendi " + musteri.Ad + " " + musteri.Soyadi);
            
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Tebrikler Müsteri Listelendi "+ musteri.Ad+" "+ musteri.Soyadi);

        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Tebrikler Müsteri silindi " + musteri.Ad + " " + musteri.Soyadi);

        }

    }
}
