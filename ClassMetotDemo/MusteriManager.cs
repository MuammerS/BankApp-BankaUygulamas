using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        static void MusteriEkle(Musteri customer)
        {
            Console.WriteLine("Müşteri eklendi : " + customer.MusteriAdi);
        }

        static void MusteriListeleme(Musteri customer)
        {
            Console.WriteLine("Müşteri listelendi : " + customer.MusteriAdi + " " + customer.MusteriSoyAdi + " isimli müşterimiz. ");
        }

        static void MusteriSil(Musteri customer)
        {
            Console.WriteLine("Müşteri silindi : " + customer.MusteriAdi);
        }

        static void MusteriGuncelle(Musteri customer)
        {
            Console.WriteLine("Müşteri güncellendi : " + customer.MusteriAdi);
        }
    }
}