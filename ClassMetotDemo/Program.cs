using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri Musteri1 = new Musteri();
            Musteri1.MusteriAdi = "Muammer";
            Musteri1.MusteriSoyAdi = "Sönmez";
            Musteri1.MusteriId = 123456;
            Musteri1.Sifre = true;


            Musteri Musteri2 = new Musteri();
            Musteri2.MusteriAdi = "Turan";
            Musteri2.MusteriSoyAdi = "Korkmaz";
            Musteri2.MusteriId = 654321;
            Musteri2.Sifre = true;


            Musteri Musteri3 = new Musteri();
            Musteri3.MusteriAdi = "Hakan";
            Musteri3.MusteriSoyAdi = "Korkmaz";
            Musteri3.MusteriId = 147852;
            Musteri3.Sifre = false;




            Musteri[] musteriler = new Musteri[] { Musteri1, Musteri2, Musteri3 };

            foreach (var mstr in musteriler)
            {
                Console.WriteLine(" Müşteri Adı: " + mstr.MusteriAdi + "\n Müşteri Soyadı: " + mstr.MusteriSoyAdi + "\n Kullanıcı Kimliği: " + mstr.MusteriId + "\n");

            }


            if (Musteri1.Sifre == true)
            {
                Console.WriteLine("Sayın " + Musteri1.MusteriAdi + " " + Musteri1.MusteriSoyAdi + " Hoşgeldiniz.Hesap İşemlerinizi Görebilirsiniz");
            }
            else
            {
                Console.WriteLine("Geçersiz Bilgi Lütfen Daha Sonra Tekrar Deneyiniz.");
            }

            if (Musteri2.Sifre == true)
            {
                Console.WriteLine("Sayın " + Musteri2.MusteriAdi + " " + Musteri2.MusteriSoyAdi + " Hoşgeldiniz.Hesap hareketlerinizi görebilirsiniz.");
            }
            else
            {
                Console.WriteLine("Hatalı Giriş Yaptınız.Lütfen Şifrenizi Tekrar Deneyiniz...");
            }

            if (Musteri3.Sifre == true)
            {
                Console.WriteLine("Sayın " + Musteri3.MusteriSoyAdi + " " + Musteri3.MusteriSoyAdi + "Hoşgeldiniz.Hesap hareketlerinizi görebilirsiniz.");
            }
            else
            {
                Console.WriteLine("Hatalı Giriş Yaptınız.Lütfen Şifrenizi Tekrar Deneyiniz...");
            }

        }
    }




    class Musteri
    {
        public string MusteriAdi { get; set; }

        public string MusteriSoyAdi { get; set; }

        public int MusteriId { get; set; }

        public bool Sifre { get; set; }
    }
}

