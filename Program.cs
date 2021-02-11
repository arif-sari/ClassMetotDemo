using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 101;
            musteri1.Ad = "Ahmet";
            musteri1.Soyadi = "Sag";
            musteri1.Cinsiyet = "Erkek";
            musteri1.Yas = 28;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 102;
            musteri2.Ad = "Hasan";
            musteri2.Soyadi = "Toprak";
            musteri2.Cinsiyet = "Erkek";
            musteri2.Yas = 17;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };


            foreach (var musteri in musteriler)  
            {
                Console.WriteLine(musteri.Id + " = "+ musteri.Ad + " " + musteri.Soyadi + "-" + musteri.Cinsiyet + "-" + musteri.Yas + "Yaş" );

               
            }

            Console.WriteLine("-------------------------");



            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            Console.WriteLine("------------");

            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            Console.WriteLine("------------");

            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);

            
            
            

            

        }
    }
}
